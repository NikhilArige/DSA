/* Given a Binary Tree denoted by root node A having integer value on nodes. You need to find maximum sum level in it.
Input 1:

 Tree:      4
          /   \
         2     5
        / \   / \
       1  3  2   6
Input 2:

 Tree:      1
          /   \
         2     3
       /  \     \
      4    5     8
                / \
               6   7  
Example Output
Output 1: 12
Output 2: 17 
Example Explanation
Explanation 1:

 Sum of all nodes of 0'th level is 4 
 Sum of all nodes of 1'th level is 7
 Sum of all nodes of 2'th level is 12
 Hence maximum sum is 12
Explanation 2:

 Sum of all nodes of 0'th level is 1
 Sum of all nodes of 1'th level is 5
 Sum of all nodes of 2'th level is 17
 Sum of all nodes of 3'th level is 13
 Hence maximum sum is 17

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
    public int solve(TreeNode A) {
        
        int max = A.val;
        
        Queue<TreeNode> q = new Queue<TreeNode>(); 
        q.Enqueue(A);
        while(q.Count>0){
            
            int tempsum = 0;
            int size = q.Count;
            for(int i=0;i<size;i++){
                
            TreeNode temp = q.Dequeue();
            tempsum+=temp.val;
            if(temp.left!=null){
                 q.Enqueue(temp.left);
            }
            if(temp.right!=null){
                 q.Enqueue(temp.right);
            }
                
            } 
            max = Math.Max(max,tempsum); 
        }
         
        return max;
    }
}


