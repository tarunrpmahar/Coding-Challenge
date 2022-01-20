using System;

namespace CodingChallenge
{
    public class Solution 
    {
        public static int MostWordsFound(string[] sentences) 
        {
            int max = 0;
            for(int i=0;i<sentences.Length;i++)
            {
                int length = sentences[i].Split(' ').Length;
                if(length>max)
                {
                    max = length;
                }
                //max = Math.Max(max, length);
            }
            return max;
        }

        public static void Main(string[] args)
        {
            string[] sentences = {"alice and bob love leetcode", "i think so too", "this is great thanks very much"};
            var max = MostWordsFound(sentences);
            Console.WriteLine(max);
        }
    }
}