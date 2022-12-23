namespace KodStuga3
{

    class Program
    {
        static void Main(string[] args)
        {
            IWineCellar abwc = WineCellar.Factory.CreateRandom(10);
 
            Console.WriteLine($"Wines in {nameof(abwc)}:");
            abwc.PrintWines();

            Console.WriteLine($"\nNr of bottles: {abwc.NrOfBottles()}");

            var grape = GrapeVariants.CabernetSauvignon;
            Console.WriteLine($"Nr of bottles of {grape}: {abwc.NrOfBottles(GrapeVariants.CabernetSauvignon)}");
        }
    }
}
