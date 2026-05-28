using System.Security.Principal;
using DashboardApp;

Console.WriteLine("Ingrese la cilindrada del vehiculo.");
int cilindradaIngresada = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el número de chasis.");
string? nrChasis = Console.ReadLine();

Console.WriteLine("Ingrese el número del motor del vehiculo.");
string? nrMotorIngresado = Console.ReadLine();

Console.WriteLine("Ingrese el número de la chapa.");
string? nrChapaIngresado = Console.ReadLine();

Console.WriteLine("Ingrese el color del vehiculo");
string? colorIngresado = Console.ReadLine();

Console.WriteLine("En que estado se encuentra el vehiculo?");
string? estadoIngresado = Console.ReadLine(); 


var moto = new Moto(cilindradaIngresada,nrChasis , nrMotorIngresado,nrChapaIngresado, colorIngresado, estadoIngresado);

