//Given a binary tree, return the reverse level order traversal of its nodes values. (i.e, from left to right and from last level to starting level).
//Input :
//    3
//   / \
//  9  20
//    /  \
//   15   7     Output:  [15, 7, 9, 20, 3] 


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
    public List<int> solve(TreeNode A) { 
        Queue<TreeNode> q = new Queue<TreeNode>(); 
        q.Enqueue(A);
        List<int> list = new List<int>(); 
        while(q.Count > 0){ 
            TreeNode node = q.Dequeue(); 
            list.Add(node.val); 
            if(node.right != null){
                q.Enqueue(node.right);
            } 
            if(node.left != null){
                q.Enqueue(node.left);
            } 
        }  
        list.Reverse();
        return list; 
    }
}
