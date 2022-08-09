using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy1
{
    public class Case1
    {
        public static int GetProfit(int[] stockPrices)
        {

            int minPrice = stockPrices[0];
            int maxBenefit = stockPrices[1] - stockPrices[0];

            for (int i = 1; i < stockPrices.Length; i++)
            {
                int current = stockPrices[i];

                int temp = current - minPrice;

                maxBenefit = Math.Max(maxBenefit, temp);

                minPrice = Math.Min(minPrice, current);
            }

            if (maxBenefit < 0)
                maxBenefit = 0;

            return maxBenefit;
        }
    }
}
