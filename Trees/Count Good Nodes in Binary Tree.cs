/*
Given a binary tree root, a node X in the tree is named good if in the path from root to X there are no nodes with a value greater than X.
Return the number of good nodes in the binary tree.
Example 1:
Input: root = [3,1,4,3,null,1,5]
Output: 4
Explanation: Nodes in blue are good.
Root Node (3) is always a good node.
Node 4 -> (3,4) is the maximum value in the path starting from the root.
Node 5 -> (3,4,5) is the maximum value in the path
Node 3 -> (3,1,3) is the maximum value in the path.
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
    public int GoodNodes(TreeNode root) {
        return GetGoodNodes(root,int.MinValue);
    }
    
    int GetGoodNodes(TreeNode root,int max){
        
        if(root==null){
            return 0;   
        }
        
        var cur = root.val >= max ? 1 : 0;
        
       return  cur + GetGoodNodes(root.left,Math.Max(root.val,max)) + GetGoodNodes(root.right,Math.Max(root.val,max));
        
    }
}
