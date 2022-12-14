using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodStuga3
{
    public class WineCellar : IWineCellar
    {
        static public EventHandler<Wine> ExpensiveWine;

        public List<Wine> myCellar = new List<Wine>();

        public void Add(Wine wine) => myCellar.Add(wine);
        public int NrOfBottles() => myCellar.Count;
        public int NrOfBottles(GrapeVariants grape) => myCellar.Where(w => w.Grape == grape).Count();

        public override string ToString()
        {
            //Your code
            var sRet = "";
            foreach (var item in myCellar)
            {
                if (item.Year != null)
                {
                    sRet += $"{item}\n";
                }
            }
            return sRet;
        }

        public static class Factory
        {
            public static WineCellar CreateRandom(int NrOfItems)
            {

                var myList = new WineCellar();
                for (int i = 0; i < NrOfItems; i++)
                {
                    var wine = Wine.Factory.CreateRandom();
                    myList.myCellar.Add(wine);

                    if (wine.Price >= 1000)
                    {
                        ExpensiveWine?.Invoke(null, wine);
                    }

                }
                return myList;
            }
        }

    }
}
