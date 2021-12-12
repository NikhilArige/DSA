/*
Given a binary tree root and an integer target, delete all the leaf nodes with value target.
Note that once you delete a leaf node with value target, if it's parent node becomes a leaf node and has the value target,
it should also be deleted (you need to continue doing that until you can't).
Example 1:
Input: root = [1,2,3,2,null,2,4], target = 2
Output: [1,null,3,null,4]
Explanation: Leaf nodes in green with value (target = 2) are removed (Picture in left). 
After removing, new nodes become leaf nodes with value (target = 2) (Picture in center).
Example 2:
Input: root = [1,3,3,3,2], target = 3
Output: [1,3,null,null,2]
Example 3:
Input: root = [1,2,null,2,null,2], target = 2
Output: [1]
Explanation: Leaf nodes in green with value (target = 2) are removed at each step.
Example 4:
Input: root = [1,1,1], target = 1
Output: []
Example 5:
Input: root = [1,2,3], target = 1
Output: [1,2,3]
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
    public TreeNode RemoveLeafNodes(TreeNode root, int target) {
        if(root.val==target && root.left==null && root.right==null){
            return null;
        }
        updateTree(root,target);
        if(root.val==target && root.left==null && root.right==null){
            return null;
        }
        return root;
    }
    
    bool updateTree(TreeNode root,int target)
    {
        if(root==null){
            return false;
        }
        if(root.left == null && root.right == null && root.val == target){
            return true;
        }
        var left = updateTree(root.left,target);
        if(left){
            root.left = null;
        }
        var right = updateTree(root.right,target);
        if(right){
            root.right = null;
        }
        if(root.left == null && root.right == null && root.val == target){
            return true;
        }
        return false;
    }
    
}
