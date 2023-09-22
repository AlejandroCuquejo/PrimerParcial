using Infraestructura.Datos;
using Infraestructura.Modelos;

namespace Servicios.ContactosService;

public class CiudadService {
    
    CiudadDatos ciudadDatos;

    public CiudadService(string cadenaConexion) {
        ciudadDatos = new CiudadDatos(cadenaConexion);
    }
    
    public void insertarCiudad(CiudadModel ciudad) {
        Console.WriteLine("Ciudad creada correctamente");
        ciudadDatos.insertarCiudad(ciudad);
    }
    
    public CiudadModel obtenerCiudad(int id) {
        Console.WriteLine("Ciudad obtenidos correctamente");
        return ciudadDatos.obtenerCiudadPorId(id);
    }
    
    public void modificarCiudad(CiudadModel ciudad) {
        Console.WriteLine("Ciudad editado correctamente");
        ciudadDatos.modificarCiudad(ciudad);
    }  
    
    public CiudadModel EliminarCiudad(int id) {
        Console.WriteLine("Ciudad borrado correctamente");
        return ciudadDatos.EliminarCiudadPorId(id);
    }
    
}