/*Two elements of a binary search tree (BST) are swapped by mistake.
Tell us the 2 values swapping which the tree will be restored.
Note:
A solution using O(n) space is pretty straight forward. Could you devise a constant space solution? 
Example :
Input : 
         1
        / \
       2   3
Output : 
       [1, 2]
Explanation : Swapping 1 and 2 will change the BST to be 
         2
        / \
       1   3
which is a valid BST */

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
    
    TreeNode first = new TreeNode();
    TreeNode prev = new TreeNode();
    TreeNode middle = new TreeNode();
    TreeNode last = new TreeNode();
    public List<int> recoverTree(TreeNode A) {
        
           first = null;
           prev = null;
           middle  = null;
           last = null;
           FindNodes(A);
        
        List<int> result = new List<int>();
         
          // not adjacent
          if(first != null && last != null)
          {
            result.Add(last.val);
            result.Add(first.val);  
          }
            
          // if Adjacent nodes swapped
          else if(first != null && middle != null) 
          {
            result.Add(middle.val);
            result.Add(first.val);
          }
        
        return result;
    }
    
    private void FindNodes(TreeNode A){
      
       if(A!=null){
       
       FindNodes(A.left);
       
       if (prev != null && A.val < prev.val)
        {
          // If this is first violation, marking these two nodes as
          // 'first' and 'middle'
          if (first == null)
          {
            first = prev;
            middle = A;
          }
      
          // If this is second violation,
          // marking this node as last
          else{
              last = A;
          } 
        }
  
        // Marking this node  as previous
        prev = A;
      
        // Recur for the
        // right subtree
        FindNodes(A.right);
        
      }   
    } 
}


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
    TreeNode first = null;
    TreeNode prev = null;
    TreeNode last = null;
    public void RecoverTree(TreeNode root) {
        FindNodes(root);
        var temp = last.val;
        last.val = first.val;
        first.val = temp;
    }
    
    void FindNodes(TreeNode A){
        
        if(A==null){return;}
        FindNodes(A.left);
        if(prev!=null){
            if(prev.val>A.val){
                if(first==null){
                first = prev;
            }
            last = A;
            }
        }
        prev = A;
        FindNodes(A.right);
    }
}
