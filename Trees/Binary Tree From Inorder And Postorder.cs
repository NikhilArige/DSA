/*Given inorder and postorder traversal of a tree, construct the binary tree.
Note: You may assume that duplicates do not exist in the tree. 
Example :
Input : 
        Inorder : [2, 1, 3]
        Postorder : [2, 3, 1]
Return : 
            1
           / \
          2   3 */
          
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
    public int postIndex = 0;
    Dictionary<int,int> dict = new Dictionary<int,int>();
    public TreeNode buildTree(List<int> A, List<int> B) {
        postIndex = B.Count-1;
        for(int i=0;i<A.Count;i++){
            dict.Add(A[i], i);
        }
        TreeNode cur = getTree(A,B,0,A.Count-1);
        return cur;
    }
    
    public  TreeNode getTree(List<int> inorder, List<int> postorder,
                                  int inStrt, int inEnd)
    {
        if (inStrt > inEnd) {
            return null;
        }
 
        /* Pick current node from Preorder traversal
         using postIndex and decrement postIndex */
        TreeNode tNode = new TreeNode(postorder[postIndex--]);
 
        /* If this node has no children then return */
        if (inStrt == inEnd) {
            return tNode;
        }
 
        /* Else find the index of this
        node in Inorder traversal */
        //int inIndex = inorder.IndexOf(tNode.val); TLE because of this,so using dict
        int inIndex = dict[tNode.val];
 
        /* Using index in Inorder traversal,construct left and right subtress */
        tNode.right = getTree(inorder, postorder, inIndex + 1, inEnd);
        tNode.left = getTree(inorder, postorder, inStrt, inIndex - 1);
        return tNode;
    } 
}

