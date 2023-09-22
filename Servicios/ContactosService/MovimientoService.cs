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
        Console.WriteLine("Cuenta creada correctamente");
        movimientoDatos.insertarMovimiento(movimiento);
    }
    
    public MovimientoModel obtenerMovimiento(int id) {
        Console.WriteLine("Datos obtenidos correctamente");
        return movimientoDatos.obtenerMovimientoPorId(id);
    }
    
    public void modificarMovimiento(MovimientoModel movimiento) {
        //validarDatos(ciudad);
        Console.WriteLine("Cuenta editado correctamente");
        movimientoDatos.modificarMovimiento(movimiento);
    } 
    
    public MovimientoModel EliminarMovimiento(int id) {
        Console.WriteLine("Cuenta borrado correctamente");
        return movimientoDatos.EliminarMovimientoPorId(id);
    }
}