/*
You are given an array of k linked-lists lists, each linked-list is sorted in ascending order.
Merge all the linked-lists into one sorted linked-list and return it.
Example 1:
Input: lists = [[1,4,5],[1,3,4],[2,6]]
Output: [1,1,2,3,4,4,5,6]
Explanation: The linked-lists are:
[
  1->4->5,
  1->3->4,
  2->6
]
merging them into one sorted list:
1->1->2->3->4->4->5->6
Example 2:
Input: lists = []
Output: []
Example 3:
Input: lists = [[]]
Output: []
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
    public ListNode MergeKLists(ListNode[] lists) {
        if (lists == null)
        return null;

        var ss = new SortedSet<(int Value, int Index, ListNode Node)>();
        for (int i = 0; i < lists.Length; i++)
            if (lists[i] != null)
                ss.Add((lists[i].val, i, lists[i]));

        ListNode head = new ListNode(), tail = head;
        while (ss.Count > 0) {
            var min = ss.Min;
            ss.Remove(min);

            tail.next = min.Node;
            tail = tail.next;

            var next = min.Node.next;
            if (next != null)
                ss.Add((next.val, min.Index, next));
        }
        return head.next;
    }
}
