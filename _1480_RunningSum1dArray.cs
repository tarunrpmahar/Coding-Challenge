using System;
namespace CodingChallenge
{
    public class Solution 
    {
        public static int[] RunningSum(int[] nums) 
        {
            int[] runningSum=new int[nums.Length];
            runningSum[0]=nums[0];
            for(int i=1;i<nums.Length;i++)
            {
                runningSum[i] = nums[i]+runningSum[i-1];
            }
            return runningSum;
        }
        public static void Main(String[] args)
        {
            int[] nums = {3,1,2,10,1}; 
            int[] runningSum = RunningSum(nums); 
            for(int i=0;i<runningSum.Length;i++)
            {
                Console.WriteLine(runningSum[i]);
            } 
        }
    }  
}