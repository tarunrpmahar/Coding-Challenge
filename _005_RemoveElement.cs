using System;

namespace RemoveGivenElement
{
    public class Solution {
        public static int RemoveElement(int[] nums, int val) {
            int k=0;
            for(int i=0;i<nums.Length;i++)
            {
                if(nums[i]!=val)
                {
                    nums[k]=nums[i];
                    k++;
                }
            }
            return k;
        }

        public static void Main(string[] args)
        {
            int[] nums = {0,1,2,2,3,0,4,2};
            int val = 2;
            int k = RemoveElement(nums, val);
            for(int i=0;i<k;i++)
            {
                Console.WriteLine(nums[i]);
            }
        }
    }
}