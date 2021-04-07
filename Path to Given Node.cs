//Given a Binary Tree A containing N nodes.
//You need to find the path from Root to a given node B.
//A =  
//           1
//         /   \
//        2     3
//      / \   / \
//      4   5 6   7 
// B = 5
// Output :[1, 2, 5]


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
        List<int>result = new List<int>();
        bool exists = CheckNode(A,result,B);
        if(exists){
            return result;
        }
        else{
            return null;
        }  
    } 
    public bool CheckNode(TreeNode A,List<int> res,int B){
        
        if(A==null){return false;}
        res.Add(A.val);
        if(A.val == B){
            return true;
        }
        if (CheckNode(A.left, res, B) || 
            CheckNode(A.right, res, B)) 
            return true; 
        
        res.RemoveAt(res.Count-1);
        return false; 
    }
     
}

