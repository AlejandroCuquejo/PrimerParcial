using Infraestructura.Datos;
using Infraestructura.Modelos;

namespace Servicios.ContactosService;

public class CuentasService {
    
    CuentasDatos cuentasDatos;
    
    public CuentasService(string cadenaConexion) {
        cuentasDatos = new CuentasDatos(cadenaConexion);
    }
    
    public void insertarCuentas(CuentasModel cuentas) {
        //validarDatos(ciudad);
        Console.WriteLine("Cuenta creada correctamente");
        cuentasDatos.insertarCuentas(cuentas);
    }
    
    public CuentasModel obtenerCuenta(int id) {
        Console.WriteLine("Datos obtenidos correctamente");
        return cuentasDatos.obtenerCuentasPorId(id);
    }
    
    public void modificarCuenta(CuentasModel cuentas) {
        //validarDatos(ciudad);
        Console.WriteLine("Cuenta editado correctamente");
        cuentasDatos.modificarCuenta(cuentas);
    } 
    
    public CuentasModel EliminarCuentas(int id) {
        Console.WriteLine("Cuenta borrado correctamente");
        return cuentasDatos.EliminarCuentaPorId(id);
    }
    
   
}
