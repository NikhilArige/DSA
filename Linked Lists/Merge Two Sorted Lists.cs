//Merge two sorted linked lists and return it as a new list.
//The new list should be made by splicing together the nodes of the first two lists, and should also be sorted.


/**
 * Definition for singly-linked list.
 * class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {this.val = x; this.next = null;}
 * }
 */
class Solution {
    public ListNode mergeTwoLists(ListNode A, ListNode B) {
        
        ListNode p1 = A;
        ListNode p2 = B;
        ListNode head = null;
        ListNode cur = null;
        
        while(p1!=null && p2!=null){
            if(p1.val < p2.val){
                ListNode n = new ListNode(p1.val);
                if(head==null){  
                   head = n;
                   cur =n;
                }
                else{
                    cur.next = n;
                    cur = cur.next;
                }
                p1= p1.next;
            }
            else{
                ListNode m = new ListNode(p2.val);
                if(head==null){  
                   head = m;
                   cur =m;
                }
                else{
                    cur.next = m;
                    cur = cur.next;
                }
                p2= p2.next;  
            } 
        } 
        while(p1 != null){
            ListNode t = new ListNode(p1.val);
            cur.next = t;
            cur = cur.next;
            p1=p1.next;
        }
        
        while(p2 != null){
            ListNode t2 = new ListNode(p2.val);
            cur.next = t2;
            cur = cur.next;
            p2=p2.next;
        } 
        return head;
    }
}
