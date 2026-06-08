using System.Security.Principal;
using DashboardApp;

int cilindrada;
string? cilindradaEntrada;

do
{
    Console.WriteLine("Ingrese la cilindrada del vehiculo.");
    cilindradaEntrada = Console.ReadLine();

    if (!int.TryParse(cilindradaEntrada, out cilindrada))
    {
        Console.WriteLine("ERROR. Solo ingrese números enteros.");
    }
   
}while(!int.TryParse(cilindradaEntrada, out cilindrada));


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


var moto = new Moto(cilindrada ,nrChasis , nrMotorIngresado,nrChapaIngresado, colorIngresado, estadoIngresado);