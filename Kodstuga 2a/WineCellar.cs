using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodStuga2a
{
    public class WineCellar : IWineCellar
    {
        public const int maxNrBottles = 20;
        Wine[] myCellar = new Wine[maxNrBottles];

        public event EventHandler<Wine> ExpensiveWine;
        public bool InsertWine(Wine wine)
        {
            //Your code
            for (int i = 0; i < myCellar.Length; i++)
            {
                if (myCellar[i] == null)
                {
                    myCellar[i] = wine;

                    if (wine.Price > 1000)
                        ExpensiveWine?.Invoke(this, wine);

                    return true;
                }
            }
            return false;
        }

        public int NrOfBottles()
        {
            //Your code
            int c = 0;
            for (int i = 0; i < myCellar.Length; i++)
            {
                if (myCellar[i] != null)
                {
                    c++;
                }
            }
            return c;
        }

        public int NrOfBottles(GrapeVariants grape)
        {
            //Your code
            int c = 0;
            for (int i = 0; i < myCellar.Length; i++)
            {
                if (myCellar[i] != null && myCellar[i].Grape == grape)
                {
                    c++;
                }
            }
            return c;
        }

        public void PrintWines()
        {
            //Your code
            foreach (var item in myCellar)
            {
                if (item != null)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
