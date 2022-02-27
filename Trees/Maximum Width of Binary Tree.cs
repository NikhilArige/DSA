/*
Given the root of a binary tree, return the maximum width of the given tree.
The maximum width of a tree is the maximum width among all levels.
The width of one level is defined as the length between the end-nodes (the leftmost and rightmost non-null nodes), 
where the null nodes between the end-nodes are also counted into the length calculation.
It is guaranteed that the answer will in the range of 32-bit signed integer.
Example 1:
Input: root = [1,3,2,5,3,null,9]
Output: 4
Explanation: The maximum width existing in the third level with the length 4 (5,3,null,9).
Example 2:
Input: root = [1,3,null,5,3]
Output: 2
Explanation: The maximum width existing in the third level with the length 2 (5,3).
Example 3:
Input: root = [1,3,2,5]
Output: 2
Explanation: The maximum width existing in the second level with the length 2 (3,2).
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
    public int WidthOfBinaryTree(TreeNode root) {
         if(root == null) return 0;
        int result = 0;
        Queue<(TreeNode,int)> q = new Queue<(TreeNode,int)>();
        q.Enqueue((root,1));
        while(q.Count!=0)
        {
            var c = q.Count;
            int l = 0;int r=0;
            for(int i=0;i<c;i++)
            {
                var d = q.Dequeue();
                if(i==0){
                    l = d.Item2;
                    r = d.Item2;
                }
                else{
                    r=d.Item2;
                }
                if(d.Item1.left!=null){
                    q.Enqueue((d.Item1.left,d.Item2*2));
                }
                if(d.Item1.right!=null){
                    q.Enqueue((d.Item1.right,d.Item2*2 +1));
                }
            }
            result = Math.Max(result,r-l+1);
            //           1
            //       2        3
            //   4     5   6     7           // 7-4+1 = 4 => max
        }
        return result;
    }
}
