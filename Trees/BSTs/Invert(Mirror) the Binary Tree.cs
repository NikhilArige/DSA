//Given a binary tree, invert the binary tree and return it. 

/**
 * Definition for binary tree
 * class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) {this.val = x; this.left = this.right = null;}
 * }
 */
 
 //recursive
class Solution {
    public TreeNode invertTree(TreeNode A) {  
        return invert(A);
    } 
    public TreeNode invert(TreeNode A){ 
        if(A==null){
            return A;
        }
        TreeNode left = invert(A.left);
        TreeNode right = invert(A.right);  
        A.left = right;
        A.right = left;
        return A;
    }
}

//iterative
//do level order and swap while doing


public void mirror(Node root)
{
    if (root == null)
        return;
  
    Queue<Node> q = new Queue<Node>(); 
    q.Enqueue(root);
  
    // Do BFS. While doing BFS, keep swapping
    // left and right children
    while (q.Count > 0)
    {
        // pop top node from queue
        Node curr = q.Peek();
        q.Dequeue();
  
        // swap left child with right child
        Node temp = curr.left;
        curr.left = curr.right;
        curr.right = temp;;
  
        // push left and right children
        if (curr.left != null)
            q.Enqueue(curr.left);
        if (curr.right != null)
            q.Enqueue(curr.right);
    }
}
