/*
Given the head of a linked list, we repeatedly delete consecutive sequences of nodes that sum to 0 until there are no such sequences.
After doing so, return the head of the final linked list.  You may return any such answer.
(Note that in the examples below, all sequences are serializations of ListNode objects.)
Example 1:
Input: head = [1,2,-3,3,1]
Output: [3,1]
Note: The answer [1,2,1] would also be accepted.
Example 2:
Input: head = [1,2,3,-3,4]
Output: [1,2,4]
*/

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
    public ListNode RemoveZeroSumSublists(ListNode head) {
        
        var res = new ListNode(0);
        res.next = head;
        var cur = res;
        int sum = 0;
        var map = new Dictionary<int,ListNode>();
        while(cur!=null){
            sum+= cur.val;
            map[sum] = cur;
            cur=cur.next; 
        }
        sum = 0;
        cur = res;
        while(cur!=null){
            sum+= cur.val;
            cur.next = map[sum].next;
            cur=cur.next; 
        }
        return res.next;
    }
}
