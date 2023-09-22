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
        Console.WriteLine("Persona creada correctamente");
        personaDatos.insertarPersona(persona);
    }
    
    public PersonaModel obtenerPersona(int id) {
        Console.WriteLine("Persona obtenidos correctamente");
        return personaDatos.obtenerPersonaPorId(id);
    }
    
    public void modificarPersona(PersonaModel persona) {
        //validarDatos(ciudad);
        Console.WriteLine("Persona editado correctamente");
        personaDatos.modificarPersona(persona);
    } 
    
    public PersonaModel EliminarPersona(int id) {
        Console.WriteLine("Persona borrado correctamente");
        return personaDatos.EliminarPersonaPorId(id);
    }
}