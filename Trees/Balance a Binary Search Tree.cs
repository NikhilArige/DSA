/*
Given the root of a binary search tree, return a balanced binary search tree with the same node values. If there is more than one answer, return any of them.
A binary search tree is balanced if the depth of the two subtrees of every node never differs by more than 1.
Example 1:
Input: root = [1,null,2,null,3,null,4,null,null]
Output: [2,1,3,null,null,null,4]
Explanation: This is not the only correct answer, [3,1,4,null,2] is also correct.
Example 2:
Input: root = [2,1,3]
Output: [2,1,3]
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
    List<int> sorted;
    public TreeNode BalanceBST(TreeNode root) {
        sorted = new List<int>();
        InOrder(root);
        return ConstructTree(0,sorted.Count-1);
    }
    
    TreeNode ConstructTree(int left,int right)
    {
        if(left>right){
            return null;
        }
        if(left==right)
        {
            return new TreeNode(sorted[left]);
        }
        var mid = (left + right)/2;
        var root = new TreeNode(sorted[mid]);
        root.left = ConstructTree(left,mid-1);
        root.right = ConstructTree(mid+1,right);
        return root;
    }
    
    
    void InOrder(TreeNode root){
        if(root == null)
        {
            return;
        }
        InOrder(root.left);
        sorted.Add(root.val);
        InOrder(root.right);
    }
}
