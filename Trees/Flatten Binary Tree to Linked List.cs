/*Given a binary tree, flatten it to a linked list in-place.
Example :
Given

         1
        / \
       2   5
      / \   \
     3   4   6
The flattened tree should look like:
   1
    \
     2
      \
       3
        \
         4
          \
           5
            \
             6
Note that the left child of all nodes should be NULL. */


/**
 * Definition for binary tree
 * class TreeNode {
 *     int val;
 *     TreeNode left;
 *     TreeNode right;
 *     TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
	public TreeNode flatten(TreeNode a) { 
	    FlattenTree(a);
	    return a;
	}
	
	private void FlattenTree(TreeNode A){
	    
	    if(A==null || (A.left==null && A.right==null)){
	        return;
	    }
	    
	    if(A.left!=null){
	        
	        FlattenTree(A.left);
	        
	        TreeNode temp = A.right;
	        A.right = A.left;
	        A.left = null;
	        
	        TreeNode cur = A.right;
	        while(cur.right != null){
	            cur = cur.right;
	        }
	        cur.right = temp;
	    }
	    
	    FlattenTree(A.right); 
	}
}
