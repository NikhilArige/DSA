//Find the lowest common ancestor in an unordered binary tree given two values in the tree.
//Lowest common ancestor : the lowest common ancestor (LCA) of two nodes v and w in a tree or directed acyclic graph (DAG) is the lowest (i.e. deepest) node
//that has both v and w as descendants. 
//Example :
//        _______3______
//       /              \
//    ___5__          ___1__
//   /      \        /      \
//  6      _ 2_     0        8
//         /   \
//         7    4
//For the above tree, the LCA of nodes 5 and 1 is 3.
//You are given 2 values. Find the lowest common ancestor of the two nodes represented by val1 and val2
//No guarantee that val1 and val2 exist in the tree. If one value doesn’t exist in the tree then return -1.
//There are no duplicate values.
//You can use extra memory, helper functions, and can modify the node struct but, you can’t add a parent pointer.


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
    public int lca(TreeNode A, int B, int C) {
     
        bool aexists=Search(A,B);
        bool bexists=Search(A,C);
        if(aexists && bexists){
        return (Findlca(A,B,C)).val;
        }
        else{
            return -1;
        } 
    } 
    private bool Search(TreeNode A,int a){
        
        if(A==null){
            return false;
        } 
        if(A.val == a){
            return true;
        }
        if(Search(A.left,a)){
            return true;
        }
        else{
            return Search(A.right,a);
        }
         
    } 
    private TreeNode Findlca(TreeNode cur,int a,int b){
        
        if(cur==null){
            return null;
        } 
        if(cur.val == a || cur.val == b){
            return cur;
        } 
        TreeNode left = Findlca(cur.left,a,b);
        TreeNode right = Findlca(cur.right,a,b);
        
        if(left!=null && right!=null){
            return cur;
        } 
        if(left!=null){
            return left;
        }
        else{
            return right;
        }
    } 
    
}
