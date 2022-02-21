using System;
namespace CodingChallenge
{
    public class Solution 
    {
        public static int MaxSubArray(int[] nums) 
        {
            int maxSum = Int32.MinValue;
            for(int i=0;i<nums.Length;i++)
            {
                for(int j=i;j<nums.Length;j++)
                {
                    int sum = 0;
                    for(int k=i;k<=j;k++)
                    {
                        sum+=nums[k];                   
                    }  
                    if(maxSum<sum)
                    {
                        maxSum=sum;
                    }
                }           
            }
            return maxSum;
        }
        public static int KadenesAlgo(int[] nums)
        {
            int maxSum = Int32.MinValue;
            int currSum = 0;
            for(int i=0;i<nums.Length;i++)
            {
                currSum+=nums[i];
                if(currSum>maxSum)
                {
                    maxSum = currSum;
                }
                if(currSum<0)
                {
                    currSum = 0;
                }            
            }
            return maxSum;
        }
        public static void Main(String[] args)
        {
            int[] nums = {-2,1,-3,4,-1,2,1,-5,4};
            int maxSubArraySum = KadenesAlgo(nums);  //MaxSubArraySum = 6
            Console.WriteLine(maxSubArraySum);
        }
    }  
}