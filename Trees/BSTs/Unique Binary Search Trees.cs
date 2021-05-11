/* Given A, generate all structurally unique BST’s (binary search trees) that store values 1…A.
Input Format:
The first and the only argument of input contains the integer, A.
Output Format:
Return a list of tree nodes representing the generated BST's.
Constraints:
1 <= A <= 15
Example:
Input 1:
    A = 3
Output 1:
   1         3     3      2      1
    \       /     /      / \      \
     3     2     1      1   3      2
    /     /       \                 \
   2     1         2                 3 */
   

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
	public ArrayList<TreeNode> generateTrees(int a) {
	    
	    return constructTrees(1, a); 
	}
	private ArrayList constructTrees(int start, int end) 
    { 
       ArrayList list = new ArrayList();
       
        if (start > end) 
        { 
            list.Add(null); 
            return list; 
        } 
  
        for (int i = start; i <= end; i++) 
        {  
            ArrayList leftSubtree = constructTrees(start, i - 1);  
            
            ArrayList rightSubtree = constructTrees(i + 1, end); 
       
            for (int j = 0; j < leftSubtree.Count; j++) 
            { 
                TreeNode left = (TreeNode)leftSubtree[j]; 
                
                for (int k = 0; k < rightSubtree.Count; k++) 
                { 
                    TreeNode right = (TreeNode)rightSubtree[k]; 
                       
                    TreeNode node = new TreeNode(i); 
                    
                    node.left = left;
                       
                    node.right = right;     
                     
                    list.Add(node);         
                } 
            } 
        } 
        return list; 
    } 
}
