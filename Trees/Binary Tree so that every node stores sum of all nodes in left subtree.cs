/*
Given a Binary Tree, change the value in each node to sum of all the values in the nodes in the left subtree including its own.
Examples: 
Input : 
     1
   /   \
 2      3
Output :
    3
  /   \
 2     3
Input
       1
      / \
     2   3
    / \   \
   4   5   6
Output:
      12
     / \
    6   3
   / \   \
  4   5   6
*/

public class Solution {
    public void UpdateTree(TreeNode A) {
            Update(A);
    }  
    
    int Update(TreeNode root){
    
      if(root == null)
      {
      return 0;
      }
    
      if(root.left== null && root.right ==null)
      {
            return root.val;
      }
      
      int leftsum = Update(root.left);
      int rightsum = Update(root.right);
      root.val = leftsum;
      
      return root.val + rightsum;
      
    }
    
    }
