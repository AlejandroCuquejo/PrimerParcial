using Infraestructura.Datos;
using Infraestructura.Modelos;

namespace Servicios.ContactosService;

public class ClienteService {
    
    ClienteDatos clienteDatos;

    public ClienteService(string cadenaConexion) {
        clienteDatos = new ClienteDatos(cadenaConexion);
    }
    
    public void insertarCliente(ClienteModel cliente) {
        clienteDatos.insertarCliente(cliente);
    }
    
    
    public ClienteModel obtenerCliente(int id) {
        return clienteDatos.obtenerClientePorId(id);
    }

    public void modificarCliente(ClienteModel cliente) {
        //validarDatos(ciudad);
        clienteDatos.modificarCliente(cliente);
    } 
    
    public ClienteModel EliminarCliente(int id) {
        Console.WriteLine("Usuario borrado correctamente");
        return clienteDatos.EliminarClientePorId(id);
    }
}