/*Given a binary tree and a sum, find all root-to-leaf paths where each path’s sum equals the given sum.
For example:
Given the below binary tree and sum = 22,
              5
             / \
            4   8
           /   / \
          11  13  4
         /  \    / \
        7    2  5   1
return
[
   [5,4,11,2],
   [5,8,4,5]
] */


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
    public List<List<int>> result = new List<List<int>>();
    public List<List<int>> pathSum(TreeNode A, int B) {
        
        if(A==null){
            return result;
        }
        List<int> res = new List<int>();
        getlist(A,0,B,res);
        return result;
        
    }
     public void getlist(TreeNode A, int sum, int B, List<int> temp){
        
        sum += A.val; 
        temp.Add(A.val); 
        
        if(A.left == null && A.right == null){
            if(sum == B){
              result.Add(temp);  
            } 
        }
        
         if(A.left != null){
            getlist(A.left, sum, B,new List<int>(temp)); 
         }
         if(A.right != null){
             getlist(A.right, sum, B, new List<int>(temp));
         } 

        }
}
