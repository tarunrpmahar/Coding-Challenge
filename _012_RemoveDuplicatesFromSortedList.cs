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
public class Solution {
    public ListNode DeleteDuplicates(ListNode head) {
        ListNode ptr = head;
        if(head == null)
        {
            return head;
        }
        while(ptr.next!=null)
        {
            if(ptr.next.next == null)
            {
                if(ptr.val == ptr.next.val)
                {
                    ptr.next = null;
                }
                break;
            }
            
            if(ptr.val != ptr.next.val)
            {
                ptr = ptr.next;
            }   
            else
            {
                 ptr.next = ptr.next.next;

            }
        }
        return head;
    }
}
