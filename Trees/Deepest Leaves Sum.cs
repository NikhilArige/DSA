/*
Given the root of a binary tree, return the sum of values of its deepest leaves.
Example 1:
Input: root = [1,2,3,4,5,null,6,7,null,null,null,null,8]
Output: 15
Example 2:
Input: root = [6,7,8,2,7,1,3,9,null,1,4,null,null,null,5]
Output: 19
Constraints:
The number of nodes in the tree is in the range [1, 104].
1 <= Node.val <= 100
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
    int sum = 0;
    public int DeepestLeavesSum(TreeNode root) {
        var depth = maxDepth(root);
        updateSum(root,depth,1);
        return sum;
    }
    
    void updateSum(TreeNode root,int depth,int curLevel){
        if(root==null){
            return;
        }
        if(depth==curLevel){
            sum+=root.val;
        }
        updateSum(root.left,depth,curLevel+1);
        updateSum(root.right,depth,curLevel+1);
    }
    
    
    int maxDepth(TreeNode root)
    {
        if(root==null){
            return 0;
        }
        return 1 + Math.Max(maxDepth(root.left),maxDepth(root.right));
    }
}
