namespace DashboardApp; 

public class Moto
{
    public int Cilindrada { get; init; }
    public string? NrChasis {get; init;}
    public string? NrMotor { get; init; }
    public string? NrChapa { get; init; }
    public string? Color { get; set; }
    public string? Estado { get; set; }

    public Moto (int cilindrada, string? nrChasis, string? nrMotor, string? nrChapa, string? color, string? estado)
    {
        Cilindrada = cilindrada;
        NrChasis = nrChasis;
        NrMotor = nrMotor;
        NrChapa = nrChapa;
        Color = color;
        Estado = estado;
    }

}