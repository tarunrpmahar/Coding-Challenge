using System;
namespace CodingChallenge
{
    public class Solution 
    {
        public static int[] TwoSumTwoPointerApproach(int[] numbers, int target)
        {
            int[] indexes = new int[2];
            int low = 0, high = numbers.Length - 1;  
            while(low<high)
            {
                if(numbers[low]+numbers[high]>target)
                {
                    high--;
                }
                else if(numbers[low]+numbers[high]<target)
                {
                    low++;
                }
                else
                {
                    break;
                }
            }
            indexes[0]=low+1;
            indexes[1]=high+1;
            return indexes;
        }
        public static int[] TwoSumBruteForce(int[] numbers, int target) 
        {
            int[] indexes = new int[2];
            for(int i=0;i<numbers.Length-1;i++)
            {
                for(int j=i+1;j<numbers.Length;j++)
                {
                    if(numbers[i]+numbers[j]==target)
                    {
                        indexes[0] = i+1;
                        indexes[1] = j+1;
                        break;
                    }
                }
            }
            return indexes;
        }
        public static void Main(String[] args)
        {
            int[] numbers = {1,2,7,11,15};
            int target = 9;
            int[] indexes = TwoSumBruteForce(numbers, target);
            for(int i=0;i<indexes.Length;i++)
            {
                Console.WriteLine(indexes[i] + " ");
            }
        }
    }
}