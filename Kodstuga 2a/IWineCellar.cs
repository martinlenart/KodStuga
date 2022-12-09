using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodStuga2a
{
    public interface IWineCellar
    {
        public event EventHandler<Wine> ExpensiveWine;

        bool InsertWine(Wine wine);
        void PrintWines();
        int NrOfBottles();
        int NrOfBottles(GrapeVariants grape);
    }
}
