/* Given the head of a linked list, remove the nth node from the end of the list and return its head.
Follow up: Could you do this in one pass?
Input: head = [1,2,3,4,5], n = 2
Output: [1,2,3,5] */


/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        
        var first = head;
        var second = head;
        for(int i=0;i<n;i++){
         
            if(second.next == null){
                if (i == n - 1){
                   head = head.next;  //when count = n
                }
                return head;
            }
            second = second.next;
        }
         while (second.next != null)
        {
            first = first.next;
            second = second.next;
        }
        first.next = first.next.next;
        return head;
    }
}
