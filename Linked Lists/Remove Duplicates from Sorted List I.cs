//Given a sorted linked list, delete all duplicates such that each element appear only once.
//For example,
//Given 1->1->2, return 1->2.
//Given 1->1->2->3->3, return 1->2->3.

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
        
        ListNode cur = A;
        ListNode n = new ListNode(); 
        if(cur.next == null){return A;} 
        while(cur.next !=null){
            if(cur.val == cur.next.val){
                n = cur.next.next;
                cur.next=null;
                cur.next= n;
            }
            else{
            cur = cur.next;}
        } 
        return A; 
    }
}
