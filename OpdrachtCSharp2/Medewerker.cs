namespace OpdrachtCSharp2;

public class Medewerker : Personeel
{
    public int AantalCursisten { get; }

    public Medewerker(string naam,  double loon, string email, DateOnly[] verlof, int aantalCursisten)
        : base(naam,loon, email)
    {
        AantalCursisten = aantalCursisten;
    }
    public override void Gegevens()
    {
        base.Gegevens();
        Console.WriteLine($"Aantal Cursisten: {AantalCursisten}");
        
    }
}
