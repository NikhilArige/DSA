/*
Given the head of a linked list, return the list after sorting it in ascending order.
Example 1:
Input: head = [4,2,1,3]
Output: [1,2,3,4]
Example 2:
Input: head = [-1,5,3,4,0]
Output: [-1,0,3,4,5]
Example 3:
Input: head = []
Output: []
*/

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
    public ListNode SortList(ListNode head) {
        if(head==null || head.next==null){
            return head;   
        }
        var slow = head;
        var fast = head;
        var prev = new ListNode();
        while(fast != null && fast.next != null)
        {
            prev = slow;
            fast = fast.next.next;
            slow = slow.next;
        }
        prev.next = null;
        var left = SortList(head);
        var right = SortList(slow);
        return Merge(left,right);
    }
    
    ListNode Merge(ListNode a,ListNode b)
    {
       var dummy = new ListNode(-1);
       var cur = dummy; 
       while(a!=null && b!=null){
           if(a.val < b.val){
               cur.next = a;
               a = a.next;
               cur = cur.next;
           }
           else
           {
               cur.next = b;
               b = b.next;
               cur = cur.next;
           }
       } 
        if(a!=null)
        {
           cur.next = a; 
        }
        else
        {
            cur.next = b;
        }
        return dummy.next;
    }
}
