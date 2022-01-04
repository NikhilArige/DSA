/*
Given the root of a binary tree, each node in the tree has a distinct value.
After deleting all nodes with a value in to_delete, we are left with a forest (a disjoint union of trees).
Return the roots of the trees in the remaining forest. You may return the result in any order.
Example 1:
Input: root = [1,2,3,4,5,6,7], to_delete = [3,5]
Output: [[1,2,null,4],[6],[7]]
Example 2:
Input: root = [1,2,4,null,3], to_delete = [3]
Output: [[1,2,4]]
Constraints:
The number of nodes in the given tree is at most 1000.
Each node has a distinct value between 1 and 1000.
to_delete.length <= 1000
to_delete contains distinct values between 1 and 1000.
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
    HashSet<int> set;
    List<TreeNode> list;
    public IList<TreeNode> DelNodes(TreeNode root, int[] to_delete) {
        
        list = new List<TreeNode>();
        set = new HashSet<int>(to_delete);
        if(!set.Contains(root.val))
        {
            list.Add(root);
        }
        UpdateList(root);
        return list;
    }
    
    TreeNode UpdateList(TreeNode root)
    {
        if(root == null)
        {
            return null;
        }
        root.left = UpdateList(root.left);
        root.right = UpdateList(root.right);
        if(set.Contains(root.val)){
            if(root.left!=null){
                list.Add(root.left);
            }
            if(root.right!=null){
                list.Add(root.right);
            }
            return null;
        }
        return root;
    }
}
