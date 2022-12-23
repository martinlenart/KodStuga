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

            //var wines = wineCellar.myCellar.OrderByDescending(w => w.Name).ThenByDescending(w=>w.Year);
            foreach (var w in wines ) 
            {
                Console.WriteLine(w);
            }
        }
    }
}
