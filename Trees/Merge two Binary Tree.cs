//Given two Binary Trees A and B, you need to merge them in a single binary tree.
//The merge rule is that if two nodes overlap, then sum of node values is the new value of the merged node.
//Otherwise, the non-null node will be used as the node of new tree.


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
    public TreeNode solve(TreeNode A, TreeNode B) { 
        if(A==null){
            return B;
        }
        if(B==null){
            return A;
        } 
        A.val += B.val; 
        A.left = solve(A.left,B.left);
        A.right = solve(A.right,B.right);
        return A;
    }
}
