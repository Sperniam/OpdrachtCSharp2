namespace OpdrachtCSharp2;

public class Instructeurs : Personeel
{
    public Instructeur Vakgebied { get; }

    public string EmailAdres { get; }


    public override void Gegevens()
    {
        ToonBaseInfo();
        Console.WriteLine($"Instructeurs {Vakgebied} (e-mail: {EmailAdres})");
        MaandelijkseKost();
    }

    public Instructeurs(string naam, double loon, string email, Instructeur vakgebied)
        : base(naam, loon) //: base (roept constructor van Base class Personeel)
    {
        Vakgebied = vakgebied;
        if (email.Contains("@"))
            EmailAdres = email;
        else
            EmailAdres = string.Empty;
    }
}