using OpdrachtCSharp2;

DateOnly[] beginenEinde = new [] { new DateOnly(2025, 06, 02), new DateOnly(2025, 07, 30) };

Instructeur instructeur1 = new Instructeur("Jan Jansen",1500,"jan.jansen@outlook.com",EInstructeurs.Ontwikkeling);
Instructeur instructeur2 = new Instructeur("Roos Roosen",1600,"roos.roosen@outlook.com",EInstructeurs.Netwerkbeheer);

Medewerker medewerker = new Medewerker("Piet Peeters",1550,10);

Gebouw gebouw1 = new Gebouw { Naam = "Gebouw Einstein", HuurprijsPerMaand = 1500 };
Gebouw gebouw2 = new Gebouw { Naam = "Gebouw Newton", HuurprijsPerMaand = 2500 };

IKost[] kosten = new IKost[]
{
    instructeur1,
    instructeur2,
    medewerker,
    gebouw1,
    gebouw2 
};

double totaleMaandkost = 0;

VerlofPeriode.CollectieveVerlofPeriode();

foreach (IKost kost in kosten)
{
    kost.Gegevens();
    Console.WriteLine();
    totaleMaandkost += kost.MaandKost;
}

Console.WriteLine($"Totale maandkost (personeel + infrastructuur): {totaleMaandkost} EUR");


