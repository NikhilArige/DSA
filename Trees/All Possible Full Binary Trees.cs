/*
Given an integer n, return a list of all possible full binary trees with n nodes. Each node of each tree in the answer must have Node.val == 0.
Each element of the answer is the root node of one possible tree. You may return the final list of trees in any order.
A full binary tree is a binary tree where each node has exactly 0 or 2 children.
Example 1:
Input: n = 7
Output: [[0,0,0,null,null,0,0,null,null,0,0],[0,0,0,null,null,0,0,0,0],[0,0,0,0,0,0,0],[0,0,0,0,0,null,null,null,null,0,0],[0,0,0,0,0,null,null,0,0]]
Example 2:
Input: n = 3
Output: [[0,0,0]]
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
    Dictionary<int,List<TreeNode>> cache;
    public IList<TreeNode> AllPossibleFBT(int n) {
       if(n%2==0){
          return new List<TreeNode>(); 
       }
        
       cache = new Dictionary<int,List<TreeNode>>();
       cache.Add(1, new List<TreeNode>{new TreeNode(0)});
       return GetAllTrees(n);
    }
    List<TreeNode> GetAllTrees(int n){
        
        if(cache.ContainsKey(n)){
           return cache[n];
        }
        var list = new List<TreeNode>();
        for(int i=1;i<n;i+=2)
        {
            IList<TreeNode> left = GetAllTrees(i);
            IList<TreeNode> right = GetAllTrees(n-i-1);
            
            foreach(var lt in left)
            {
                foreach(var rt in right)
                {
                    TreeNode root = new TreeNode(0);
                    root.left = lt;
                    root.right = rt;
                    list.Add(root);
                }
            }
        }
        cache.Add(n,list);
        return cache[n];
    }
}
