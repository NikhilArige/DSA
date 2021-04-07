//Given a binary tree and a sum, determine if the tree has a root-to-leaf path such that adding up all the values along the path equals the given sum.


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
    public int hasPathSum(TreeNode A, int B) {
        if(Check(A,B,0)){
          return 1;  
        }
        else{
            return 0;
        }
    }
     
    public bool Check(TreeNode A, int B,int sum){
        if(A==null){
            return false;
        }
        //if we have to return path values means, we can add to list here
        sum +=A.val;
         //as path needs to be till leaf node, not in between
        if(sum == B && A.left == null && A.right == null){
            return true;
        }
        bool b1 = Check(A.left,B,sum);
        bool b2 = Check(A.right,B,sum);
        if(b1 || b2){
            return true;
        }
        sum = sum - A.val;
        return false;
    }    
}
