using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodStuga3
{
    public interface IWineCellar
    {
        void Add(Wine wine);
        int NrOfBottles();
        int NrOfBottles(GrapeVariants grape);
    }
}
