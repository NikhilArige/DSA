/*
You are given an integer array nums with no duplicates. A maximum binary tree can be built recursively from nums using the following algorithm:
Create a root node whose value is the maximum value in nums.
Recursively build the left subtree on the subarray prefix to the left of the maximum value.
Recursively build the right subtree on the subarray suffix to the right of the maximum value.
Return the maximum binary tree built from nums.
Example 1:
Input: nums = [3,2,1,6,0,5]
Output: [6,3,5,null,2,0,null,null,1]
Explanation: The recursive calls are as follow:
- The largest value in [3,2,1,6,0,5] is 6. Left prefix is [3,2,1] and right suffix is [0,5].
    - The largest value in [3,2,1] is 3. Left prefix is [] and right suffix is [2,1].
        - Empty array, so no child.
        - The largest value in [2,1] is 2. Left prefix is [] and right suffix is [1].
            - Empty array, so no child.
            - Only one element, so child is a node with value 1.
    - The largest value in [0,5] is 5. Left prefix is [0] and right suffix is [].
        - Only one element, so child is a node with value 0.
        - Empty array, so no child.
Example 2:
Input: nums = [3,2,1]
Output: [3,null,2,null,1]
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
    public TreeNode ConstructMaximumBinaryTree(int[] nums) {
        if(nums.Length < 1){
            return null;
        }
        var max = nums.Max();
        var root = new TreeNode(max);
        var ind = Array.FindIndex<int>(nums,x=>x == max);
        if(ind == 0){
            root.left = null;
        }
        else{
            root.left = ConstructMaximumBinaryTree(SubArray(nums,0,ind));
        }
        root.right = ConstructMaximumBinaryTree(SubArray(nums,ind+1,nums.Length-1-ind));
        return root;
    }
    public int[] SubArray(int[] data, int index, int length)
    {
        int[] result = new int[length];
        Array.Copy(data, index, result, 0, length);
        return result;
    }
}
