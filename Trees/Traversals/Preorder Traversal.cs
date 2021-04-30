/* Given a binary tree, return the preorder traversal of its nodes’ values.
Example :
Given binary tree
   1
    \
     2
    /
   3
return [1,2,3]. */


/**
 * Definition for binary tree
 * class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) {this.val = x; this.left = this.right = null;}
 * }
 */
 
 
 //Morris algo, no recursion and extra space
class Solution {
    public List<int> preorderTraversal(TreeNode A) {
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
                      list.Add(cur.val);
                     cur=cur.left;
                 }
                 else{
                     temp.right = null; 
                     cur=cur.right;
                 } 
             }  
        } 
        return list;
    }
}

//Recursion

class Solution {
    public List<int> preorderTraversal(TreeNode A) {
        List<int> list = new List<int>();
        PreOrderTraversal(A,list); 
        return list;
    }
    
    private void PreOrderTraversal(TreeNode A,List<int> list){
        
        if(A==null){
            return;
        }
        
        list.Add(A.val);
        PreOrderTraversal(A.left,list);
        PreOrderTraversal(A.right,list);
    }
}

//using extra space
class Solution {
    public List<int> preorderTraversal(TreeNode A) {
        List<int> list = new List<int>();
        PreOrderTraversal(A,list); 
        return list;
    }
    
    private void PreOrderTraversal(TreeNode A,List<int> list){
        
         if (A == null) {
            return;
        }
  
        Stack<TreeNode> st = new Stack<TreeNode>();
        st.Push(A);
  
        while (st.Count > 0) {
  
            TreeNode node = st.Peek();
            list.Add(node.val);
            st.Pop();
  
            if (node.right != null) {
                st.Push(node.right);
            }
            if (node.left != null) {
                st.Push(node.left);
            }
        }
    }
}




