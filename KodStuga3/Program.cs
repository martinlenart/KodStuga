namespace KodStuga3
{

    class Program
    {
        class WineShort
        {
            string Name { get; set; }   
            decimal Price { get; set;}
        }

        static void Main(string[] args)
        {
            WineCellar wineCellar = WineCellar.Factory.CreateRandom(25);
 
            Console.WriteLine($"Wines in {nameof(wineCellar)}:");
            //Console.WriteLine(wineCellar);

            Console.WriteLine($"\nNr of bottles: {wineCellar.NrOfBottles()}");

            var grape = GrapeVariants.CabernetSauvignon;
            Console.WriteLine($"Nr of bottles of {grape}: {wineCellar.NrOfBottles(GrapeVariants.CabernetSauvignon)}");

            var wines = wineCellar.myCellar.Where((Wine w) =>
            {
                if ((w.Region == GrapeRegions.Bordeaux) || (w.Region == GrapeRegions.Piedmonte))
                    return true;
                else
                    return false;
            }).OrderByDescending(w => w.Name).ThenByDescending(w => w.Year);

            //wines = wineCellar.myCellar.OrderByDescending(w => w.Name).ThenByDescending(w=>w.Year);

            var winegroups = wineCellar.myCellar.OrderBy(w=>w.Year).GroupBy(w => w.Year);
            foreach (var group in winegroups)
            {
                Console.WriteLine(group.Key);
                foreach (var wine in group.OrderBy(w=>w.Name))
                {
                    Console.WriteLine($"    {wine}");
                }
            }

            /*
            foreach (var w in wines ) 
            {
                Console.WriteLine(w);
            }
            */
        }
    }
}
