/* Given a binary tree T, find the maximum path sum.
The path may start and end at any node in the tree.
Input Format:
The first and the only argument contains a pointer to the root of T, A.
Output Format:
Return an integer representing the maximum sum path.
Constraints:
1 <= Number of Nodes <= 7e4
-1000 <= Value of Node in T <= 1000
Example :
Input 1:
       1
      / \
     2   3
Output 1:6
Explanation 1:
    The path with maximum sum is: 2 -> 1 -> 3
Input 2:
       -10
       /  \
     -20  -30
Output 2: -10
Explanation 2
    The path with maximum sum is: -10 */
    
    
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
    public int maxPathSum(TreeNode A) {
    int treeMax = int.MinValue;
    solve(A, ref treeMax);
        return treeMax;
    }

public int solve(TreeNode A, ref int res)
    {
        if(A==null)
        {
            return 0;
        }
        
        int l=solve(A.left,ref res);
        int r=solve(A.right,ref res);
        
        /*
        Considering a Node as Boss if both its left subtree
        and right subtree are included in the maxSum else its just a
        normal node which contributes to the maxPathSum of some higher parentNode.
        */
        
        int whenCurrentNodeIsNotTheBoss = Math.Max(Math.Max(l,r)+A.val,A.val);
        int whenCurrentNodeIsTheBoss=Math.Max(whenCurrentNodeIsNotTheBoss,l+r+A.val);
        res = Math.Max(res,whenCurrentNodeIsTheBoss);
        
        return whenCurrentNodeIsNotTheBoss;
    }
    
}
