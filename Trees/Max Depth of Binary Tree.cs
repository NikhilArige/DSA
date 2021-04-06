//Given a binary tree, find its maximum depth.
//The maximum depth of a binary tree is the number of nodes along the longest path from the root node down to the farthest leaf node.


/**
 * Definition for binary tree
 * class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) {this.val = x; this.left = this.right = null;}
 * }
 */
class Solution {
    public int maxDepth(TreeNode A) { 
        if(A==null){return 0;}
        int maxleft = 1;
        int maxright = 1; 
        if(A.left != null)
        { maxleft = 1+ maxDepth(A.left);}
          if(A.right != null)
        { maxright = 1+ maxDepth(A.right);}
        return Math.Max(maxleft,maxright);
    }
}
