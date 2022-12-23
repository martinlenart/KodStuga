namespace KodStuga3
{

    class Program
    {
        class WineShort
        {
            public string Name { get; set; }   
            public decimal Price { get; set;}

            public override string ToString() => $"{Name} @ {Price:C2}";
        }

        static void Main(string[] args)
        {
            WineCellar.ExpensiveWine = GreatWine;
            WineCellar wineCellar = WineCellar.Factory.CreateRandom(25);
 
            Console.WriteLine($"Wines in {nameof(wineCellar)}:");
            //Console.WriteLine(wineCellar);

            Console.WriteLine($"\nNr of bottles: {wineCellar.NrOfBottles()}");

            var grape = GrapeVariants.CabernetSauvignon;
            Console.WriteLine($"Nr of bottles of {grape}: {wineCellar.NrOfBottles(GrapeVariants.CabernetSauvignon)}");

            /*
            var wines = wineCellar.myCellar.Where((Wine w) =>
            {
                if ((w.Region == GrapeRegions.Bordeaux) || (w.Region == GrapeRegions.Piedmonte))
                    return true;
                else
                    return false;
            }).OrderByDescending(w => w.Name).ThenByDescending(w => w.Year);
            */

            var wines = wineCellar.myCellar.OrderByDescending(w => w.Name).ThenByDescending(w=>w.Year);
            foreach (var item in wines)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            var winegroups = wineCellar.myCellar.OrderBy(w=>w.Year).GroupBy(w => w.Year);
            foreach (var group in winegroups)
            {
                Console.WriteLine(group.Key);
                foreach (var wine in group.OrderBy(w=>w.Name))
                {
                    Console.WriteLine($"    {wine}");
                }
            }

            var alist = wineCellar.myCellar.Select((Wine w) =>
            {
                return new WineShort { Name = w.Name, Price = w.Price };
            });

            var totalValue = alist.Sum(w => w.Price);
            Console.WriteLine();
            Console.WriteLine(totalValue);
        }

        static void GreatWine (object sender, Wine e)
        {
            Console.WriteLine($"OOps, can I affor this wine {e}");
        }
    }
}
