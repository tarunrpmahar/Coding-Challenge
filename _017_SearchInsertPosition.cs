using System;

namespace CodingChallenge
{
    public class Solution 
    {
        public static int SearchInsert(int[] nums, int target) 
        {
            var low = 0;
            var high = nums.Length - 1;
            while(low<=high)
            {
                var mid = (low+high)/2;
                if(nums[mid]==target)
                {
                    return mid;
                }
                
                if(nums[mid]>target)
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid+1;
                }
            }
            return low;
        }
        public static void Main(String[] args)
        {
            int[] nums = {1,2,3,4,5,6};
            int target = 5;
            int index = SearchInsert(nums, target);
            Console.WriteLine(index);
        }
    }
}