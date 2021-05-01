Given a Binary Tree A consisting of N nodes.
You need to find all the cousins of node B.
NOTE:
Siblings should not be considered as cousins.
Try to do it in single traversal.
You can assume that Node B is there in the tree A.
Order doesnt matter in the output.
 A =

           1
         /   \
        2     3
       / \   / \
      4   5 6   7 
B = 5
Input 2:
 A = 
            1
          /   \
         2     3
        / \ .   \
       4   5 .   6
B = 1
Example Output
Output 1:
 [6, 7]
Output 2:
 []
Example Explanation
Explanation 1:
 Cousins of Node 5 are Node 6 and 7 so we will return [6, 7]
 Remember Node 4 is sibling of Node 5 and do not need to return this.
Explanation 2:
 Since Node 1 is the root so it doesnt have any cousin so we will return an empty array.*/
 
 
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
    public List<int> solve(TreeNode A, int B) {
        
        int level = GetLevel(A,B,1);
        List<int> res = new List<int>();
        
        GetCousins(res,A,B,level);
        return res;
        
    }
    
    private void GetCousins(List<int> res,TreeNode A,int B,int level){
        
        if(A==null || level < 2){
            return;
        }
        
        //If current node is parent of a node with given level 
        if (level == 2) 
        { 
            //if siblings
            if(A.left != null && A.right != null){ 
                if (A.left.val == B || A.right.val == B) {
                     return; 
                } 
            }
               
            if (A.left != null && A.left.val!=B) {
                res.Add(A.left.val);
            }
            if (A.right != null && A.right.val!=B) {
                res.Add(A.right.val);
            } 
        } 
        
        if(level > 2){
            
            GetCousins(res,A.left,B,level-1);
            GetCousins(res,A.right,B,level-1);
        }    
            
    }
     
    private int GetLevel(TreeNode A,int B,int level){
        
        if(A==null){
            return 0;
        }
        if(A.val == B){
            return level;
        }
        
        int ifpresentinleft = GetLevel(A.left,B,level+1); 
        if (ifpresentinleft != 0) {
              return ifpresentinleft; 
        }
           
        return GetLevel(A.right,B,level+1);
         
    }
}
