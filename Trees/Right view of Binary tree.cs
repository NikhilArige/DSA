//Given a binary tree A of integers. Return an array of integers representing the right view of the Binary tree.
//Right view of a Binary Tree: is a set of nodes visible when the tree is visited from Right side.
//Input :                          Output : [1, 3, 7, 8]
//        1
//      /   \
//     2    3
//    / \  / \
//   4   5 6  7
//  /
// 8 


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
        List<int> res = new List<int>();
        Queue<TreeNode> que = new Queue<TreeNode>(); 
        que.Enqueue(A);
        while(que.Count>0){ 
         int n = que.Count;  
            for (int i = 1; i <= n; i++)
            { 
                TreeNode temp = que.Dequeue();  
                if (i == n){
                      res.Add(temp.val);
                   } 
                if (temp.left != null) {
                    que.Enqueue(temp.left);  
                } 
                if (temp.right != null) {
                    que.Enqueue(temp.right);}
            } 
        }
         return res;
    }
}
