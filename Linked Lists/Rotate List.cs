//Given a list, rotate the list to the right by k places, where k is non-negative.
//Given 1->2->3->4->5->NULL and k = 2,
//return 4->5->1->2->3->NULL.


/**
 * Definition for singly-linked list.
 * class ListNode {
 *     public int val;
 *     public ListNode next;
 *     ListNode(int x) { val = x; next = null; }
 * }
 */
public class Solution {
    public ListNode rotateRight(ListNode A, int k) {
       
    ListNode head = A; 
    if (head == null)
        return head;
  
    ListNode tmp = head;
    int len = 1;
    while (tmp.next != null)
    {
        tmp = tmp.next;
        len++;
    }
 
    // If k is greater than the size
    // of the linked list
    if (k > len)
        k = k % len;
 
    k = len - k;
 
    // If no rotation needed   
    if (k == 0 || k == len)
        return head;
 
    ListNode current = head;
    int cnt = 1;
    while (cnt < k && current != null)
    {
        current = current.next;
        cnt++;
    }
 
    // If current is null then k is equal
    // to the count of nodes in the list
    // Dont change the list in this case
    if (current == null)
        return head;
 
    // current points to the kth node
    ListNode kthnode = current;
 
    // Change next of last node
    // to previous head
    tmp.next = head;
 
    // Change head to (k+1)th node
    head = kthnode.next;
 
    // Change next of kth node to null
    kthnode.next = null;
 
    // Return the updated head pointer
    return head;
    }
}


