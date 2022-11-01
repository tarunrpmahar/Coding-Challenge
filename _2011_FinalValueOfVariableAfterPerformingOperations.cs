public class Solution {
    public int FinalValueAfterOperations(string[] operations) {
        int positive = 0;
        int negative = 0;
        for(int i=0;i<operations.Length;i++)
        {
            if(operations[i]=="++X" || operations[i]=="X++")
            {
                positive++;
            }
            else
            {
                negative++;
            }
        }
        
        return positive-negative;
    }

    public int FinalValueAfterOperations1(string[] operations) {
        int val = 0;
        foreach(string s in operations)
        {
            if(s.Contains("++"))
            {
                val++;
            }
            else
            {
                val--;
            }
        }
        
        return val;
    }
}