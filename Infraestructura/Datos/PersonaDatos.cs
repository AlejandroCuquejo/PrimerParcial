using Infraestructura.Conexiones;
using System.Data;
namespace Infraestructura.Datos;
using Infraestructura.Modelos;

public class PersonaDatos {
    private ConexionDB conexion;
    public PersonaDatos(string cadenaConexion) {
        conexion = new ConexionDB(cadenaConexion);
    }
    
    public void insertarPersona(PersonaModel persona)
    {
        var conn = conexion.GetConexion();
        var comando = new Npgsql.NpgsqlCommand("INSERT INTO persona( id_ciudad,nombre, apellido, nro_documento,direccion,celular,email,estado)" +
                                               "VALUES(@id_ciudad, @nombre, @apellido, @nro_documento, @direccion,@celular,@email,@estado)", conn);
        comando.Parameters.AddWithValue("id_ciudad", persona.id_ciudad);
        comando.Parameters.AddWithValue("nombre", persona.nombre);
        comando.Parameters.AddWithValue("apellido", persona.apellido);
        comando.Parameters.AddWithValue("nro_documento", persona.nro_documento);
        comando.Parameters.AddWithValue("direccion", persona.direccion);
        comando.Parameters.AddWithValue("celular", persona.celular);
        comando.Parameters.AddWithValue("email", persona.email);
        comando.Parameters.AddWithValue("estado", persona.estado);

        comando.ExecuteNonQuery();
    }
    
    public PersonaModel obtenerPersonaPorId(int id) {
        var conn = conexion.GetConexion();
        var comando = new Npgsql.NpgsqlCommand($"Select * from persona where id_persona = {id}", conn);
        using var reader = comando.ExecuteReader();
        if (reader.Read())
        {
            return new PersonaModel() {
                id_persona = reader.GetInt32("id_persona"),
                id_ciudad = reader.GetInt32("id_ciudad"),
                nombre = reader.GetString("nombre"),
                apellido = reader.GetString("apellido"),
                nro_documento = reader.GetString("nro_documento"),
                direccion = reader.GetString("direccion"),
                celular = reader.GetString("celular"),
                email = reader.GetString("email"),
                estado = reader.GetString("estado"),
            };
        }
        return null;
    }
    
    public void modificarPersona(PersonaModel persona) {
        var conn = conexion.GetConexion();
        var comando = new Npgsql.NpgsqlCommand($"UPDATE persona SET id_ciudad = '{persona.id_ciudad}', " +
                                               $"nombre = '{persona.nombre}', " +
                                               $"apellido = '{persona.apellido}', " +
                                               $"nro_documento = '{persona.nro_documento}', " +
                                               $"direccion = '{persona.direccion}', " +
                                               $"celular = '{persona.celular}', " +
                                               $"email = '{persona.email}', " +
                                               $"estado = '{persona.estado}' " +
                                               $" WHERE id_persona = {persona.id_persona}", conn);
        comando.ExecuteNonQuery();
    }
    
    public PersonaModel EliminarPersonaPorId(int id) {
        var conn = conexion.GetConexion();
        var comando = new Npgsql.NpgsqlCommand($"DELETE FROM persona WHERE id_persona = {id}", conn);
        using var reader = comando.ExecuteReader();
        return null;
    }
}