/*
Given the root of a binary tree, return the leftmost value in the last row of the tree.
Example 1:
Input: root = [2,1,3]
Output: 1
Example 2:
Input: root = [1,2,3,4,null,5,6,null,null,7]
Output: 7
*/

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
    int max = 0;
    int maxlevel = int.MinValue;
    public int FindBottomLeftValue(TreeNode root) {
        if(root.left == null && root.right == null){
            return root.val;
        }
        GetMax(root,1);
        return max;
    }
    
    void GetMax(TreeNode root,int lev){
        if(root == null){
            return;
        } 
        
        if(maxlevel < lev){
            maxlevel = lev;
           max = root.val;
                
         } 
            GetMax(root.left,lev+1);
            GetMax(root.right,lev+1);
    }
}
