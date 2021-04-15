//Given a linked list A of length N and an integer B.
//You need to reverse every alternate B nodes in the linked list A.
//A = 3 -> 4 -> 7 -> 5 -> 6 -> 6 -> 15 -> 61 -> 16
//Output:7 -> 4 -> 3 -> 5 -> 6 -> 6 -> 16 -> 61 -> 15



/**
 * Definition for singly-linked list.
 * class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {this.val = x; this.next = null;}
 * }
 */
class Solution {
    public ListNode solve(ListNode A, int B) {
        if(B==1){
            return A;
        } 
        ListNode next = new ListNode();
        ListNode cur= A;
        ListNode prev = null;
        int cnt = 0;
        while(cur!=null && cnt<B){  //will reverse k size nodes
            next=cur.next;
            cur.next=prev;
            prev = cur;
            cur=next;
            cnt++; 
        } 
        A.next = next; 
        int cnttwo = 1; 
        while(next!=null && cnttwo<B){  //will move till k  
            next=next.next;
            cnttwo++; 
        }  
        if(next!=null && next.next!=null){  
            next.next = solve(next.next,B);  //for next k size nodes
        } 
        return prev;  
    }
}
