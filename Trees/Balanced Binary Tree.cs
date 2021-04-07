//Given a binary tree, determine if it is height-balanced.
//Height-balanced binary tree : is defined as a binary tree in which the depth of the two subtrees of every node never differ by more than 1. 
//Return 0 / 1 ( 0 for false, 1 for true ) for this problem


/**
 * Definition for binary tree
 * class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) {this.val = x; this.left = this.right = null;}
 * }
 */
class Solution {
    public int isBalanced(TreeNode A) {  
        
    if(Check(A)){
        return 1;
    }
    else{
        return 0;
    }
        
    }
    public bool Check(TreeNode A){
        int lh;  
        int rh;  
   
        if (A == null) {
            return true;
        }
   
        lh = height(A.left);
        rh = height(A.right);
  
        if (Math.Abs(lh - rh) <= 1 && Check(A.left)
            && Check(A.right)) {
            return true;
        }
   
        return false;
    }
    
    public int height(TreeNode A){
    if (A == null) {
            return 0;
        } 
        return 1 + Math.Max(height(A.left), height(A.right));
        
    } 
    
}
