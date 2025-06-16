namespace OpdrachtCSharp2;

public class Medewerker : Personeel
{
    public int AantalCursisten { get; }

    public Medewerker(string naam, double loon, int aantalCursisten)
        : base(naam, loon)
    {
        AantalCursisten = aantalCursisten;
    }

    public override void Gegevens()
    {
        ToonBaseInfo();
        Console.WriteLine($"Medewerker: {AantalCursisten} cursisten");
        MaandelijkseKost();
    }
}