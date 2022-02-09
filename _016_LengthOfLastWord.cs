using System;

namespace CodingChallenge
{
    public class Solution 
    {
        public static int LengthOfLastWord(string s) 
        {
            string[] str = s.Split(' ');
            int result = 0; 
            for(int i = str.Length-1; i>=0;i--)
            {
                if(str[i].Length>0)
                {
                    result = str[i].Length;
                    break;
                }
            }
            return result;
        }
        public static void Main(String[] args)
        {
            string sentence = "   fly me   to   the moon  ";
            int result = LengthOfLastWord(sentence);
            Console.WriteLine(result);
        }
    }
}