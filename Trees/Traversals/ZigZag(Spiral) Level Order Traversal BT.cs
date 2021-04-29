/* Given a binary tree, return the zigzag level order traversal of its nodes’ values. (ie, from left to right, then right to left for the next level and alternate between).
Example :
Given binary tree
    3
   / \
  9  20
    /  \
   15   7
return
[
         [3],
         [20, 9],
         [15, 7]
] */


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
    public List<List<int>> zigzagLevelOrder(TreeNode A) {
        
        List<List<int>> result = new List<List<int>>();
        
        Getzigzagorder(A,result);
        
        return result;
    }
    
    private void Getzigzagorder(TreeNode A,List<List<int>> result){
        
        if (A == null)
        {
            return;
        }
        
        Stack<TreeNode> currentLevel = new Stack<TreeNode>();
        Stack<TreeNode> nextLevel = new Stack<TreeNode>();
        List<int> res = new List<int>();
        currentLevel.Push(A);
         
        bool leftToRight = true;
        
        while(currentLevel.Count>0){
            
           TreeNode node = currentLevel.Pop(); 
           
           res.Add(node.val);
           
            if (leftToRight)
            {
                if (node.left != null)
                {
                    nextLevel.Push(node.left);
                }
         
                if (node.right != null)
                {
                    nextLevel.Push(node.right);
                }
            }
            else
            {
                if (node.right != null)
                {
                    nextLevel.Push(node.right);
                }
         
                if (node.left != null)
                {
                    nextLevel.Push(node.left);
                }
            }  
                
            if (currentLevel.Count == 0)
            {
                result.Add(new List<int>(res));
                res.Clear();
                leftToRight = !leftToRight;
                Stack<TreeNode> temp = currentLevel;
                currentLevel = nextLevel;
                nextLevel = temp;
            }
              
        } 
    } 
}
