/*Reverse a linked list from position m to n. Do it in-place and in one-pass.
For example:
Given 1->2->3->4->5->NULL, m = 2 and n = 4,
return 1->4->3->2->5->NULL. */


/**
 * Definition for singly-linked list.
 * class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {this.val = x; this.next = null;}
 * }
 */
class Solution {
    public ListNode reverseBetween(ListNode A, int m, int n) {

       //A = 12345 m =2 n= 4
        ListNode newnode = new ListNode(0);
        newnode.next = A;
        A=newnode; 
        ListNode temp = A;
        while(temp!=null){
            if(m==1){
                //start = 2
                ListNode prev = null;
                ListNode cur = temp.next;
                ListNode next = new ListNode();
                ListNode start = temp.next;
                while(n>0){
                    next = cur.next;
                    cur.next = prev;
                    prev = cur;
                    cur = next;
                    n--;
                } 
                //next = 5
                start.next = next;
                //2=>5
                temp.next = prev;
                //1=>4
            }
            m--;
            n--;
            temp=temp.next;
        } 

        return A.next;
    }
}
