/*
The thief has found himself a new place for his thievery again. There is only one entrance to this area, called root.
Besides the root, each house has one and only one parent house. After a tour, the smart thief realized that all houses in this place form a binary tree.
It will automatically contact the police if two directly-linked houses were broken into on the same night.
Given the root of the binary tree, return the maximum amount of money the thief can rob without alerting the police.
Example 1:
Input: root = [3,2,3,null,3,null,1]
Output: 7
Explanation: Maximum amount of money the thief can rob = 3 + 3 + 1 = 7.
Example 2:
Input: root = [3,4,5,1,3,null,1]
Output: 9
Explanation: Maximum amount of money the thief can rob = 4 + 5 = 9
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
    Dictionary<TreeNode,int> map = new Dictionary<TreeNode,int>();
    public int Rob(TreeNode root) {
        if(root==null){
            return 0;
        }
        if(map.ContainsKey(root)){
            return map[root];
        }
        int total = 0;
        if(root.left!=null){
            total += (Rob(root.left.left) + Rob(root.left.right));
        }
        if(root.right!=null){
          total += (Rob(root.right.left) + Rob(root.right.right));
        }
        
        return map[root] = Math.Max(root.val+total , Rob(root.left)+Rob(root.right));
    }
}
