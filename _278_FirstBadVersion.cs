
/* The isBadVersion API is defined in the parent class VersionControl.
      bool IsBadVersion(int version); */

public class Solution : VersionControl {
    public int FirstBadVersion(int n) {
        int low = 0;
        int high = n;
        while(low < high)
        {
            int mid = ((high - low) / 2) + low;
            Console.WriteLine($"{low} : {high} m={mid}");
            if(IsBadVersion(mid))
            {
                high = mid;
            }
            else
            {
                low = mid + 1;
            }
        }
        return low;        
    }
}