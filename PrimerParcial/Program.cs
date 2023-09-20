// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using Servicios.ContactosService;

CiudadService ciudadService = new CiudadService("Server=localhost;Port=5432;User Id=postgres;Password=6408;Database=PrimerParcialDB;");

/*/ CIUDAD - Agregar datos a la DB
ciudadService.insertarCiudad(new Infraestructura.Modelos.CiudadModel {
    ciudad = "Aregua",
    departamento = "Central",
    postal_code = 1240
});/*/

/*/ CIUDAD - Mostrar datos en la DB
var ciudad = ciudadService.obtenerCiudad(2);
Console.WriteLine($"Id ciudad: {ciudad.id_ciudad} \nCiudad: {ciudad.ciudad} \ndepartamento: {ciudad.departamento} \nCodigo Postal: {ciudad.postal_code}");
/*/

/*/ CIUDAD - Modificar datos en la DB
var ciudad = ciudadService.obtenerCiudad(1);
ciudad.ciudad = "Ita";
ciudad.departamento = "Central";
ciudad.postal_code = 2056;
ciudadService.modificarCiudad(ciudad);
/*/

/*/ CIUDAD - Eliminar datos en la DB
ciudadService.EliminarCiudad(2);
/*/