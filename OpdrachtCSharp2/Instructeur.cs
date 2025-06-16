namespace OpdrachtCSharp2;

public class Instructeur : Personeel
{
    public EInstructeurs Vakgebied { get; }
    
    public string EmailAdres { get; }


    public override void Gegevens()
    {
        base.Gegevens();
        Console.WriteLine($"Instructeur {Vakgebied} (e-mail: {EmailAdres})");
    }

    public Instructeur(string naam, double loon, string email, EInstructeurs vakgebied)
        : base(naam, loon)
    {
        Vakgebied = vakgebied;
        if (email.Contains("@"))
            EmailAdres = email;
        else
            EmailAdres = string.Empty;
    }
    
}

