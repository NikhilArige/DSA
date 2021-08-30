/* Given the root of a binary tree, determine if it is a valid binary search tree (BST).
A valid BST is defined as follows:
The left subtree of a node contains only nodes with keys less than the node's key.
The right subtree of a node contains only nodes with keys greater than the node's key.
Both the left and right subtrees must also be binary search trees. */

/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public bool IsValidBST(TreeNode root) {
        
            return IsValid(root,long.MinValue, long.MaxValue);
        }
        
     public bool IsValid(TreeNode root, long min, long max){
      
         if(root == null){
             return true;
         } 
         else if(root.val > min && root.val < max){
             return IsValid(root.left, min, root.val) && IsValid(root.right, root.val, max);
         } 
             return false;
        } 
        
    }




