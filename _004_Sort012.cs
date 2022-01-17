using System;
public class Solution {
    public static void SortColors(int[] nums) {
        int red = 0, white = 0, blue = 0;
        for(int i=0;i<nums.Length;i++)
        {
            if(nums[i]==0)
            {
                red++;
            }
            else if(nums[i]==1)
            {
                white++;
            }
            else
            {
                blue++;
            }
        }
        for(int i=0;i<red;i++)
        {
            nums[i] = 0;
        }
        for(int i=red;i<red+white;i++)
        {
            nums[i]=1;
        }
        for(int i=red+white;i<nums.Length;i++)
        {
            nums[i]=2;
        }
        for(int i=0;i<nums.Length;i++)
        {
            Console.WriteLine(nums[i]);
        }
    }

    public static void Main(string[] args)
    {
        int[] nums = { 0, 1, 1, 0, 1, 2, 1, 2, 0, 0, 0, 1 };
        SortColors(nums);
    }
}