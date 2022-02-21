/*
You are given the root of a binary tree where each node has a value in the range [0, 25] representing the letters 'a' to 'z'.
Return the lexicographically smallest string that starts at a leaf of this tree and ends at the root.
As a reminder, any shorter prefix of a string is lexicographically smaller.
For example, "ab" is lexicographically smaller than "aba".
A leaf of a node is a node that has no children.
Example 1:
Input: root = [0,1,2,3,4,3,4]
Output: "dba"
Example 2:
Input: root = [25,1,3,1,3,0,2]
Output: "adz"
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
    public string SmallestFromLeaf(TreeNode root) {
         
        string res = "";
        UpdateList(root,"",ref res);  
        return res;
    }
    
    void UpdateList(TreeNode root,string cur,ref string res){
        
        if(root == null){
            return;
        }
        cur = (char)(root.val + 'a') + cur;
        if(root.left == null && root.right == null){ 
            if(cur.CompareTo(res) < 0 || res == ""){
                res = cur;
            } 
            return;
        }
        UpdateList(root.left,cur,ref res); 
        UpdateList(root.right,cur,ref res);
         
    }
}
