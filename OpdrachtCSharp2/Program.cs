using OpdrachtCSharp2;

DateOnly[] beginenEinde = new [] { new DateOnly(2025, 06, 02), new DateOnly(2025, 07, 30) };

Instructeur instructeur1 = new Instructeur("Keisse Florian",1500,"Floriankeisse@outlook.com",beginenEinde,EInstructeurs.Ontwikkeling);
Instructeur instructeur2 = new Instructeur("Goens Sneppert",1600,"Goens.Sneps@outlook.com",beginenEinde,EInstructeurs.Netwerkbeheer);

Medewerker medewerker = new Medewerker("DeBacker Patje",1550,"PatjeDeBackere@outlook.com",beginenEinde,10);

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

Personeel.CollectieveVerlofPeriode();

foreach (IKost kost in kosten)
{
    kost.Gegevens();
    Console.WriteLine();
    totaleMaandkost += kost.MaandKost;
    
}

Console.WriteLine($"Totale maandkost (personeel + infrastructuur): {totaleMaandkost} EUR");


