//Given two binary trees, write a function to check if they are equal or not.
//Two binary trees are considered equal if they are structurally identical and the nodes have the same value.
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
    public int isSameTree(TreeNode A, TreeNode B) { 
        bool isSame = Check(A,B);
        if(isSame){return 1;}
        else{return 0;} 
    } 
    public bool Check(TreeNode A,TreeNode B){
        if(A==null && B==null){
            return true;
        }
        if(A==null || B==null){
            return false;
        }
        
        if(A.val == B.val)
        {
           bool b1 = Check(A.left,B.left);  
           bool b2 = Check(A.right,B.right); 
           if(b1 && b2){
               return true;
           }
        } 
        return false;
    }
      
}
