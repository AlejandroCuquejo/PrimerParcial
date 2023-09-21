using Infraestructura.Datos;
using Infraestructura.Modelos;

namespace Servicios.ContactosService;

public class MovimientoService {
    MovimientoDatos movimientoDatos;

    public MovimientoService(string cadenaConexion) {
        movimientoDatos = new MovimientoDatos(cadenaConexion);
    }
    
    public void insertarMovimiento(MovimientoModel movimiento) {
        //validarDatos(ciudad);
        movimientoDatos.insertarMovimiento(movimiento);
    }
    
    public MovimientoModel obtenerMovimiento(int id) {
        return movimientoDatos.obtenerMovimientoPorId(id);
    }
    
    public void modificarMovimiento(MovimientoModel movimiento) {
        //validarDatos(ciudad);
        movimientoDatos.modificarMovimiento(movimiento);
    } 
    
    public MovimientoModel EliminarMovimiento(int id) {
        Console.WriteLine("Usuario borrado correctamente");
        return movimientoDatos.EliminarMovimientoPorId(id);
    }
}