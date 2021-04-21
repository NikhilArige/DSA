/* Reverse a linked list*/

/**
 * Definition for singly-linked list.
 * class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {this.val = x; this.next = null;}
 * }
 */
class Solution {
    public ListNode reverseList(ListNode A) {
        
        ListNode cur=A;
        ListNode prev = null;
        ListNode next = new ListNode();
         
        while(cur != null){ 
          next= cur.next;
          cur.next = prev;
          prev = cur;
          cur = next;   
        }   
         return prev;  
    }
}

//recursive

class Solution {
    ListNode head = new ListNode();
    public ListNode reverseList(ListNode A) { 
         reverse(A);
         return head;
    } 
    private void reverse(ListNode cur){ 
        if(cur.next == null){
            head = cur;
            return;
        }
        reverse(cur.next);
        ListNode c = cur.next;
        c.next = cur;
        cur.next = null;
    }
}

