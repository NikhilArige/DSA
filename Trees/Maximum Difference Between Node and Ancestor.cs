/*
Given the root of a binary tree, find the maximum value v for which there exist different nodes a and b where v = |a.val - b.val| and a is an ancestor of b.
A node a is an ancestor of b if either: any child of a is equal to b or any child of a is an ancestor of b.
Example 1:
Input: root = [8,3,10,1,6,null,14,null,null,4,7,13]
Output: 7
Explanation: We have various ancestor-node differences, some of which are given below :
|8 - 3| = 5
|3 - 7| = 4
|8 - 1| = 7
|10 - 13| = 3
Among all possible differences, the maximum value of 7 is obtained by |8 - 1| = 7.
Example 2:
Input: root = [1,null,2,null,0,3]
Output: 3
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
    int maxDiff;
    public int MaxAncestorDiff(TreeNode root) {
        maxDiff = 0;
        DFS(root,root.val,root.val);
        return maxDiff;
    }
    
    void DFS(TreeNode root,int min,int max)
    {
        if(root==null)
        {
            return;
        }
        maxDiff = Math.Max(maxDiff,Math.Abs(max-root.val));
        maxDiff = Math.Max(maxDiff,Math.Abs(min-root.val));
        
        max = Math.Max(max,root.val);
        min = Math.Min(min,root.val);
        DFS(root.left,min,max);
        DFS(root.right,min,max);
    }
}
