using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOPM2_03_03
{
    class WineCellar
    {
        IWine[] Wines = null;

        public WineCellar(IWine[] wines)
        {
            Wines = wines;
        }
        public override string ToString()
        {
            string sRet = null;
            foreach (var wine in Wines)
            {
                sRet += wine.ToString();
                sRet += $" ({wine.GetType()})\n";
            }
            return sRet;
        }

        public IWine MostExpensive()
        {
            if (Wines == null) return null;

            decimal highestPrice = decimal.MinValue;
            int highestIdx = -1;
            for (int i = 0; i < Wines.Length; i++)
            {
                if (Wines[i].Price > highestPrice)
                {
                    highestIdx = i;
                    highestPrice = Wines[i].Price;
                }
            }
            return Wines[highestIdx];
        }
    }
}
