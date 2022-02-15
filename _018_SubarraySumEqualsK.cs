using System;

namespace CodingChallenge
{
    public class Solution 
    {
        public static int SubarraySum(int[] nums, int k) 
        {
            int count = 0;
            for(int i=0;i<nums.Length-1;i++)
            {
                int temp = nums[i];
                if(temp==k)
                {
                    count++;
                }
                
                for(int j=i+1;j<nums.Length;j++)
                {
                    if(temp + nums[j] == k)
                    {
                        count++;
                    }
                    temp = temp + nums[j];
                }            
            }
            if(nums[nums.Length-1]==k)
                count++;
            
            return count;
        }
        public static void Main(String[] args)
        {
            int[] nums = {1,2,3,4,5,6};
            int k = 7;
            int count = SubarraySum(nums, k);
            Console.WriteLine(count);
        }
    }
}