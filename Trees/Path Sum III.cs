/*
Given the root of a binary tree and an integer targetSum, return the number of paths where the sum of the values along the path equals targetSum.
The path does not need to start or end at the root or a leaf, but it must go downwards (i.e., traveling only from parent nodes to child nodes).
Example 1:
Input: root = [10,5,-3,3,2,null,11,3,-2,null,1], targetSum = 8
Output: 3
Explanation: The paths that sum to 8 are shown.
Example 2:
Input: root = [5,4,8,11,null,13,4,7,2,null,null,5,1], targetSum = 22
Output: 3
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

//O(n^2)
public class Solution {
    public int PathSum(TreeNode root, int sum) {
        if(root==null){
          return 0;  
        } 
        return IsMatchingSum( root, sum) + PathSum( root.left, sum) + PathSum( root.right, sum);
    }
    public static int IsMatchingSum(TreeNode root, int sum)
    {
        if(root==null){
          return 0;  
        } 
        sum-=root.val;
        return ((sum == 0) ? 1 : 0) + IsMatchingSum(root.left, sum) + IsMatchingSum(root.right, sum);
    }  
}

public class Solution {
    private int result = 0;
    private Dictionary<int, int> sumFrequency = new Dictionary<int, int>();  
    
    public int PathSum(TreeNode root, int targetSum) {
        sumFrequency[0] = 1;        
        Search(root, targetSum, 0);        
        return result;
    }
    
    public void Search(TreeNode node, int targetSum, int currentSum) {
        if (node == null) {
            return;
        }
        
        // Determine the current sum
        currentSum = currentSum + node.val;
        
        // Get the path prefix sum
        var prefixSum = currentSum - targetSum;
        
        if (sumFrequency.ContainsKey(prefixSum)) {
            result += sumFrequency[prefixSum];
        }
        
        // Increment the number of times this prefix has been seen
        sumFrequency[currentSum] = (sumFrequency.ContainsKey(currentSum) ? sumFrequency[currentSum] : 0) + 1;
        
        // Keep exploring along branches finding the target sum
        Search(node.left, targetSum, currentSum);
        Search(node.right, targetSum, currentSum);    
        
        // Remove value of this prefixSum (path's been explored)
        --sumFrequency[currentSum];
    }      
}
