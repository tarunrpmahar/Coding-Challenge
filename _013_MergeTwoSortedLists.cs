using System;

namespace CodingChallenge
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x)
        {
            val = x;
            next = null;
        }
    }
    public class Solution 
    {
        public static void Main(String[] args)
        {
            ListNode list1 = new ListNode(10);
            list1.next.next=new ListNode(30);
            list1.next.next.next.next=new ListNode(50);
            list1.next.next.next.next.next=new ListNode(60);

            ListNode list2 = new ListNode(10);
            list2.next = new ListNode(20);
            list2.next.next.next=new ListNode(40);

            Printlist(MergeTwoLists(list1, list2));            
        }
        
        public static ListNode MergeTwoLists(ListNode list1, ListNode list2) 
        {
            ListNode merged = null;
            ListNode last = merged;
            
            while(list1!=null && list2!=null)
            {
                if(list1.val<=list2.val)
                {
                    ListNode newNode = new ListNode(list1.val);
                    //newNode.val = list1.val;
                    if(merged == null)
                    {
                        merged = newNode;
                    }
                    else
                    {
                        last.next = newNode;
                    }
                    
                    last=newNode;
                    list1 = list1.next;
                }
                else
                {
                    ListNode newNode = new ListNode(list2.val);
                    //newNode.val = list2.val;
                    if(merged == null)
                    {
                        merged = newNode;
                    }
                    else
                    {
                        last.next = newNode;
                    }
                    last=newNode;
                    list2 = list2.next;
                }
            }
            
            if(list1!=null)
            {
                if(merged==null)
                {
                    merged = list1;
                }
                else
                {
                    last.next = list1;
                }
            }
            if(list2!=null)
            {
                if(merged==null)
                {
                    merged = list2;
                }
                else
                {
                    last.next = list2;
                }
            }
            
            return merged;
        }
        static void Printlist(ListNode head)
        {
            ListNode curr=head;
            while(curr!=null)
            {
                Console.WriteLine(curr.val+" ");
                curr=curr.next;
            }
            Console.WriteLine();
        }
    }
}