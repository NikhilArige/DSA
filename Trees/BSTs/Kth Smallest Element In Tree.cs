//Given a binary search tree, write a function to find the kth smallest element in the tree.

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
    public int kthsmallest(TreeNode A, int B) {
        //using Morris Traversal with O(1)space
         TreeNode cur = A;
         int count = 0;
         int k = 0;
         while(cur !=null){
           
           if(cur.left == null){
               count++;
               if(count == B){return cur.val;}
               cur=cur.right;
           }
           else
           {
           TreeNode prev = cur.left;
           while(prev.right != null && prev.right != cur){
               prev=prev.right;
           }
           if(prev.right == null){
               prev.right=cur;
               cur=cur.left;
           }
           else{
               prev.right= null;
               count++;
               if(count == B){return cur.val;}
               cur=cur.right; 
           }
           }
         }  
       return k;  
    }
}

