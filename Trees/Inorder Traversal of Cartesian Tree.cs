/* Given an inorder traversal of a cartesian tree, construct the tree.
Cartesian tree : is a heap ordered binary tree, where the root is greater than all the elements in the subtree. 
 Note: You may assume that duplicates do not exist in the tree. 
Example :

Input : [1 2 3]

Return :   
          3
         /
        2
       /
      1 */

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
    public TreeNode buildTree(List<int> A) {
        
        return gettree(A,0,A.Count-1);
    }
    
    private TreeNode gettree(List<int> A, int start, int end){
         
        if(start>end)
        {
            return null;
        }
        int index=getlargeindex(A,start,end);
        TreeNode root = new TreeNode(A[index]);
        if(start==end)
        {
            return root;
        }
        else
        {
            root.left=gettree(A,start,index-1);
            root.right=gettree(A,index+1,end);
        }
        return root;
             
    }
    
    private int getlargeindex(List<int> A, int start,int end){
        
        int ans = int.MinValue,index = 0;
        for(int i=start;i<=end;i++){
            
            if(A[i]>ans){
                ans = A[i];
                index = i;
            } 
        } 
        return index;
    }
}
