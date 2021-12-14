/*
Given the root of a binary tree, return the sum of values of nodes with an even-valued grandparent. If there are no nodes with an even-valued grandparent, return 0.
A grandparent of a node is the parent of its parent if it exists.
Example 1:
Input: root = [6,7,8,2,7,1,3,9,null,1,4,null,null,null,5]
Output: 18
Explanation: The red nodes are the nodes with even-value grandparent while the blue nodes are the even-value grandparents.
Example 2:
Input: root = [1]
Output: 0
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
    public int SumEvenGrandparent(TreeNode root) {
        var res = 0;
        GetSum(ref res,root,null,null);
        return res;
    }
    void GetSum(ref int res,TreeNode root,TreeNode parent,TreeNode grandparent){
        if(root==null){
            return;
        }
        if(grandparent!=null && (grandparent.val % 2 == 0)){
            res+=root.val;
        }
        GetSum(ref res,root.left,root,parent);
        GetSum(ref res,root.right,root,parent);
    }
}
