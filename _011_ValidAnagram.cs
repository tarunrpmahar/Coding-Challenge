using System;

namespace CodingChallenge
{
    public class Solution 
    {
        public static bool IsAnagram(string s, string t) 
        {
            if(s.Length!=t.Length)
            {
                return false;
            }
            int[] s1 = new int[300];
            int[] t1 = new int[300];
            
            for(int i=0;i<s.Length;i++)
            {
                s1[s[i]]++;
                t1[t[i]]++;
            }
            for(int i=0;i<s1.Length;i++)
            {
                if(s1[i]!=t1[i])
                {
                    return false;
                }
            }
            return true;
        }
        public static void Main(String[] args)
        {
            string s = "anagram";
            string t = "nagraam";
            var result = IsAnagram(s, t);
            if(result)
            {
                Console.WriteLine("is anagram");
            }
            else
            {
                Console.WriteLine("is not anagram");
            }
        }
    }
}