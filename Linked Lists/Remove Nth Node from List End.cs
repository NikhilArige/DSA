//Given a linked list, remove the nth node from the end of list and return its head.
//For example,
//Given linked list: 1->2->3->4->5, and n = 2.
//After removing the second node from the end, the linked list becomes 1->2->3->5.
//Note:
//If n is greater than the size of the list, remove the first node of the list.
//Try doing it using constant additional space.



/**
 * Definition for singly-linked list.
 * class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {this.val = x; this.next = null;}
 * }
 */
class Solution {
    public ListNode removeNthFromEnd(ListNode A, int B) {
        
        if(A == null){
            return null;
            }
        if(A.next == null){
            A = null;
            return A;
            }
        ListNode temp = A;
        int len = 0;
        while(temp !=null){
        len++;
        temp = temp.next;
        }
        if(B>=len){
        A = A.next;
        return A;
        }
        temp = A;
        int i=1;
        int cut = len-B;
        while(i<cut){
        i++;
        temp = temp.next;
        }
        temp.next = temp.next.next;
        return A;
        }
        
    }
