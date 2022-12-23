﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodStuga3
{
    public class WineCellar : IWineCellar
    {
        List<Wine> myCellar = new List<Wine>();

        public void Add(Wine wine) => myCellar.Add(wine);
        public int NrOfBottles() => myCellar.Count;
        public int NrOfBottles(GrapeVariants grape)
        {
            //Your code
            int c = 0;
            for (int i = 0; i < myCellar.Count; i++)
            {
                if (myCellar[i].Grape == grape)
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
                if (item.Year != null)
                {
                    Console.WriteLine(item);
                }
            }
        }

        public static class Factory
        {
            public static WineCellar CreateRandom(int NrOfItems)
            {

                var myList = new WineCellar();
                for (int i = 0; i < NrOfItems; i++)
                {
                    var afriend = Wine.Factory.CreateRandom();
                    myList.myCellar.Add(afriend);
                }
                return myList;
            }
        }

    }
}
