// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using Infraestructura.Modelos;
using Servicios.ContactosService;

CiudadModel nuevaCiudad = new CiudadModel();

CiudadService ciudadService = new CiudadService("Server=localhost;Port=5432;User Id=postgres;Password=6408;Database=PrimerParcialDB;");
PersonaService personaService = new PersonaService("Server=localhost;Port=5432;User Id=postgres;Password=6408;Database=PrimerParcialDB;");

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
    id_ciudad = 6,
    nombre = "Mario",
    apellido = "Medina",
    nro_documento = "584625",
    direccion = "Paseo de fatima",
    celular = "2657411251",
    email = "mariomedina@gmail.com",
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
