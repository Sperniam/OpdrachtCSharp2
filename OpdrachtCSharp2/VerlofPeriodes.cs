public class VerlofPeriode
{
    public string Naam { get; }
    public DateOnly Begin { get; }
    public DateOnly Eind { get; }
    
    public static readonly VerlofPeriode[] AllePeriodes = { new VerlofPeriode("Kerstmis", new DateOnly(2025, 12, 25), new DateOnly(2026, 1, 1)), new VerlofPeriode("ZomerVakantie", new DateOnly(2025, 7, 1), new DateOnly(2025, 7, 31)) };
    
    public VerlofPeriode(string naam, DateOnly begin, DateOnly eind)
    {
        Naam = naam;
        Begin = begin;
        Eind = eind;
    }
    
    
    public void Toon()
    {
        Console.WriteLine($"  Verlofperiode {Naam}: {Begin} - {Eind}");
    }
    
    public static void CollectieveVerlofPeriode()
    {
        Console.WriteLine("Collectieve Verlofperiodes:");
        Console.WriteLine("---------------------------");

        foreach (VerlofPeriode periode in AllePeriodes)
        {
            periode.Toon();
        }
        Console.WriteLine();
    }

}