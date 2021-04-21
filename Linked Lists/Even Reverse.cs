/*Given a linked list A , reverse the order of all nodes at even positions.
Input 1:
A = 1 -> 2 -> 3 -> 4
Input 2:
A = 1 -> 2 -> 3
Example Output
Output 1: 1 -> 4 -> 3 -> 2
Output 2: 1 -> 2 -> 3
Example Explanation
Explanation 1:
Nodes are positions 2 and 4 have been swapped.
Explanation 2:
No swapping neccassary here. */



/**
 * Definition for singly-linked list.
 * class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {this.val = x; this.next = null;}
 * }
 */
class Solution {
    public ListNode solve(ListNode A) {
        //1 2 3 4 5 6
        ListNode cur = A;
        ListNode oddhead  = A;
        ListNode temp = A;
        ListNode even = null;
        ListNode evenhead = new ListNode(); 
        while(temp !=null && temp.next!=null){ 
            evenhead = temp.next; 
            oddhead.next = evenhead.next;
            oddhead = oddhead.next;  
            evenhead.next = even;
            even = evenhead;
            temp=temp.next;  
        } 
        //here cur => 1 3 5
        //evenhead => 6 4 2 null
        ListNode result = cur;  
        //evenhead!=null
        while(evenhead !=null ){
            ListNode oddtemp = cur.next; 
            ListNode eventemp = evenhead.next; 
            cur.next = evenhead;
            evenhead.next = oddtemp;
            evenhead = eventemp; 
            cur = oddtemp;  
        }
         
         return result;
        
    }
}

