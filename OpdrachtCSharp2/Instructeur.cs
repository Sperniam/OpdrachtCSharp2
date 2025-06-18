namespace OpdrachtCSharp2;

public class Instructeur : Personeel
{
    public Vakgebied Vakgebied { get; }

    public string EmailAdres { get; }


    public override void Gegevens()
    {
        ToonBaseInfo();
        Console.WriteLine($"Instructeur {Vakgebied} (e-mail: {EmailAdres})");
        MaandelijkseKost();
    }

    public Instructeur(string naam, double loon, string email, Vakgebied vakgebied)
        : base(naam, loon) //: base (roept constructor van Base class Personeel)
    {
        Vakgebied = vakgebied;
        if (email.Contains("@"))
            EmailAdres = email;
        else
            EmailAdres = string.Empty;
    }
}