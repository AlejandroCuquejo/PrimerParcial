// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using Infraestructura.Modelos;
using Servicios.ContactosService;

CiudadModel nuevaCiudad = new CiudadModel(); //Tuve que dejar el codigo comentado 

CiudadService ciudadService = new CiudadService("Server=localhost;Port=5432;User Id=postgres;Password=6408;Database=PrimerParcialDB3;");
PersonaService personaService = new PersonaService("Server=localhost;Port=5432;User Id=postgres;Password=6408;Database=PrimerParcialDB3;");
ClienteService clienteService = new ClienteService("Server=localhost;Port=5432;User Id=postgres;Password=6408;Database=PrimerParcialDB3;");
CuentasService cuentaService = new CuentasService("Server=localhost;Port=5432;User Id=postgres;Password=6408;Database=PrimerParcialDB3;");
MovimientoService movimientoService = new MovimientoService("Server=localhost;Port=5432;User Id=postgres;Password=6408;Database=PrimerParcialDB3;");

// CIUDAD - Agregar datos a la DB
ciudadService.insertarCiudad(new Infraestructura.Modelos.CiudadModel {
    ciudad = "Pilar",
    departamento = "Ñeembucú",
    postal_code = 1542
});//

// CIUDAD - Mostrar datos en la DB
var MosCiudad = ciudadService.obtenerCiudad(2);
Console.WriteLine($"Id ciudad: {MosCiudad.id_ciudad} \nCiudad: {MosCiudad.ciudad} \ndepartamento: {MosCiudad.departamento} \nCodigo Postal: {MosCiudad.postal_code}");
//

// CIUDAD - Modificar datos en la DB
var ModCiudad = ciudadService.obtenerCiudad(1);
ModCiudad.ciudad = "Paraguarí";
ModCiudad.departamento = "Paraguarí";
ModCiudad.postal_code = 2056;
ciudadService.modificarCiudad(ModCiudad);
//

// CIUDAD - Eliminar datos en la DB
ciudadService.EliminarCiudad(2);
//

//============================================================================================================================================================//

// Persona - Agregar datos a la DB
personaService.insertarPersona(new Infraestructura.Modelos.PersonaModel() {
    id_ciudad = 1,
    nombre = "Edagar",
    apellido = "Samaniego",
    nro_documento = "589420",
    direccion = "Paseo de aa",
    celular = "85982659555",
    email = "edgarsamaniego@gmail.com",
    estado = "A",
});//

// Persona - Mostrar datos en la DB
var MosPersona = personaService.obtenerPersona(1);
Console.WriteLine($"Nombre: {MosPersona.nombre} \nApellido: {MosPersona.apellido} \nNroDocumento: {MosPersona.nro_documento}\nDireccion: {MosPersona.direccion}\nCelular: {MosPersona.celular}\nEmail: {MosPersona.email}\nEstado: {MosPersona.estado}");
//

// PERSONA - Modificar datos en la DB
var ModPersona  = personaService.obtenerPersona(2);
ModPersona.id_ciudad = 6;
ModPersona.nombre = "Ana";
ModPersona.apellido = "Metel";
ModPersona.nro_documento = "548624";
ModPersona.direccion = "Esq. eusebio ayala";
ModPersona.celular = "02598755546";
ModPersona.email = "anaayala@gmail.com";
ModPersona.estado = "A";
personaService.modificarPersona(ModPersona);
//

// CIUDAD - Eliminar datos en la DB
personaService.EliminarPersona(3);
//

//============================================================================================================================================================//

// Cliente - Agregar datos a la DB
clienteService.insertarCliente(new Infraestructura.Modelos.ClienteModel() {
    id_persona = 2,
    fecha_ingreso = DateTime.Now,
    calificacion = "8",
    estado = "A",
});//

// Cliente - Mostrar datos en la DB
var MosCliente = clienteService.obtenerCliente(1);
Console.WriteLine($"CodigoPersona: {MosCliente.id_persona} \nFecha ingreso: {MosCliente.fecha_ingreso} \nCalificacion: {MosCliente.calificacion}\nEstado: {MosCliente.estado}");
//

// Cliente - Modificar datos en la DB
var ModCliente = clienteService.obtenerCliente(1);
ModCliente.id_persona = 1;
ModCliente.fecha_ingreso = DateTime.Now;;
ModCliente.calificacion = "9";
ModCliente.estado = "I";
clienteService.modificarCliente(ModCliente);
//

