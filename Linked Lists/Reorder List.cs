//Given a singly linked list
//L: L0 → L1 → … → Ln-1 → Ln,
//reorder it to:
//L0 → Ln → L1 → Ln-1 → L2 → Ln-2 → …
//You must do this in-place without altering the nodes’ values.
//For example, Given {1,2,3,4}, reorder it to {1,4,2,3}.

/**
 * Definition for singly-linked list.
 * class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {this.val = x; this.next = null;}
 * }
 */
class Solution {
    public ListNode reorderList(ListNode A) {
        
        if(A==null || A.next == null){
            return A;
        }
         
        ListNode slow = A;
        ListNode fast = A.next.next;
        
        while (fast != null && fast.next != null) {
            slow = slow.next;
            fast = fast.next.next;
        }
        
        ListNode first = A;
        //next of middle node
        ListNode second = slow.next;
        slow.next = null;
        
        second=reverse(second);  
        
        ListNode node = new ListNode(0); // Assign dummy Node
  
        ListNode curr = node;
        while (first != null || second != null) { 
            // Adding element from first list
            if (first != null) {
                curr.next = first;
                curr = curr.next;
                first = first.next;
            } 
            // Adding element from second list
            if (second != null) {
                curr.next = second;
                curr = curr.next;
                second = second.next;
            }
        } 
        return node.next;  
    }
    
    public ListNode reverse(ListNode node){
        
        ListNode prev = null;
        ListNode curr = node;
        ListNode next;
        while (curr != null) {
            next = curr.next;
            curr.next = prev;
            prev = curr;
            curr = next;
        } 
        return prev; 
    }    
} 
