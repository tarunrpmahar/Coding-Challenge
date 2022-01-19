using System;

namespace CodingChallenge
{
    public class Solution 
    {
        public static int MaxProfit(int[] prices) {
            int buy=Int32.MaxValue;
            int sell=0;
            for(int i=0;i<prices.Length;i++)
            {
                if(prices[i]<buy)
                {
                    buy=prices[i];
                }
                else if(prices[i]-buy>sell)
                {
                    sell=prices[i]-buy;
                }
            }
            return sell;
        }

        public static void Main(String[] args)
        {
            //int[] prices = {7,1,5,3,6,4};
            int[] prices = {7,6,4,3,1};
            int sell = MaxProfit(prices);
            Console.WriteLine(sell);
        }
    }
}