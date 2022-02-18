using System;
namespace CodingChallenge
{
        /**
    * Definition for singly-linked list.
    * public class ListNode {
    *     public int val;
    *     public ListNode next;
    *     public ListNode(int val=0, ListNode next=null) {
    *         this.val = val;
    *         this.next = next;
    *     }
    * }
    */
    public class ListNode 
    {
        public int val;
        public ListNode next;
        public ListNode(int val=0, ListNode next=null) {
            this.val = val;
            this.next = next;
        }
    }
    public class Solution 
    {
        public static void Main(String[] args)
        {
            ListNode head=new ListNode(1);
            head.next=new ListNode(2);
            head.next.next=new ListNode(6);
            head.next.next.next=new ListNode(3);
            head.next.next.next.next=new ListNode(4);
            head.next.next.next.next.next=new ListNode(5);
            head.next.next.next.next.next.next=new ListNode(6);
            Console.WriteLine("Initial element in Linked List: ");
            Printlist(head);
            Console.WriteLine("After removing element in Linked List: ");
            RemoveElements(head, 6);
            Printlist(head);
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
        public static ListNode RemoveElements(ListNode head, int val) 
        {            
            if(head == null)
            {
                return head;
            }
            
            while(head!=null && head.val == val)
            {
                head = head.next;
            }
            
            ListNode current = head; 
            
            while(current!=null)
            {
                if(current.next!=null && current.next.val == val)
                {
                    current.next = current.next.next;
                }            
                else
                {
                    current = current.next;
                }
                
            }
            return head;
        }
    }
}