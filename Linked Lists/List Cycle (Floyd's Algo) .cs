//Given a linked list, return the node where the cycle begins. If there is no cycle, return null.



/**
 * Definition for singly-linked list.
 * class ListNode {
 *     public int val;
 *     public ListNode next;
 *     ListNode(int x) { val = x; next = null; }
 * }
 */
public class Solution {
	public ListNode detectCycle(ListNode a) {
	    
	    ListNode slow = a;
	    ListNode fast = a;
	    
	    slow = slow.next;
	    fast=fast.next.next;
	    
	    while(fast != null && fast.next != null){
	        
	        if(slow==fast){
	            break;
	        }
	        slow = slow.next;
	        fast=fast.next.next; 
	    }
	    if(slow!=fast){return null;}
	    
	    slow = a;
	    
	    while(slow!=fast){ 
	        slow = slow.next;
	        fast=fast.next; 
	    }
	    return slow;  
	}
}


