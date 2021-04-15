//Given a singly linked list and an integer K, reverses the nodes of the
//list K at a time and returns modified linked list.
//NOTE : The length of the list is divisible by K 
//Given linked list 1 -> 2 -> 3 -> 4 -> 5 -> 6 and K=2,
//You should return 2 -> 1 -> 4 -> 3 -> 6 -> 5
//Try to solve the problem using constant extra space.


/**
 * Definition for singly-linked list.
 * class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {this.val = x; this.next = null;}
 * }
 */
class Solution {
    public ListNode reverseList(ListNode A, int B) {
        
        if(B==1){
            return A;
        }
        //let A= 123456 B=3
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
        if(next!=null){
            //here A(1).next would be null, prev would be 3,next prev would be 6,so attaching that to head i.e., A(1) to 6
            A.next = reverseList(next,B);  //for next k size nodes
        } 
        return prev;
        //atlast 3 would be returned
    }
}
