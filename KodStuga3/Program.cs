namespace KodStuga3
{

    class Program
    {
        static void Main(string[] args)
        {
            WineCellar wineCellar = WineCellar.Factory.CreateRandom(10);
 
            Console.WriteLine($"Wines in {nameof(wineCellar)}:");
            Console.WriteLine(wineCellar);

            Console.WriteLine($"\nNr of bottles: {wineCellar.NrOfBottles()}");

            var grape = GrapeVariants.CabernetSauvignon;
            Console.WriteLine($"Nr of bottles of {grape}: {wineCellar.NrOfBottles(GrapeVariants.CabernetSauvignon)}");
        }
    }
}
