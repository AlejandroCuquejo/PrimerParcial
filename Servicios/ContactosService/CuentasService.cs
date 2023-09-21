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
        cuentasDatos.insertarCuentas(cuentas);
    }
    
    public CuentasModel obtenerCuenta(int id) {
        return cuentasDatos.obtenerCuentasPorId(id);
    }
    
    public void modificarCuenta(CuentasModel cuentas) {
        //validarDatos(ciudad);
        cuentasDatos.modificarCuenta(cuentas);
    } 
    
    public CuentasModel EliminarCuentas(int id) {
        Console.WriteLine("Usuario borrado correctamente");
        return cuentasDatos.EliminarCuentaPorId(id);
    }
    
   
}
