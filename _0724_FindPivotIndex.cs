using System;
namespace CodingChallenge
{
    public class Solution 
    {
        public static int PivotIndex(int[] nums) 
        {
            for(int i=0;i<nums.Length;i++)
            {
                int lhs = 0;
                int rhs = 0;
                for(int j=0;j<i;j++)
                {
                    lhs+=nums[j];
                }
                for(int j=i+1;j<nums.Length;j++)
                {
                    rhs+=nums[j];
                }
                if(lhs==rhs)
                {
                    return i;
                }
            }
            return -1;
        }
        public static void Main(String[] args)
        {
            int[] nums = {1,7,3,6,5,6};
            int equilibriumIndex = PivotIndex(nums);  //equilibriumIndex = 3
            Console.WriteLine(equilibriumIndex);
        }
    }
}