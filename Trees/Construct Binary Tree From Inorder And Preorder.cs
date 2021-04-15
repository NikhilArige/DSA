//Given preorder and inorder traversal of a tree, construct the binary tree.
//Note: You may assume that duplicates do not exist in the tree. 




//O(n^2 approach)
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
    public int preIndex = 0;
    public TreeNode buildTree(List<int> A, List<int> B) {
        
        TreeNode cur = getTree(B,A,0,A.Count-1);
        return cur;
        
    }
    public  TreeNode getTree(List<int> inorder, List<int> preorder,
                                  int inStrt, int inEnd)
    {
        if (inStrt > inEnd) {
            return null;
        }
 
        /* Pick current node from Preorder traversal
         using preIndex and increment preIndex */
        TreeNode tNode = new TreeNode(preorder[preIndex++]);
 
        /* If this node has no children then return */
        if (inStrt == inEnd) {
            return tNode;
        }
 
        /* Else find the index of this
       node in Inorder traversal */
        int inIndex = inorder.IndexOf(tNode.val);
 
        /* Using index in Inorder traversal,
    construct left and right subtress */
        tNode.left = getTree(inorder, preorder, inStrt, inIndex - 1);
        tNode.right = getTree(inorder, preorder, inIndex + 1, inEnd);
 
        return tNode;
    }
}

//O(n) approach   Only difference is Dictionary 

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
    public int preIndex = 0;
    Dictionary<int,int> dict = new Dictionary<int,int>();
    public TreeNode buildTree(List<int> A, List<int> B) {
        
        for(int i=0;i<B.Count;i++){
            dict.Add(B[i], i);
        }
        
        TreeNode cur = getTree(B,A,0,A.Count-1);
        return cur;
        
    }
    public  TreeNode getTree(List<int> inorder, List<int> preorder,
                                  int inStrt, int inEnd)
    {
        if (inStrt > inEnd) {
            return null;
        }
 
        /* Pick current node from Preorder traversal
         using preIndex and increment preIndex */
        TreeNode tNode = new TreeNode(preorder[preIndex++]);
 
        /* If this node has no children then return */
        if (inStrt == inEnd) {
            return tNode;
        }
 
        /* Else find the index of this
       node in Inorder traversal */
        int inIndex = dict[tNode.val];
 
        /* Using index in Inorder traversal,
    construct left and right subtress */
        tNode.left = getTree(inorder, preorder, inStrt, inIndex - 1);
        tNode.right = getTree(inorder, preorder, inIndex + 1, inEnd);
 
        return tNode;
    }
}
 

