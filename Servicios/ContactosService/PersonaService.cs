using Infraestructura.Datos;
using Infraestructura.Modelos;


namespace Servicios.ContactosService;

public class PersonaService {
    
    PersonaDatos personaDatos;
    
    public PersonaService(string cadenaConexion) {
        personaDatos = new PersonaDatos(cadenaConexion);
    }
    
    public void insertarPersona(PersonaModel persona) {
        //validarDatos(ciudad);
        personaDatos.insertarPersona(persona);
    }
    
    public PersonaModel obtenerPersona(int id) {
        return personaDatos.obtenerPersonaPorId(id);
    }
    
    public void modificarPersona(PersonaModel persona) {
        //validarDatos(ciudad);
        personaDatos.modificarPersona(persona);
    } 
    
    public PersonaModel EliminarPersona(int id) {
        Console.WriteLine("Usuario borrado correctamente");
        return personaDatos.EliminarPersonaPorId(id);
    }
}