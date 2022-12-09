namespace KodStuga2
{

    class Program
    {
        static void Main(string[] args)
        {
            IWineCellar abwc = new WineCellar();
            Console.WriteLine($"My {nameof(abwc)} cellar can have maximum {WineCellar.maxNrBottles} bottles");

            Wine wine1 = new Wine { Year = 2000, Name = "Château Lafite Rothschild", Grape = GrapeVariants.CabernetSauvignon, Region = GrapeRegions.Bordeaux };
            bool bOK = abwc.InsertWine(wine1);

            Wine wine2 = new Wine { Year = 2010, Name = "Domaine de la Romanée-Conti", Grape = GrapeVariants.PinotNoir, Region = GrapeRegions.Burgundy };
            bOK = abwc.InsertWine(wine2);

            Wine wine3 = new Wine { Year = 2005, Name = "Giuseppe Quintarelli Amarone", Grape = GrapeVariants.Corvina, Region = GrapeRegions.Veneto };
            bOK = abwc.InsertWine(wine3);

            Wine wine4 = new Wine { Year = 2008, Name = "Sierra Cantabria", Grape = GrapeVariants.Tempranillo, Region = GrapeRegions.RiberaDelDuero };
            bOK = abwc.InsertWine(wine4);

            Wine wine5 = new Wine { Year = 1992, Name = "Screaming Eagle", Grape = GrapeVariants.CabernetSauvignon, Region = GrapeRegions.RiberaDelDuero };
            bOK = abwc.InsertWine(wine5);


            Console.WriteLine($"Wines in {nameof(abwc)}:");
            abwc.PrintWines();

            Console.WriteLine($"\nNr of bottles: {abwc.NrOfBottles()}");

            var grape = GrapeVariants.CabernetSauvignon;
            Console.WriteLine($"Nr of bottles of {grape}: {abwc.NrOfBottles(GrapeVariants.CabernetSauvignon)}");


            IWineCellar abwc1 = new WineCellar();
            Console.WriteLine($"\n\nMy {nameof(abwc1)} cellar can have maximum {WineCellar.maxNrBottles} bottles");
            
            abwc1.InsertWine(new Wine { Year = 2000, Name = "An even better wine", Grape = GrapeVariants.CabernetSauvignon, Region = GrapeRegions.Bordeaux });

            Console.WriteLine($"Wines in {nameof(abwc1)}:");
            abwc1.PrintWines();

            Console.WriteLine($"\nNr of bottles: {abwc1.NrOfBottles()}");

            grape = GrapeVariants.CabernetSauvignon;
            Console.WriteLine($"Nr of bottles of {grape}: {abwc1.NrOfBottles(GrapeVariants.CabernetSauvignon)}");
        }
    }
}

/* Exercises
1. Implementera WineCellar och testköra koden
2. Implementera en metod i WineCellar som svara om ett vin från en region eller druva finns i källaren
3. Ändra Wine från struct till class
4. Skapa ett interafce IWine och ändra Wine till IWine på relevanta ställen
*/