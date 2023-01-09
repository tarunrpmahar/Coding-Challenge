using System;
namespace DetectCapital
{
    class Solution
    {
        public static void Main(String[] args)
        {
            string word = Console.ReadLine();
            Console.WriteLine(DetectCapitalUse(word));
        }
        public static bool DetectCapitalUse(string word)
        {
            if(Char.IsLower(word[0]))
            {
                for(int i=1; i<word.Length; i++)
                {
                    if(Char.IsUpper(word[i]))
                    {
                        return false;
                    }
                }
                return true;
            }
            else
            {
                int lowerCount = 1, upperCount = 1;
                for(int i=1; i<word.Length; i++)
                {
                    if(Char.IsLower(word[i]))
                    {
                        lowerCount++;
                    }
                    else
                    {
                        upperCount++;
                    }
                }
                if(lowerCount == word.Length)
                {
                    return true;
                }
                else if(upperCount == word.Length)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
