/*Given a binary tree, return the inorder traversal of its nodes’ values.
Example :
Given binary tree
   1
    \
     2
    /
   3
return [1,3,2]. */


/**
 * Definition for binary tree
 * class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) {this.val = x; this.left = this.right = null;}
 * }
 */
 
 //No extra space and no recursion
class Solution {
    public List<int> inorderTraversal(TreeNode A) {
        List<int> list = new List<int>();
        TreeNode cur = A;
        
        while(cur != null){
             if(cur.left == null){
                 list.Add(cur.val);
                 cur=cur.right;
             }
             else{
               TreeNode temp = new TreeNode();
               temp = cur.left;
               while(temp.right!= null && temp.right != cur){
                   temp=temp.right;
               }
                 if(temp.right==null){
                     temp.right = cur; 
                     cur=cur.left;
                 }
                 else{
                     temp.right = null;
                     list.Add(cur.val);
                     cur=cur.right;
                 } 
             } 
        } 
         return list;
    }
}

//recursion
class Solution {
    public List<int> inorderTraversal(TreeNode A) {
        List<int> list = new List<int>();
        Inorder(A,list);
        return list;
    }
    
    private void Inorder(TreeNode A,List<int>list){
        
        if(A==null){
            return;
        } 
        Inorder(A.left,list);
        list.Add(A.val);
        Inorder(A.right,list);
         
    }
}


//extra space
class Solution {
    public List<int> inorderTraversal(TreeNode A) {
        List<int> list = new List<int>();
        Inorder(A,list);
        return list;
    }
    
    private void Inorder(TreeNode A,List<int>list){
        
        if (A == null)
        {
            return;
        } 
        Stack<TreeNode> s = new Stack<TreeNode>();
        TreeNode curr = A;
   
        //curr!=null || s.Count>0
        while (curr!=null || s.Count > 0)
        {
  
            while (curr != null)
            { 
                s.Push(curr); 
                curr = curr.left;  
            }
  
            curr = s.Pop();
 
            list.Add(curr.val); 
            
            curr = curr.right; 
            
        }    
    }
}






