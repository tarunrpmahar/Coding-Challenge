using System;
using System.Collections.Generic;

public class Solution {
    public static string RemoveDuplicateLetters(string s) {
        int[] freq = new int[256];
        bool[] taken = new bool[256];

        for(int i=0;i<s.Length;i++)
        {
            freq[s[i]]++;
        }

        Stack<char> st = new Stack<char>();
        st.Push(s[0]);
        freq[s[0]]--;
        taken[s[0]] = true;

        for(int i=1;i<s.Length;i++)
        {
            if(taken[s[i]] == true)
            {
                freq[s[i]]--;
            }
            else
            {
                while(st.Count > 0 && st.Peek() > s[i] && freq[st.Peek()] > 0)
                {
                    //freq[s[i]]--;
                    taken[st.Peek()] = false;
                    st.Pop();
                }
                st.Push(s[i]);
                freq[s[i]]--;
                taken[s[i]] = true;
            }
        }

        Stack<char> newStack = new Stack<char>();
        while(st.Count>0)
        {
            newStack.Push(st.Peek());
            st.Pop();
        }
        string res = "";
        while(newStack.Count>0)
        {
            res+=newStack.Peek();
            newStack.Pop();
        }
        Console.WriteLine(res);
        return res;
    }

    public static void Main(string[] args)
    {
        RemoveDuplicateLetters("bcabc");
    }
}