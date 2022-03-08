/*
You are given the root of a binary tree with n nodes. Each node is uniquely assigned a value from 1 to n. 
You are also given an integer startValue representing the value of the start node s, and a different integer destValue representing the value of the destination node t.
Find the shortest path starting from node s and ending at node t. 
Generate step-by-step directions of such path as a string consisting of only the uppercase letters 'L', 'R', and 'U'. Each letter indicates a specific direction:
'L' means to go from a node to its left child node.
'R' means to go from a node to its right child node.
'U' means to go from a node to its parent node.
Return the step-by-step directions of the shortest path from node s to node t.
Example 1:
Input: root = [5,1,2,3,null,6,4], startValue = 3, destValue = 6
Output: "UURL"
Explanation: The shortest path is: 3 → 1 → 5 → 2 → 6.
Example 2:
Input: root = [2,1], startValue = 2, destValue = 1
Output: "L"
Explanation: The shortest path is: 2 → 1.
Constraints:
The number of nodes in the tree is n.
2 <= n <= 105
1 <= Node.val <= n
All the values in the tree are unique.
1 <= startValue, destValue <= n
startValue != destValue
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
    public string GetDirections(TreeNode root, int startValue, int destValue) {
        
        var start = "";
        var end = "";
        var lca = LCA(root,startValue,destValue);
        UpdatePaths(lca,ref start,ref end,startValue,destValue,new StringBuilder());
        var res = new StringBuilder();
        for(int i=0;i<start.Length;i++){
            res.Append("U");
        }
        res.Append(end);
        return res.ToString();
    }
    
    void UpdatePaths(TreeNode root,ref string start,ref string end, int startValue, int destValue,StringBuilder sb){
        
        if(root == null){
            return;
        }
        if(root.val == startValue){
            start = sb.ToString();
        }
        if(root.val == destValue){
            end = sb.ToString();
        }
        
        UpdatePaths(root.left,ref start,ref end,startValue,destValue,sb.Append("L"));
        sb.Remove(sb.Length-1,1);
        UpdatePaths(root.right,ref start,ref end,startValue,destValue,sb.Append("R"));
        sb.Remove(sb.Length-1,1); 
    }
    
    TreeNode LCA(TreeNode root,int l,int r){
        
        if(root == null || root.val == l || root.val == r){
            return root;
        }
        var left = LCA(root.left,l,r);
        var right = LCA(root.right,l,r);
        if(left !=null && right != null){
            return root;
        }
        return left != null ? left : right;
    }
}
