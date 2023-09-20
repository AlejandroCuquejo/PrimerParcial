using Infraestructura.Conexiones;
using System.Data;
namespace Infraestructura.Datos;
using Infraestructura.Modelos;

public class ClienteDatos {
    
    private ConexionDB conexion;
    
    public ClienteDatos(string cadenaConexion) {
        conexion = new ConexionDB(cadenaConexion);
    }
    
    public void insertarCliente(ClienteModel cliente) {
        var conn = conexion.GetConexion();
        var comando = new Npgsql.NpgsqlCommand("INSERT INTO cliente( id_persona, fecha_ingreso, calificacion,estado)" +
                                               "VALUES(@id_persona, @fecha_ingreso, @calificacion, @estado)", conn);
        comando.Parameters.AddWithValue("id_persona", cliente.id_persona);
        comando.Parameters.AddWithValue("fecha_ingreso", cliente.fecha_ingreso);
        comando.Parameters.AddWithValue("calificacion", cliente.calificacion);
        comando.Parameters.AddWithValue("estado", cliente.estado);

        comando.ExecuteNonQuery();
    }
    
    public ClienteModel obtenerClientePorId(int id) {
        var conn = conexion.GetConexion();
        var comando = new Npgsql.NpgsqlCommand($"Select * from cliente where id_cliente = {id}", conn);
        using var reader = comando.ExecuteReader();
        if (reader.Read())
        {
            return new ClienteModel() {
                id_cliente = reader.GetInt32("id_cliente"),
                id_persona = reader.GetInt32("id_persona"),
                fecha_ingreso = reader.GetDateTime("fecha_ingreso"),
                calificacion = reader.GetString("calificacion"),
                estado = reader.GetString("estado"),
            };
        }
        return null;
    }
    
    public void modificarCliente(ClienteModel cliente) {
        var conn = conexion.GetConexion();
        var comando = new Npgsql.NpgsqlCommand($"UPDATE cliente SET id_persona = '{cliente.id_persona}', " +
                                               $"fecha_ingreso = '{cliente.fecha_ingreso}', " +
                                               $"calificacion = '{cliente.calificacion}', " +
                                               $"estado = '{cliente.estado}' " +
                                               $" WHERE id_cliente = {cliente.id_cliente}", conn);
        comando.ExecuteNonQuery();
    }
    
    public ClienteModel EliminarClientePorId(int id) {
        var conn = conexion.GetConexion();
        var comando = new Npgsql.NpgsqlCommand($"DELETE FROM cliente WHERE id_cliente = {id}", conn);
        using var reader = comando.ExecuteReader();
        return null;
    }
}