/*Given a binary tree A with N nodes.
You have to remove all the half nodes and return the final binary tree
NOTE:
Half nodes are nodes which have only one child.
Leaves should not be touched as they have both children as NULL.
Input 1:
           1
         /   \
        2     3
       / 
      4
Input 2:
            1
          /   \
         2     3
        / \     \
       4   5     6
Example Output
Output 1:
           1
         /   \
        4     3
Output 2:
            1
          /   \
         2     6
        / \

       4   5
Example Explanation
Explanation 1:
The only half node present in the tree is 2 so we will remove this node.
Explanation 2:
The only half node present in the tree is 3 so we will remove this node. */



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
    //using postorder traversal
    public TreeNode solve(TreeNode node) {
        if (node == null)
        {
            return null;
        }
    
        //either left next right or right next left
        node.left = solve(node.left);
        node.right = solve(node.right);
  
        if (node.left == null && node.right == null)
        {
            return node;
        }
  
        /* if current nodes is a half node with left 
         child NULL left, then its right child is 
         returned and replaces it in the given tree */
        if (node.left == null)
        {
            TreeNode new_root = node.right;
            return new_root;
        }
  
        /* if current nodes is a half node with right 
           child NULL right, then its right child is 
           returned and replaces it in the given tree */
        if (node.right == null)
        {
            TreeNode new_root = node.left;
            return new_root;
        } 
        return node;  
    }
}

 
