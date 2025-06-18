
    using OpdrachtCSharp2;

    public abstract class Personeel : IKost
    {
        private static int nextId = 1;
        
        // Properties
        public string PersoneelsNaam { get;}
        public int PersoneelsNummer { get; }
        public double BrutoMaandLoon { get; }
        
        public static readonly VerlofPeriode[] AllePeriodes = { new VerlofPeriode("Kerstmis", new DateOnly(2025, 12, 25), new DateOnly(2026, 1, 1)), new VerlofPeriode("ZomerVakantie", new DateOnly(2025, 7, 1), new DateOnly(2025, 7, 31)) };
        public double MaandKost => BrutoMaandLoon * 0.6;


        public virtual void Gegevens()
        {
           ToonBaseInfo();
           MaandelijkseKost();
        }

        public void ToonBaseInfo()
        {
            Console.WriteLine($"PersoneelsNummer: {PersoneelsNummer}");
            Console.WriteLine($"Naam: {PersoneelsNaam}");
            Console.WriteLine($"Brutomaandloon: {BrutoMaandLoon}");
        }

        public void MaandelijkseKost()
        {
            Console.WriteLine($"Maandlijkse Kost: {MaandKost} euro");
        }
        
        // Constructor met alle nodige params
        protected Personeel(string personeelsNaam, double brutoMaandLoon)
        {
            PersoneelsNummer = nextId;
            PersoneelsNaam = personeelsNaam;
            BrutoMaandLoon = brutoMaandLoon;
            nextId++;
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