// CIUDAD - Eliminar datos en la DB
clienteService.EliminarCliente(2);
//

//============================================================================================================================================================//

// CUENTAS - Agregar datos a la DB
cuentaService.insertarCuentas(new Infraestructura.Modelos.CuentasModel() {
    id_cliente = 1,
    nro_cuenta = "584",
    fecha_alta = DateTime.Now,
    tipo_cuenta = "Caja de ahorro",
    estado = "A",
    saldo = 155000,
    nro_contrato = "098",
    costo_mantenimiento = 150000,
    promedio_acreditacion = "5",
    moneda = "$",
});//

// CUENTAS - Mostrar datos en la DB
var MosCuenta = cuentaService.obtenerCuenta(1);
Console.WriteLine($"Codigo Cliente: {MosCuenta.id_cliente} \nNumero cuenta: {MosCuenta.nro_cuenta} \nFecha Alta: {MosCuenta.fecha_alta}\nTipo cuenta: {MosCuenta.tipo_cuenta}\nEstado: {MosCuenta.estado}\nSaldo: {MosCuenta.saldo}\nNro. contrato: {MosCuenta.nro_contrato}\nCosto mantenimiento: {MosCuenta.costo_mantenimiento}" +
                  $"\nPromedio acreditacion: {MosCuenta.promedio_acreditacion}\nMoneda: {MosCuenta.moneda}");
//

// CUENTAS - Modificar datos en la DB
var ModCuenta = cuentaService.obtenerCuenta(1);
ModCuenta.id_cliente = 1;
ModCuenta.nro_cuenta = "154";
ModCuenta.fecha_alta = DateTime.Now;;
ModCuenta.tipo_cuenta = "corriente";
ModCuenta.estado = "A";
ModCuenta.saldo = 120;
ModCuenta.nro_contrato = "525";
ModCuenta.costo_mantenimiento = 500;
ModCuenta.promedio_acreditacion = "10";
ModCuenta.moneda = "$";
cuentaService.modificarCuenta(ModCuenta);
//

// CUENTAS - Eliminar datos en la DB
cuentaService.EliminarCuentas(3);
//

//============================================================================================================================================================//

// Movimiento - Agregar datos a la DB
movimientoService.insertarMovimiento(new Infraestructura.Modelos.MovimientoModel() {
    id_cuentas = 1,
    fecha_movimiento = DateTime.Now,
    tipo_movimiento = "Extracion",
    saldo_anterior = 962656,
    saldo_actual = 25757,
    monto_movimiento = 77557,
    cuenta_origen = 5846255,
    cuenta_destino = 564656,
    canal_decimal = "15.02",
});//

// MIVIMIENTO - Mostrar datos en la DB
var MosMovimiento = movimientoService.obtenerMovimiento(2);
Console.WriteLine($"Codigo cuenta: {MosMovimiento.id_cuentas} \nFechaMovimiento: {MosMovimiento.fecha_movimiento} \nTipo movimiento: {MosMovimiento.tipo_movimiento}\nSaldo anterior: {MosMovimiento.saldo_anterior}\nSaldo actual: {MosMovimiento.saldo_actual}\nMontom movimiento: {MosMovimiento.monto_movimiento}\nCuenta origen: {MosMovimiento.cuenta_origen}\nCuenta destino: {MosMovimiento.cuenta_destino}" +
                  $"\ncCanal decimal: {MosMovimiento.canal_decimal}");
//

// MIVIMIENTO - Modificar datos en la DB
var ModMovimiento = movimientoService.obtenerMovimiento(2);
ModMovimiento.id_cuentas = 1;
ModMovimiento.fecha_movimiento = DateTime.Now;
ModMovimiento.tipo_movimiento = "Transferencia";
ModMovimiento.saldo_anterior = 70575;
ModMovimiento.saldo_actual = 55625;
ModMovimiento.monto_movimiento = 56365;
ModMovimiento.cuenta_origen = 76575;
ModMovimiento.cuenta_destino = 432432;
ModMovimiento.canal_decimal = "15.02";
movimientoService.modificarMovimiento(ModMovimiento);
//

// MOVIMIENTO - Eliminar datos en la DB
movimientoService.EliminarMovimiento(3);
//



