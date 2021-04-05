//Given a sorted linked list, delete all nodes that have duplicate numbers, leaving only distinct numbers from the original list.
//For example,
//Given 1->2->3->3->4->4->5, return 1->2->5.
//Given 1->1->1->2->3, return 2->3.


/**
 * Definition for singly-linked list.
 * class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {this.val = x; this.next = null;}
 * }
 */
class Solution {
    public ListNode deleteDuplicates(ListNode A) {
        
        ListNode temp = new ListNode(0);
        temp.next = A;
        ListNode cur = A;
        ListNode prev = temp;
        
        while(cur != null){
           while(cur.next != null  && prev.next.val == cur.next.val){
               cur = cur.next;
           }  
            if(prev.next==cur){
                prev = prev.next;
            }
           else{ 
               prev.next = cur.next;
           } 
            cur=cur.next;
        } 
         return temp.next;
    }
}
