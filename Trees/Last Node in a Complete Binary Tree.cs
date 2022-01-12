/*
You are given the root of a complete binary tree A.
You have to return the value of the rightmost node in the last level of the binary tree.
Try to find a solution with a better time complexity than O(N).
Problem Constraints
1 <= Number of nodes in the binary tree <= 105
Input Format
The first argument is the root of a binary tree A.
Output Format
Return a single integer denoting the value of the rightmost node in the last level of the binary tree.
Example Input
Input 1:
A = 
    1
   /
  2
Input 2:

A = 
    1
   / \
  2   3
Example Output
Output 1:
2
Output 2:
3
Example Explanation
Explanation 1:
There is only a single node in the last level of the binary tree.
Therefore, the answer is 2.
Explanation 2:
There a two nodes in the last level of the tree.
The rightmost nodes is 3.
*/

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
    public int lastNode(TreeNode A) {
     if(A.left == null && A.right == null){
            return A.val;
        }
        var left = height(A.left);
        var right = height(A.right);
        if(left>right){
            return lastNode(A.left);
        }
        return lastNode(A.right);
    }
    
    public int height(TreeNode root){
        
        var cur = root;
        int count = 0;
        while(cur != null){
            count++;
            cur = cur.left;
        }
        return count; 
    }
}
