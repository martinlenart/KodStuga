namespace KodStuga2a
{

    class Program
    {
        static void Main(string[] args)
        {

            IWineCellar abwc = new WineCellar();
            abwc.ExpensiveWine += WineListener1;
            abwc.ExpensiveWine += WineListener2;

            Console.WriteLine($"My {nameof(abwc)} cellar can have maximum {WineCellar.maxNrBottles} bottles");

            Wine wine1 = new Wine { Year = 2000, Name = "Château Lafite Rothschild", Grape = GrapeVariants.CabernetSauvignon, Region = GrapeRegions.Bordeaux };
            bool bOK = abwc.InsertWine(wine1);

            Wine wine2 = new Wine { Year = 2010, Name = "Domaine de la Romanée-Conti", Grape = GrapeVariants.PinotNoir, Region = GrapeRegions.Burgundy };
            bOK = abwc.InsertWine(wine2);

            Wine wine3 = new Wine { Year = 2005, Name = "Giuseppe Quintarelli Amarone", Grape = GrapeVariants.Corvina, Region = GrapeRegions.Veneto };
            bOK = abwc.InsertWine(wine3);

            Wine wine4 = new Wine { Year = 2008, Price = 1500,  Name = "Sierra Cantabria", Grape = GrapeVariants.Tempranillo, Region = GrapeRegions.RiberaDelDuero };
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

        public static void WineListener1 (object sender, Wine w)
        {
            Console.WriteLine($"Congrats your bought a wine that costs {w.Price:C}");
        }
        public static void WineListener2(object sender, Wine w)
        {
            Console.WriteLine($"Congrats again your bought a wine that costs {w.Price:C}");
        }

    }
}
//Exercise
//1. ändra struct Wine till class Wine och gör de kodändringar som behövs
//2. lägg till pris i Wine classen
//3. lägg till en class factory för att generera slumpmässiga viner
//4. avfyra ett event när ett vin över 500kr har skapats. Lyssna på eventet och skriv ut ett Grattis mededelande
//5. koda om NrOfBottles så att metoden tar en parameter av typen Func<Wine, bool> som returnerar true om en flaska ska räknas
//6. gör om punkt 4 och 5 till att använda Lambda expressions