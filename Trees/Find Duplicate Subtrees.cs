/*
Given the root of a binary tree, return all duplicate subtrees.
For each kind of duplicate subtrees, you only need to return the root node of any one of them.
Two trees are duplicate if they have the same structure with the same node values.
Example 1:
Input: root = [1,2,3,4,null,2,4,null,null,4]
Output: [[2,4],[4]]
Example 2:
Input: root = [2,1,1]
Output: [[1]]
Example 3:
Input: root = [2,2,2,3,null,3,null]
Output: [[2,3],[3]]
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
    public IList<TreeNode> FindDuplicateSubtrees(TreeNode root) {
        
        var set = new HashSet<string>();
        var map = new Dictionary<string,TreeNode>();
        Duplicates(root,set,map);
        map.Remove("()");
        return map.Values.ToList();
    }
    
    string Duplicates(TreeNode root,HashSet<string> set,Dictionary<string,TreeNode> map){
        
        if(root==null){
            return "()";
        }
        
        var left = Duplicates(root.left,set,map);
        var right = Duplicates(root.right,set,map);
        if(!set.Contains(left)){
            set.Add(left);
        }
        else{
            if (!map.ContainsKey(left)){
                 map.Add(left, root.left);
            }
        }
        
        if(!set.Contains(right)){
            set.Add(right);
        }
        else{
            if (!map.ContainsKey(right)){
                 map.Add(right, root.right);
            }
        }
          return  root.val + "("+left+right+")";
    }
}
