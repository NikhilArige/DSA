/*Given a binary tree containing digits from 0-9 only, each root-to-leaf path could represent a number.
An example is the root-to-leaf path 1->2->3 which represents the number 123.
Find the total sum of all root-to-leaf numbers % 1003.
Example :
    1
   / \
  2   3
The root-to-leaf path 1->2 represents the number 12.
The root-to-leaf path 1->3 represents the number 13.
Return the sum = (12 + 13) % 1003 = 25 % 1003 = 25. */


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
    public int sumNumbers(TreeNode A) {
        
        return (Getsum(A,0))%1003;
    }
    
    private int Getsum(TreeNode A,int val){
        
        if(A==null){
            return 0;
        }
        
        val = (val*10)%1003 + A.val;
        
        if(A.left == null && A.right== null){
            return val;
        }
        
        return Getsum(A.left,val)+Getsum(A.right,val);
        
    }
}
