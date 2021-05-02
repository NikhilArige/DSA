/*Given a singly linked list where elements are sorted in ascending order, convert it to a height balanced BST.
A height balanced BST : a height-balanced binary tree is defined as a binary tree in which the depth of the two subtrees of every node never differ by more than 1. 
Example :
Given A : 1 -> 2 -> 3
A height balanced BST  :
      2
    /   \
   1     3  */
   
/**
 * Definition for binary tree
 * class TreeNode {
 *     int val;
 *     TreeNode left;
 *     TreeNode right;
 *     TreeNode(int x) { val = x; }
 * }
 */
/**
 * Definition for singly-linked list.
 * class ListNode {
 *     public int val;
 *     public ListNode next;
 *     ListNode(int x) { val = x; next = null; }
 * }
 */
public class Solution {
	public TreeNode sortedListToBST(ListNode A) {
	    
	   if(A==null){
        return null;
        }
        ListNode prev = null;
        ListNode slow = A;
        ListNode fast = A;
        while(fast!=null && fast.next!=null){
            prev = slow;
            slow = slow.next;
            fast = fast.next.next;
        }
        if(prev==null){ //when only 1 is there
            TreeNode root = new TreeNode(slow.val);
            root.left = null;
            root.right = null;
            return root;
        }
        TreeNode root = new TreeNode(slow.val);
        
        if(prev!=null){
            prev.next = null;
            root.left = sortedListToBST(A);
        }
        root.right = sortedListToBST(slow.next);
        return root;
	}
}
