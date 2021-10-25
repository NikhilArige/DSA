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
    public IList<int> BoundaryTraversal(TreeNode root) {
        var list = new List<int>();
        if(root==null){
            return list;
        }
        list.Add(root.val);
        PrintLeftNodes(root.left,list);
        PrintLeafNodes(root.left,list);
        PrintLeafNodes(root.right,list);
        PrintRightNodes(root.right,list);
        return list;
    }
    
    void PrintLeftNodes(TreeNode root,List<int> list)
    {
        if (root == null){
            return;
        }
        if (root.left!=null)
        {
             list.Add(root.val);
             PrintLeafNodes(root.left,list);
        }
        else if (root.right!=null)
        {
             list.Add(root.val);
             PrintLeafNodes(root.right,list);
        }
    }
    
      void PrintRightNodes(TreeNode root,List<int> list)
    {
        if (root == null){
            return;
        }
        if (root.right!=null)
        {
             PrintLeafNodes(root.right,list);
                 list.Add(root.val);
        }
        else if (root.left!=null)
        {
             PrintLeafNodes(root.left,list);
                 list.Add(root.val);
        }
    }
    
     void PrintLeafNodes(TreeNode root,List<int> list){
         if(root == null){
             return;
         }
         PrintLeafNodes(root.left,list);
         if(root.left==null && root.right == null){
                      list.Add(root.val);

         }
         PrintLeafNodes(root.right,list);
     }
}
