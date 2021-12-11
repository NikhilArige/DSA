/*
Given the root of a binary tree, return the length of the longest path, where each node in the path has the same value. This path may or may not pass through the root.
The length of the path between two nodes is represented by the number of edges between them.
Example 1:
Input: root = [5,4,5,1,1,5]
Output: 2
Example 2:
Input: root = [1,4,5,4,4,5]
Output: 2
Constraints:
The number of nodes in the tree is in the range [0, 104].
-1000 <= Node.val <= 1000
The depth of the tree will not exceed 1000.
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
    int res = 0;
    public int LongestUnivaluePath(TreeNode root) {
        
        if(root == null)
        {
            return 0;
        }
        updateres(root,root.val);
        return res;
    }
    
    int updateres(TreeNode root,int val){
        
        if(root==null){
            return 0;
        }
        int left = updateres(root.left,root.val);
        int right = updateres(root.right,root.val);
        
        
        res = Math.Max(res, left + right);
    	return root.val == val ? Math.Max(left, right) + 1 : 0;        
    }
}
