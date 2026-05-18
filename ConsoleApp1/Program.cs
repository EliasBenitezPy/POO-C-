Console.WriteLine("Ingrese la cilindrada del vehiculo.");
int cilindradaIngresada = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el número del motor del vehiculo.");
string? nrMotorIngresado = Console.ReadLine();

Console.WriteLine("Ingrese el número de la chapa.");
string? nrChapaIngresado = Console.ReadLine();

Console.WriteLine("Ingrese el color del vehiculo");
string? colorIngresado = Console.ReadLine();

Console.WriteLine("En que estado se encuentra el vehiculo?");
string? estadoIngresado = Console.ReadLine(); 


var moto = new Moto(cilindradaIngresada, nrMotorIngresado,nrChapaIngresado, colorIngresado, estadoIngresado);
public class Moto
{
    public int Cilindrada { get; set; }
    public string? NrMotor { get; set; }
    public string? NrChapa { get; set; }
    public string? Color { get; set; }
    public string? Estado { get; set; }

    public Moto (int cilindrada, string? nrMotor, string? nrChapa, string? color, string? estado)
    {
        Cilindrada = cilindrada;
        NrMotor = nrMotor;
        NrChapa = nrChapa;
        Color = color;
        Estado = estado;
    }

}
