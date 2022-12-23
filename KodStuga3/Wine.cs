using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodStuga3
{
    public enum GrapeVariants
    {
        CabernetSauvignon, PinotNoir, Corvina, Shiraz, Merlot, Chablis,
        Riesling, Tempranillo
    }
    public enum GrapeRegions
    {
        Bordeaux, Burgundy, Veneto, Piedmonte, RiberaDelDuero,
        NapaValley, Puglia, Pfalz
    }
    public class Wine
    {
        public int? Year;                   // null = undefined
        public string Name;
        public GrapeVariants Grape;
        public GrapeRegions Region;

        /// <summary>
        /// Creates a string representing the content of the Wine struct
        /// </summary>
        /// <returns>string that can be printed out using Console.WriteLine</returns>
        public override string ToString() => $"Wine {Year} {Name} is made of {Grape} from {Region}";

        public static class Factory
        {
            public static Wine CreateRandom()
            {
                string[] _names = "Château Lafite Rothschild, Domaine de la Romanée-Conti, Giuseppe Quintarelli Amarone, Sierra Cantabria, Screaming Eagle".Split(", ");

                var rnd = new Random();
                string name = _names[rnd.Next(_names.Length)];
                GrapeVariants grape = (GrapeVariants) rnd.Next((int)GrapeVariants.CabernetSauvignon, ((int)GrapeVariants.Tempranillo + 1));
                GrapeRegions region = (GrapeRegions)rnd.Next((int)GrapeRegions.Bordeaux, ((int)GrapeRegions.Pfalz + 1));
                int year = rnd.Next(2000, 2022);

                Wine wine = new Wine { Name = name, Grape = grape, Region = region, Year = year };
                return wine;
            }
        }
    }
}
