public class VerlofPeriode
{
    public string Naam { get; }
    public DateOnly Begin { get; }
    public DateOnly Eind { get; }
    
    
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
    
   

}