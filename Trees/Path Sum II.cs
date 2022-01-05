/*
Given the root of a binary tree and an integer targetSum, return all root-to-leaf paths where the sum of the node values in the path equals targetSum. 
Each path should be returned as a list of the node values, not node references.
A root-to-leaf path is a path starting from the root and ending at any leaf node. A leaf is a node with no children.
Example 1:
Input: root = [5,4,8,11,null,13,4,7,2,null,null,5,1], targetSum = 22
Output: [[5,4,11,2],[5,8,4,5]]
Explanation: There are two paths whose sum equals targetSum:
5 + 4 + 11 + 2 = 22
5 + 8 + 4 + 5 = 22
Example 2:
Input: root = [1,2,3], targetSum = 5
Output: []
Example 3:
Input: root = [1,2], targetSum = 0
Output: []
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
    List<IList<int>> list;
    public IList<IList<int>> PathSum(TreeNode root, int targetSum) {
        list = new List<IList<int>>();
        UpdateList(root,targetSum,new List<int>(),0);
        return list;
    }
    
    void UpdateList(TreeNode root,int target,List<int> cur,int sum){
        
        if(root==null){
            return;
        }
        sum += root.val;
        cur.Add(root.val);
        if(root.left==null && root.right==null && sum==target){
            list.Add(new List<int>(cur)); 
        } 
        UpdateList(root.left,target,cur,sum);
        UpdateList(root.right,target,cur,sum); 
        cur.RemoveAt(cur.Count-1); 
    }
}
