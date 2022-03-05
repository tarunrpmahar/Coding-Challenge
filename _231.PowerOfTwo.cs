using System;
namespace CodingChallenge
{
    public class Solution
    {
        public static bool IsPowerOfTwoBruteForceApproach(int n)
        {
            while(n>=1)
            {
                if(n==1)
                    {
                        return true;
                    }
                
                if(n%2!=0)
                {
                    return false;
                }
                else
                {
                    n=n/2;
                    
                }
            }
            return false;
        }

        public static bool IsPowerOfTwoLogApproach(int n)  // doesn't work - 536870912
        {
            double ceilOfN = Math.Ceiling(Math.Log(n,2));
            //Console.WriteLine(ceilOfN);
            double floorOfN = Math.Floor(Math.Log(n,2));
            //Console.WriteLine(floorOfN);
            if(ceilOfN == floorOfN)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void Main(String[] args)
        {
            var isPowerOfTwoBruteForce = IsPowerOfTwoBruteForceApproach(16);
            var isPowerOfTwoLog = IsPowerOfTwoLogApproach(1);
            Console.WriteLine("using brute force: {0}",isPowerOfTwoBruteForce);
            Console.WriteLine("using log, ceil and floor: {0}",isPowerOfTwoLog);
        }
    }
}