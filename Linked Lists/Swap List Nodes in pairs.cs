//Given a linked list, swap every two adjacent nodes and return its head.
//For example,
//Given 1->2->3->4, you should return the list as 2->1->4->3.
//Your algorithm should use only constant space. You may not modify the values in the list, only nodes itself can be changed.


/**
 * Definition for singly-linked list.
 * class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {this.val = x; this.next = null;}
 * }
 */
 //when data can be changed
class Solution {
    public ListNode swapPairs(ListNode A) {
        
        ListNode temp = A; 
        while (temp != null && temp.next != null) {
   
            int k = temp.val;
            temp.val = temp.next.val;
            temp.next.val = k;
            temp = temp.next.next;
        } 
        return A; 
    }
}

//normal soln

class Solution {
    public ListNode swapPairs(ListNode A) {
 
        if (A == null || A.next == null) {
            return A;
        } 
        ListNode prev = A;
        ListNode curr = A.next;
  
        A = curr; 
        while (true) {
            ListNode next = curr.next;
  
            curr.next = prev;
  
            if (next == null || next.next == null) {
                prev.next = next;
                break;
            }
  
            prev.next = next.next;
  
            prev = next;
            curr = prev.next;
        }
        return A;
    }
}
