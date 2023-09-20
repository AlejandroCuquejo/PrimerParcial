using Infraestructura.Conexiones;
using System.Data;
namespace Infraestructura.Datos;
using Infraestructura.Modelos;

public class CiudadDatos {

  private ConexionDB conexion;
  
  public CiudadDatos(string cadenaConexion) {
    conexion = new ConexionDB(cadenaConexion);
  }
  
  public void insertarCiudad(CiudadModel ciudad)
  {
    var conn = conexion.GetConexion();
    var comando = new Npgsql.NpgsqlCommand("INSERT INTO ciudad( ciudad, departamento, postal_code)" +
                                           "VALUES(@ciudad, @departamento, @postal_code)", conn);
    comando.Parameters.AddWithValue("ciudad", ciudad.ciudad);
    comando.Parameters.AddWithValue("departamento", ciudad.departamento);
    comando.Parameters.AddWithValue("postal_code", ciudad.postal_code);

    comando.ExecuteNonQuery();
  }
  
  public CiudadModel obtenerCiudadPorId(int id) {
    var conn = conexion.GetConexion();
    var comando = new Npgsql.NpgsqlCommand($"Select * from ciudad where id_ciudad = {id}", conn);
    using var reader = comando.ExecuteReader();
    if (reader.Read())
    {
      return new CiudadModel
      {
        id_ciudad = reader.GetInt32("id_ciudad"),
        ciudad = reader.GetString("ciudad"),
        departamento = reader.GetString("departamento"),
        postal_code = reader.GetInt32("postal_code")
      };
    }
    return null;
  }
  
  public void modificarCiudad(CiudadModel ciudad) {
    var conn = conexion.GetConexion();
    var comando = new Npgsql.NpgsqlCommand($"UPDATE ciudad SET ciudad = '{ciudad.ciudad}', " +
                                           $"departamento = '{ciudad.departamento}', " +
                                           $"postal_code = '{ciudad.postal_code}' " +
                                           $" WHERE id_ciudad = {ciudad.id_ciudad}", conn);
    comando.ExecuteNonQuery();
  }

  public CiudadModel EliminarCiudadPorId(int id) {
    var conn = conexion.GetConexion();
    var comando = new Npgsql.NpgsqlCommand($"DELETE FROM ciudad WHERE id_ciudad = {id}", conn);
    using var reader = comando.ExecuteReader();
    return null;
  }
  
}