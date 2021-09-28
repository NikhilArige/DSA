/*
Given the roots of two binary trees root and subRoot, return true if there is a subtree of root with the same structure and node values of subRoot and false otherwise.
A subtree of a binary tree tree is a tree that consists of a node in tree and all of this node's descendants. The tree tree could also be considered as a subtree of itself.
Example 1:
Input: root = [3,4,5,1,2], subRoot = [4,1,2]
Output: true
Example 2:
Input: root = [3,4,5,1,2,null,null,null,null,0], subRoot = [4,1,2]
Output: false
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
    List<TreeNode> node = new List<TreeNode>();
    public bool IsSubtree(TreeNode root, TreeNode subRoot) {
        
        getNode(root,subRoot.val);
        if(node.Count == 0)return false;
        foreach(var item in node){
            if(isSame(item,subRoot)) return true;
        }
        return false;
    }
    
    void getNode(TreeNode a,int val){
         
        if(a==null)return;
        if(a.val==val){
            node.Add(a);
        }
        getNode(a.left,val);     
        getNode(a.right,val);
    }
    
    bool isSame(TreeNode a,TreeNode b){
        if(a==null && b==null){
            return true;
        }
        if((a!=null && b==null) || (a==null && b!=null)){
            return false;
        }
        else if(a.val == b.val){
            return ((isSame(a.left,b.left))&&(isSame(a.right,b.right)));
        }
        return false;
    }
}



public class Solution {
    
    public bool IsSubtree(TreeNode root, TreeNode subRoot) {
        
        if(root == null) return false;       
        
        else if((root.val == subRoot.val)&& IsSameTree(root, subRoot)) return true;
        
        else
        {
            return IsSubtree(root.left, subRoot) 
                || IsSubtree(root.right, subRoot);
        }
               
    }
    
    private bool IsSameTree(TreeNode root, TreeNode subRoot)
    {
        if(root == null && subRoot== null ) return true;
        
        else if(root == null || subRoot == null) return false;
        
        
        return (root.val == subRoot.val) 
                && IsSameTree(root.left, subRoot.left) 
                && IsSameTree(root.right, subRoot.right);
    }
}
