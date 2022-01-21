using System;

namespace CodingChallenge
{
    public class Solution 
    {
        public static int NumJewelsInStones(string jewels, string stones) 
        {
            int count = 0;
            foreach(var ch in jewels)
            {
                for(int i=0;i<stones.Length;i++)
                {
                    if(ch==stones[i])
                    {
                        count++;
                    }
                }
            }
            return count;
        }
        public static void Main(String[] args)
        {
            string jewels = "aA";
            string stones = "aAAbbC";
            int count = NumJewelsInStones(jewels, stones);
            Console.WriteLine(count);
        }
    }
}