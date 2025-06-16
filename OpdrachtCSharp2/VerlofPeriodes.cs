public class VerlofPeriode
{
    public string Naam { get; }
    public DateOnly Begin { get; }
    public DateOnly Eind { get; }
    
    public static readonly VerlofPeriode[] AllePeriodes = { new VerlofPeriode("ZomerVakantie", new DateOnly(2025, 7, 1), new DateOnly(2025, 7, 31)), new VerlofPeriode("KerstVakantie", new DateOnly(2025, 12, 25), new DateOnly(2026, 1, 1)) };
    
    public VerlofPeriode(string naam, DateOnly begin, DateOnly eind)
    {
        Naam = naam;
        Begin = begin;
        Eind = eind;
    }
    
    
    public void Toon()
    {
        Console.WriteLine($"{Naam} - {Begin} tot {Eind}");
    }
    
    public static void CollectieveVerlofPeriode()
    {
        Console.WriteLine("De Collectieve Verlofperiodes:");
        Console.WriteLine("------------------------------");

        foreach (VerlofPeriode periode in AllePeriodes)
        {
            periode.Toon();
        }
        Console.WriteLine();
    }

}