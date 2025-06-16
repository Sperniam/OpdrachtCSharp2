namespace OpdrachtCSharp2;

public class Gebouw : IKost
{
    public string Naam { get; set; }
    public double HuurprijsPerMaand { get; set; }
    
    public double MaandKost => HuurprijsPerMaand;
    
    public void Gegevens()
    {
        Console.WriteLine($"Gebouw {Naam} - Huur: {HuurprijsPerMaand} euro \nMaandelijkse kost: {MaandKost} euro");
    }
    
}