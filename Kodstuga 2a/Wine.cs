using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodStuga2a
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
    public struct Wine
    {
        public int? Year;                   // null = undefined
        public string Name;
        public GrapeVariants Grape;
        public GrapeRegions Region;

        /// <summary>
        /// Creates a string representing the content of the Wine struct
        /// </summary>
        /// <returns>string that can be printed out using Console.WriteLine</returns>
        public override string ToString()
        {
            //Your code
            return $"Wine {Year} {Name} is made of {Grape} from {Region}";
        }
    }
}
