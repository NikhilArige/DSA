/* Given the head of a singly linked list, return true if it is a palindrome.
Input: head = [1,2,2,1]
Output: true */

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
    public bool IsPalindrome(ListNode head) {
        
        if(head.next == null){
            return true;
        }
        var slow = head;
        var fast = head;
        var beforeslow = head;
        ListNode middle = null;
        while(fast!=null && fast.next!=null){
             fast = fast.next.next;
             beforeslow = slow;
             slow = slow.next;
        }
        //fast would become NULL when even and not NULL when off.stoting middle when odd
        if (fast != null) {
                middle = slow;
                slow = slow.next;
            }
        beforeslow.next = null;
        slow = Reverse(slow);
        var firsthalf = head;
        var secondhalf = slow;
        while(firsthalf !=null){
            if(firsthalf.val != secondhalf.val){
                return false;
            }
            firsthalf = firsthalf.next;
            secondhalf = secondhalf.next;
        }
        return true;
    }
    
    private ListNode Reverse(ListNode head){
        
        ListNode prev = null;
        ListNode cur = head;
        ListNode next = new ListNode();
        
        while(cur!=null){
            next = cur.next;
            cur.next = prev;
            prev = cur;
            cur = next; 
        }
        return prev;
        
    }
}
