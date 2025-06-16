namespace OpdrachtCSharp2;

public class Instructeur : Personeel
{
    public EInstructeurs Vakgebied { get; }

    public override void Gegevens()
    {
        base.Gegevens();
        Console.WriteLine($"Instructeur {Vakgebied} (e-mail: {EmailAdres})");
    }

    public Instructeur(string naam, double loon, string email, DateOnly[] verlof, EInstructeurs vakgebied)
        : base(naam, loon, email)
    {
        Vakgebied = vakgebied;
    }
    
}

