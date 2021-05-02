/*Given a binary tree, return the level order traversal of its nodes’ values. (ie, from left to right, level by level).
Example :
Given binary tree
    3
   / \
  9  20
    /  \
   15   7
return its level order traversal as:
[
  [3],
  [9,20],
  [15,7]
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
    public List<List<int>> levelOrder(TreeNode A) {
        
        Queue<TreeNode> q = new Queue<TreeNode>();
        List<List<int>> result = new List<List<int>>();
        q.Enqueue(A);
        List<int> res = new List<int>();
        while(q.Count>0){ 
            int size = q.Count; 
            while(size>0){
                 TreeNode temp = q.Dequeue();
                 res.Add(temp.val);
                 if(temp.left!=null){
                     q.Enqueue(temp.left);
                 }
                 if(temp.right!=null){
                     q.Enqueue(temp.right);
                 }
                 size--;
            } 
            result.Add(new List<int>(res));
            res.Clear();
        } 
        return result; 
    }
}
