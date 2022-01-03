

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
    public IList<int> PostorderTraversal(TreeNode root) {
    var list = new List<int>();
     if(root == null){
         return list;
     }  
     var stack = new Stack<TreeNode>();
     stack.Push(root);   
     while(stack.Count>0)
     {
         var cur = stack.Pop();
         list.Insert(0,cur.val);
         if(cur.left!=null){
             stack.Push(cur.left);
         }
         if(cur.right!=null){
             stack.Push(cur.right);
         }
     }
     return list;
    }
}
