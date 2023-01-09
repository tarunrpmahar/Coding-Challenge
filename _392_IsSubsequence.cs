using System;

namespace IsSubsequence
{
	public class Solution {
		public static bool IsSubsequence(string s, string t) {
        int subSeq=0;
        if(s.Length==0)
        {
            return true;
        }
        for(int i=0;i<t.Length;i++)
        {
            if(s[subSeq]==t[i])
            {
                subSeq++;
            }
            if(subSeq>=s.Length)
            {
                break;
            }
        }
        if(subSeq==s.Length)
            return true;
        else
            return false;
		}
		public static void Main(string[] args)
		{
			if(IsSubsequence("abc", "ahbicjdk"))
			{
				Console.WriteLine("is subsequence");
			}
			else
			{
				Console.WriteLine("not subsequence");
			}		
		}
	}
}