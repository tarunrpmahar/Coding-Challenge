using System;
namespace CodingChallenge
{
    class Stack{
        public int top {get;set;}
        public int[] stack;
        public int size { get; set; }

        public Stack(int size)
        {
            this.size = size;
            stack = new int[size];
            top = -1;
        }

        public void Push(int n)
        {
            if(top+1 >= size)
            {
                Console.WriteLine($"Stack Overflow as top is {top} and size is {size}");
            }
            else
            {
                top++;
                stack[top] = n;
            }
        }

        public int Pop()
        {
            int result = -1;
            if(top == -1)
            {
                Console.WriteLine("stack underflow");
            }
            else
            {
                result = stack[top];
                top--;                    
            }
            return result;
        }

        public void Display()
        {
            if(top == -1)
            {
                Console.WriteLine("stack is empty");
            }
            else
            {
                for(int i=0;i<=top;i++)
                {
                    Console.WriteLine(stack[i]);
                }
            }
            Console.WriteLine("Currently top is : "+top);
        }

        public int? Peek()
        {
            if(top >=0 && top < size)
            {
                return stack[top];
            }
            else
            {
                Console.WriteLine("Stack is Empty - Peek method");
                return -1;                
            }
        }

        bool IsEmpty()
        {
            if(top == -1)
            {
                return true;
            }
            return false;
        }
    }

    class StackImplementation
    {
        public static void Main(string[] args)
        {
            Stack stack = new Stack(5);
            stack.Push(1);
            stack.Push(2);
            stack.Push(4);
            stack.Push(5);
            stack.Push(7);
            stack.Push(9);
            stack.Display();
            Console.WriteLine($"{stack.Pop()} is poped from the stack");
            Console.WriteLine($"{stack.Peek()} is at the top");

            Console.WriteLine($"{stack.Pop()} is poped from the stack");
            Console.WriteLine($"{stack.Peek()} is at the top");

            Console.WriteLine($"{stack.Pop()} is poped from the stack");
            Console.WriteLine($"{stack.Peek()} is at the top");

            Console.WriteLine($"{stack.Pop()} is poped from the stack");
            Console.WriteLine($"{stack.Peek()} is at the top");

            Console.WriteLine($"{stack.Pop()} is poped from the stack");
            Console.WriteLine($"{stack.Peek()} is at the top");
        }


    }
}