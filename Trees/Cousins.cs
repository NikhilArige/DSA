/*
Given the root of a binary tree with unique values and the values of two different nodes of the tree x and y, return true
if the nodes corresponding to the values x and y in the tree are cousins, or false otherwise.
Two nodes of a binary tree are cousins if they have the same depth with different parents.
Note that in a binary tree, the root node is at the depth 0, and children of each depth k node are at the depth k + 1.
Example 1:
Input: root = [1,2,3,4], x = 4, y = 3
Output: false
Example 2:
Input: root = [1,2,3,null,4,null,5], x = 5, y = 4
Output: true
Example 3:
Input: root = [1,2,3,null,4], x = 2, y = 3
Output: false
*/

/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    TreeNode parentX;
    TreeNode parentY;
    int hx;
    int hy;
    public bool IsCousins(TreeNode root, int x, int y) {
        
        Find(root,x,y,0,null);
        return (parentX != parentY)  &&(hx==hy);
    }
    
    void Find(TreeNode root,int x,int y,int h,TreeNode parent){
        if(root == null){
            return;
        }
        if(root.val == x){
            parentX = parent;
            hx = h;
        }
        else if(root.val == y){
            parentY = parent;
            hy = h;
        }
        Find(root.left,x,y,h+1,root);
        Find(root.right,x,y,h+1,root);
    }
}
