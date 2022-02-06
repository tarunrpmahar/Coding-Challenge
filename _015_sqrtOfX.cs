using System;

namespace CodingChallenge
{
    public class Solution 
    {
        public static int MySqrt(int x) 
        {
            long temp = 0;
            if(x==1)
            {
                return x;
            }
            for(long i=1;i<x;i++)
            {
                if(i*i <= x)
                {
                    temp = i;
                }
                else
                {
                    break;
                }
            }
            return (int)temp;
        }
        public static void Main(String[] args)
        {
            int x = 25;
            int result = MySqrt(x);
            Console.WriteLine(result);
        }
    }
}