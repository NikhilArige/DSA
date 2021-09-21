//Implement an iterator over a binary search tree (BST). Your iterator will be initialized with the root node of a BST.
//The first call to next() will return the smallest number in BST. Calling next() again will return the next smallest number in the BST, and so on.
//Note: next() and hasNext() should run in average O(1) time and uses O(h) memory, where h is the height of the tree.
//Try to optimize the additional space complexity apart from the amortized time complexity. 


/**
 * Definition for binary tree
 * public class TreeNode {
 *     int val;
 *     TreeNode left;
 *     TreeNode right;
 *     TreeNode(int x) { val = x; }
 * }
 */

public class Solution {

    public Stack<TreeNode> stack = new Stack<>();
    public TreeNode current;
    public Solution(TreeNode root) {
        current = root;
    }
    /** @return whether we have a next smallest number */
    public boolean hasNext() {
        return (!(stack.Count==0) || current != null); 
    }
    /** @return the next smallest number */
    public int next() {
        
        while (current != null) {
            stack.push(current);
            current = current.left;
        }
        current = stack.pop();
        TreeNode node = current;
        current = current.right;
        return node.val;
    }
}

/**
 * Your Solution will be called like this:
 * Solution i = new Solution(root);
 * while (i.hasNext()) Console.WriteLine(i.next());
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
public class BSTIterator {
    
    readonly List<int> list;
    int i = 0;
    public BSTIterator(TreeNode root) {
        list = new List<int>();
        IO(root);
    }
    
    void IO(TreeNode root){
        if(root.left!=null){
            IO(root.left);
        }
        
        list.Add(root.val);
        if(root.right!=null){
            IO(root.right);
        }
    }
    
    public int Next() {
        return list[i++];
    }
    
    public bool HasNext() {
        return i< list.Count ;
    }
}

/**
 * Your BSTIterator object will be instantiated and called as such:
 * BSTIterator obj = new BSTIterator(root);
 * int param_1 = obj.Next();
 * bool param_2 = obj.HasNext();
 */



