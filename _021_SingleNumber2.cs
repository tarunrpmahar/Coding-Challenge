using System;

namespace CodingChallenge
{
	public class Solution 
	{
	    public int SingleNumberUsingDict(int[] nums) // using dictonary
	    {
	        Dictionary<int, int> dict = new Dictionary<int, int>();
	        
	        foreach(var num in nums)
	        {
	            if(dict.ContainsKey(num))
	            {
	                dict[num]++;
	            }
	            else
	            {
	                dict.Add(num, 1);
	            }
	        }
	        
	        return dict.FirstOrDefault(x => x.Value == 1).Key;
	    }

        public int SingleNumberUsingXor(int[] nums) // using dictonary
	    {
            int uniqueNumber = nums[0];
	        for(int i=1;i<nums.Length;i++)
            {
                uniqueNumber ^= nums[i];
            }
	        
	        return uniqueNumber;
	    }
        public static void Main(String[] args)
        {
            int[] nums = {7,6,7,6,1};
            int result = SingleNumberUsingDict(nums);
            Console.WriteLine(result);
        }
	}
}