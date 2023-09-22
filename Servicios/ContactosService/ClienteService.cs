using Infraestructura.Datos;
using Infraestructura.Modelos;

namespace Servicios.ContactosService;

public class ClienteService {
    
    ClienteDatos clienteDatos;

    public ClienteService(string cadenaConexion) {
        clienteDatos = new ClienteDatos(cadenaConexion);
    }
    
    public void insertarCliente(ClienteModel cliente) {
        Console.WriteLine("Cliente creada correctamente");
        clienteDatos.insertarCliente(cliente);
    }
    
    public ClienteModel obtenerCliente(int id) {
        Console.WriteLine("Cliente obtenidos correctamente");
        return clienteDatos.obtenerClientePorId(id);
    }

    public void modificarCliente(ClienteModel cliente) {
        Console.WriteLine("Cliente editado correctamente");
        clienteDatos.modificarCliente(cliente);
    } 
    
    public ClienteModel EliminarCliente(int id) {
        Console.WriteLine("Cliente borrado correctamente");
        return clienteDatos.EliminarClientePorId(id);
    }
}