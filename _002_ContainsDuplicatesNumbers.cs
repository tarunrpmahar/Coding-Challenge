using System;
using System.Collections.Generic;

namespace ContainsDuplicates
{
	public class ContainsDuplicatesNumbers
	{
		public static void Main(String[] args)
		{
			int[] nums = {1,1,2,3,4};
			var result = ContainsDuplicate(nums);
			if(result)
			{
				Console.WriteLine("contains Duplicate");
			}
			else
			{
				Console.WriteLine("doesn't contains duplicate");
			}
		}

		public static bool ContainsDuplicate(int[] nums)
		{
			Dictionary<int, int> duplicate = new Dictionary<int, int>();
			for(int i=0;i<nums.Length;i++)
			{
				if(duplicate.ContainsKey(nums[i]))
				{
					return true;
				}
				else
				{
					duplicate.Add(nums[i], 0);
				}
			}
			return false;
		}
	}
}