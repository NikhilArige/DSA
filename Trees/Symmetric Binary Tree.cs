//Given a binary tree, check whether it is a mirror of itself (ie, symmetric around its center).


/**
 * Definition for binary tree
 * class TreeNode {
 *     int val;
 *     TreeNode left;
 *     TreeNode right;
 *     TreeNode(int x) {
 *      val = x;
 *      left=null;
 *      right=null;
 *     }
 * }
 */
public class Solution {
    public int isSymmetric(TreeNode A) {
        TreeNode cur = A;
        bool issym = check(cur.left,cur.right);
        if(issym){
            return 1;
        }
        else{
            return 0;
        }
    }
    
    public bool check(TreeNode a,TreeNode b){
        if(a==null && b==null){
            return true;
        }
        if(a==null || b==null){
            return false;
        }
        if(a.val==b.val){
        bool b1 = check(a.left,b.right);
        bool b2 = check(a.right,b.left);
        if(b1 && b2){
            return true;
        }    
        }
        return false;
    } 
}


