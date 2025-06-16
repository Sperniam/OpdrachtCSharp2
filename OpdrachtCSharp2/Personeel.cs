
    using OpdrachtCSharp2;

    public abstract class Personeel : IKost
    {
        private static int nextId = 1;
        
        // Properties
        public string PersoneelsNaam { get;}
        public int PersoneelsNummer { get; }
        public double BrutoMaandLoon { get; }
        public string EmailAdres { get; }
        public double MaandKost => BrutoMaandLoon * 0.6;
        
        
        public virtual void Gegevens()
        {
            Console.WriteLine($"PersoneelsNummer: {PersoneelsNummer}");
            Console.WriteLine($"Naam: {PersoneelsNaam}");
            Console.WriteLine($"Brutomaandloon: {BrutoMaandLoon}");
            Console.WriteLine($"Maandelijkse Kost: {MaandKost} euro");
        }

        public static readonly (string naam,DateOnly Begin, DateOnly Eind)[] CollectieveVerlofPeriodes =
        {
            ("ZomerVakantie",new DateOnly(2025, 7, 1), new DateOnly(2025, 7, 31)),
            ("KerstVakantie",new DateOnly(2025, 12, 25), new DateOnly(2026, 1, 1))
        };
        public static void CollectieveVerlofPeriode()
        {
            Console.WriteLine("De Collectieve Verlofperiodes:");
            Console.WriteLine("------------------------------");
            
            foreach (var (naam,Begin, Eind) in CollectieveVerlofPeriodes)
            {
                Console.WriteLine($" {naam} - {Begin} tot {Eind}");
            }
            Console.WriteLine();
        } 
        
        // Constructor met alle nodige params
        protected Personeel(string personeelsNaam, double brutoMaandLoon, string emailAdres)
        {
            PersoneelsNummer = nextId;
            PersoneelsNaam = personeelsNaam;
            BrutoMaandLoon = brutoMaandLoon;
            nextId++;
            
            if (emailAdres.Contains("@"))
                EmailAdres = emailAdres;
            else
                EmailAdres = string.Empty;
                
            
        }
        
    }