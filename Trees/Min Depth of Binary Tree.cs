//Given a binary tree, find its minimum depth.
//The minimum depth is the number of nodes along the shortest path from the root node down to the nearest leaf node.
//NOTE : The path has to end on a leaf node. 


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
    public int minDepth(TreeNode A) {
        
        if(A==null){
            return 0;
        }
         if (A.left == null && A.right == null)
        {
            return 1;
        } 
        if (A.left == null)
        {
            return minDepth(A.right) + 1;
        } 
        if (A.right == null)
        {
            return minDepth(A.left) + 1;
        } 
        return 1+Math.Min(minDepth(A.left),minDepth(A.right));
        
    }
}

//Optimal Soln is to do level order traversal using queue and return height when a node with right and left are null


















