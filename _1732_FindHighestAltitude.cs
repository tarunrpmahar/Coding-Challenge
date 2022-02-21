using System;
namespace CodingChallenge
{
    public class Solution 
    {
        public static int KadenesAlgo(int[] gain)
        {
            int highestAltitude =0, temp = 0;
            for(int i=0;i<gain.Length;i++)
            {
                temp+=gain[i];
                if(temp > highestAltitude)
                {
                    highestAltitude = temp;
                }
            }
            return highestAltitude;
        }
        public static void Main(String[] args)
        {
            int[] gain = {-5,1,5,0,-7}; //{-4,-3,-2,-1,4,3,2};
            int highestAltitude = KadenesAlgo(gain);  //highestAltitude = 0
            Console.WriteLine(highestAltitude);
        }
    }  
}