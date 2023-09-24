using System;
namespace CodingChallenge
{
    public class MinStack
    {
        Stack<int> stack = null;
        Stack<int> minStack = null;
        public MinStack()
        {
            stack = new Stack<int>();
            minStack = new Stack<int>();
        }

        public void Push(int val)
        {
            stack.Push(val);
            if (minStack.Count == 0)
            {
                minStack.Push(val);
            }
            else
            {
                if (val < minStack.Peek())
                {
                    minStack.Push(val);
                }
                else
                {
                    minStack.Push(minStack.Peek());
                }
            }
        }

        public void Pop()
        {
            stack.Pop();
            minStack.Pop();
        }

        public int Top()
        {
            return stack.Peek();
        }

        public int GetMin()
        {
            return minStack.Peek();
        }
    }

    /*
     * Your MinStack object will be instantiated and called as such:
     * MinStack obj = new MinStack();
     * obj.Push(val);
     * obj.Pop();
     * int param_3 = obj.Top();
     * int param_4 = obj.GetMin();
     */

    public class Solution
    {
        public static void Main(string[] args)
        {
            MinStack minStack = new MinStack();
            minStack.Push(-2);
            minStack.Push(0);
            minStack.Push(-3);
            minStack.GetMin();
            minStack.Pop();
            minStack.Top();
            minStack.GetMin();
        }
    }
}