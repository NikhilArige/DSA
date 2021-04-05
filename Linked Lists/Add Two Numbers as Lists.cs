//You are given two linked lists representing two non-negative numbers. The digits are stored in reverse order and each of their nodes contain a single digit. Add the two numbers and return it as a linked list.
//Input: (2 -> 4 -> 3) + (5 -> 6 -> 4)
//Output: 7 -> 0 -> 8


/**
 * Definition for singly-linked list.
 * class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {this.val = x; this.next = null;}
 * }
 */
class Solution {
    public ListNode addTwoNumbers(ListNode first, ListNode second) {
        ListNode res = null;
        ListNode prev = null;
        ListNode temp = null;
        int carry = 0, sum; 
        while (first != null || second != null) { 
            sum = carry + (first != null ? first.val : 0)
                  + (second != null ? second.val : 0); 
            carry = (sum >= 10) ? 1 : 0; 
            sum = sum % 10; 
            temp = new ListNode(sum); 
            if (res == null) {
                res = temp;
            } 
            else {
                prev.next = temp;
            }
            prev = temp; 
            if (first != null) {
                first = first.next;
            }
            if (second != null) {
                second = second.next;
            }
        } 
        if (carry > 0) {
            temp.next = new ListNode(carry);
        }
        return res;
    } 
}
