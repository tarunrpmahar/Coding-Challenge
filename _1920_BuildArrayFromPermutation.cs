public class Solution {
    public int[] BuildArray(int[] nums) {
        int n  = nums.Length;
        for(int i=0;i<nums.Length;i++)
        {
            nums[i] = nums[i] + n*(nums[nums[i]]%n);
        }
        for(int i=0;i<nums.Length;i++)
        {
            nums[i] = nums[i]/n;
        }
        return nums;
    }
}
