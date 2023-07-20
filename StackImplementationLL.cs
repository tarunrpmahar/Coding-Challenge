using System;

namespace CodingChallenge
{
    class Node
    {
        public int data;
        public Node next;

        public Node(int data)
        {
            this.data = data;
            next = null;
        }
    }

    class StackLL
    {
        Node top;
        public int size;

        public StackLL(int size)
        {
            top = null;
            this.size = size;
        }

        public void Push(int data)
        {
            Node newNode = new Node(data);
            if(top == null)
            {
                top = newNode;
            }
            else
            {
                newNode.next = top;
                top = newNode;           
            }

        }

        public int Pop()
        {
            if(top == null)
            {
                return -1;
            }
            else
            {
                int temp = top.data;
                top = top.next;
                return temp;
            }
        }

        public void Dispaly()
        {
            Node newNode = top;
            if (top == null)
            {
                Console.WriteLine("Stack is Empty");
            }
            else
            {
                while(newNode !=null) // || newNode.next != null
                {
                    Console.WriteLine($"{newNode.data}-->");
                    newNode = newNode.next;
                }
                //Console.WriteLine("\n");
            }
        }
    }

    public class StackImplementationLL
    {
        public static void Main(string[] args)
        {
            StackLL stackLL = new StackLL(5);
            stackLL.Push(1);
            stackLL.Push(2);
            stackLL.Push(3);
            stackLL.Push(4);
            stackLL.Push(5);
            stackLL.Dispaly();
            Console.WriteLine($"poped element:{stackLL.Pop()}");
            Console.WriteLine($"poped element:{stackLL.Pop()}");
        }
    }
}
