/* Write a function to delete a node in a singly-linked list. You will not be given access to the head of the list, 
instead you will be given access to the node to be deleted directly.
It is guaranteed that the node to be deleted is not a tail node in the list.
Input: head = [4,5,1,9], node = 5
Output: [4,1,9]
Explanation: You are given the second node with value 5, the linked list should become 4 -> 1 -> 9 after calling your function.*/

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public void DeleteNode(ListNode node) {
        
        var temp = node.next;
        node.val = temp.val;
        node.next = temp.next;
        temp = null;
        
    }
}
