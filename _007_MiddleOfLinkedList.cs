using System;

namespace CodingChallenge1
{
    class Node
    {
        public int data;
        public Node next;
        public Node(int x)
        {
            data = x;
            next = null;
        }
    }
    class MiddleOfLinkedList
    {
        public static void Main(String[] args)
        {
            Node head=new Node(10);
            head.next=new Node(20);
            head.next.next=new Node(30);
            head.next.next.next=new Node(40);
            head.next.next.next.next=new Node(50);
            head.next.next.next.next.next=new Node(60);
            Printlist(head);
            Console.WriteLine("Position of element in Linked List: ");
            PrintMiddle(head);
        }    
        static void Printlist(Node head)
        {
            Node curr=head;
            while(curr!=null)
            {
                Console.WriteLine(curr.data+" ");
                curr=curr.next;
            }
            Console.WriteLine();
        }
        static void PrintMiddle(Node head)
        {
            //Brute Force approach
            /*if(head==null)
                return;

            Node ptr = head;
            int count = 0;
            while(ptr!=null)
            {
                count++;
                ptr = ptr.next;
            }
            Console.WriteLine("count is : {0}", count);
            int mid = count/2;   
            for(int i=0;i<=mid;i++)
            {
                head=head.next;
            }
            Console.WriteLine(head);*/


            // two pointer approach
            Node slow=head,fast=head;

            while(fast!=null&&fast.next!=null)
            {
                slow=slow.next;
                fast=fast.next.next;
            }
            Console.WriteLine(slow.data);
        }
    }
}