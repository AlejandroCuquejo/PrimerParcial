// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using Infraestructura.Modelos;
using Servicios.ContactosService;

CiudadModel nuevaCiudad = new CiudadModel();

CiudadService ciudadService = new CiudadService("Server=localhost;Port=5432;User Id=postgres;Password=6408;Database=PrimerParcialDB3;");
PersonaService personaService = new PersonaService("Server=localhost;Port=5432;User Id=postgres;Password=6408;Database=PrimerParcialDB3;");
ClienteService clienteService = new ClienteService("Server=localhost;Port=5432;User Id=postgres;Password=6408;Database=PrimerParcialDB3;");

/*/ CIUDAD - Agregar datos a la DB
ciudadService.insertarCiudad(new Infraestructura.Modelos.CiudadModel {
    ciudad = "Aregua",
    departamento = "Central",
    postal_code = 1542
});/*/

/*/ CIUDAD - Mostrar datos en la DB
var MosCiudad = ciudadService.obtenerCiudad(2);
Console.WriteLine($"Id ciudad: {MosCiudad.id_ciudad} \nCiudad: {MosCiudad.ciudad} \ndepartamento: {MosCiudad.departamento} \nCodigo Postal: {MosCiudad.postal_code}");
/*/

/*/ CIUDAD - Modificar datos en la DB
var ModCiudad = ciudadService.obtenerCiudad(1);
ModCiudad.ciudad = "Ita";
ModCiudad.departamento = "Central";
ModCiudad.postal_code = 2056;
ciudadService.modificarCiudad(ModCiudad);
/*/

/*/ CIUDAD - Eliminar datos en la DB
ciudadService.EliminarCiudad(2);
/*/

//============================================================================================================================================================//

/*/ Persona - Agregar datos a la DB
personaService.insertarPersona(new Infraestructura.Modelos.PersonaModel() {
    id_ciudad = 1,
    nombre = "Edagar",
    apellido = "Samaniego",
    nro_documento = "589420",
    direccion = "Paseo de aa",
    celular = "85982659555",
    email = "edgarsamaniego@gmail.com",
    estado = "A",
});/*/

/*/ Persona - Mostrar datos en la DB
var MosPersona = personaService.obtenerPersona(1);
Console.WriteLine($"Nombre: {MosPersona.nombre} \nApellido: {MosPersona.apellido} \nNroDocumento: {MosPersona.nro_documento}\nDireccion: {MosPersona.direccion}\nCelular: {MosPersona.celular}\nEmail: {MosPersona.email}\nEstado: {MosPersona.estado}");
/*/

/*/ PERSONA - Modificar datos en la DB
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
/*/

/*/ CIUDAD - Eliminar datos en la DB
personaService.EliminarPersona(3);
/*/

//============================================================================================================================================================//

/*/ Cliente - Agregar datos a la DB
clienteService.insertarCliente(new Infraestructura.Modelos.ClienteModel() {
    id_persona = 2,
    fecha_ingreso = DateTime.Now,
    calificacion = "5",
    estado = "A",
});/*/

/*/ Cliente - Mostrar datos en la DB
var MosCliente = clienteService.obtenerCliente(1);
Console.WriteLine($"CodigoPersona: {MosCliente.id_persona} \nFecha ingreso: {MosCliente.fecha_ingreso} \nCalificacion: {MosCliente.calificacion}\nEstado: {MosCliente.estado}");
/*/

/*/ Cliente - Modificar datos en la DB
var ModCliente = clienteService.obtenerCliente(1);
ModCliente.id_persona = 1;
ModCliente.fecha_ingreso = DateTime.Now;;
ModCliente.calificacion = "9";
ModCliente.estado = "I";
clienteService.modificarCliente(ModCliente);
/*/

/*/ CIUDAD - Eliminar datos en la DB
clienteService.EliminarCliente(2);
/*/