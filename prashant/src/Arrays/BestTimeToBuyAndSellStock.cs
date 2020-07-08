using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
	class BestTimeToBuyAndSellStock
	{
        public int MaxProfitNSquare(int[] prices)
        {
            int profit = 0;

            for (int i = 0; i < prices.Length; i++)
            {
                for (int j = i + 1; j < prices.Length; j++)
                {
                    int diff = prices[j] - prices[i];
                    if (diff > 0 && diff > profit)
                    {
                        profit = diff;
                    }
                }
            }

            return profit;
        }

        public int MaxProfitN(int[] prices)
        {
            int min = int.MaxValue;
            int maxProfit = 0;

            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] < min)
                {
                    min = prices[i];
                }
                else if (prices[i] - min > maxProfit)
                {
                    maxProfit = prices[i] - min;
                }
            }

            return maxProfit;
        }
    }
}
