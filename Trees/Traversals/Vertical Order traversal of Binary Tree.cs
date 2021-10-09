/*Given a binary tree A consisting of N nodes, return a 2-D array denoting the vertical order traversal of A.
Go through the example and image for more details.
NOTE:
If 2 or more Tree Nodes shares the same vertical level then the one with earlier occurence in the pre-order traversal of tree comes first in the output.
Row 1 of the output array will be the nodes on leftmost vertical line similarly last row of the output array will be the nodes on the rightmost vertical line.
Problem Constraints
0 <= N <= 104
Input Format
First and only argument is an pointer to root of the binary tree A.
Output Format
Return a 2D array denoting the vertical order traversal of A.
Example Input
Input 1:
      6
    /   \
   3     7
  / \     \
 2   5     9
Input 2:
           1
         /   \
        2     3
       / \
      4   5
Example Output
Output 1:
 [
    [2],
    [3],
    [6, 5],
    [7],
    [9]
 ]
Output 2:

 [
    [4],
    [2],
    [1, 5],
    [3]
 ]
Example Explanation
Explanation 1:
 Nodes on Vertical Line 1: 2
 Nodes on Vertical Line 2: 3
 Nodes on Vertical Line 3: 6, 5
    As 6 and 5 are on the same vertical level but as 6 comes first in the pre-order traversal of the tree so we will output 6 before 5.
 Nodes on Vertical Line 4: 7
 Nodes on Vertical Line 5: 9
Explanation 2:
 Nodes on Vertical Line 1: 4
 Nodes on Vertical Line 2: 2
 Nodes on Vertical Line 3: 1, 5
 Nodes on Vertical Line 4: 3 */
 


/**
 * Definition for binary tree
 * class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) {this.val = x; this.left = this.right = null;}
 * }
 */
using System.Collections;
class Solution {
    
    //to store Node and its hd value
    public class Nodeint{
        
        //horizontal distance to root
        public int Hd;
        public TreeNode Node;
        
        public Nodeint(int hd,TreeNode node){
            
            Hd = hd;
            Node = node;
        } 
    } 
     
    public List<List<int>> verticalOrderTraversal(TreeNode A) {
        
        SortedDictionary<int,List<int>> dic = new SortedDictionary<int,List<int>>();
       
        GetHD(A,dic);
        
        List<List<int>> res = new List<List<int>>();
        
        foreach(var item in dic){
            res.Add(item.Value);
        }
        return res;
    }
    
    private void GetHD(TreeNode A,SortedDictionary<int,List<int>> dic){
        
        if(A==null){
            return;
        }
        Queue que = new Queue(); 
        que.Enqueue(new Nodeint(0, A)); 
        while(que.Count != 0)
        {
            
            Nodeint temp = (Nodeint)que.Dequeue();
            int hd = temp.Hd;
            TreeNode node = temp.Node; 
            if (dic.ContainsKey(hd))
            {
              dic[hd].Add(node.val);
            }
            else
            {
             List<int> list = new List<int>();
             list.Add(node.val);
             dic.Add(hd,list); 
            } 
            if (node.left != null){
                 que.Enqueue(new Nodeint(hd-1,node.left));
            } 
            if (node.right != null){
                que.Enqueue(new Nodeint(hd+1, node.right));
            }   
        } 
    }  
}

 
//PreOrder Approach
class Solution {
    public List<List<int>> verticalOrderTraversal(TreeNode A) {
        
        SortedDictionary<int,List<int>> dic = new SortedDictionary<int,List<int>>();
        //horizontal distance to root
        int hd = 0;
        
        GetHD(A,dic,0);
        
        List<List<int>> res = new List<List<int>>();
        
        foreach(var item in dic){
            res.Add(item.Value);
        }
        return res;
    }
    
    private void GetHD(TreeNode A,SortedDictionary<int,List<int>> dic,int hd){
        
        if(A==null){
            return;
        }
        
        List<int> list = new List<int>();
        if(!dic.ContainsKey(hd)){
            list.Add(A.val);
            dic.Add(hd,list);
        }
        else{ 
            dic[hd].Add(A.val);
        }  
        GetHD(A.left,dic,hd-1);
        GetHD(A.right,dic,hd+1); 
    } 
}

/*
Given the root of a binary tree, calculate the vertical order traversal of the binary tree.
For each node at position (row, col), its left and right children will be at positions (row + 1, col - 1) and (row + 1, col + 1) respectively. 
The root of the tree is at (0, 0).
The vertical order traversal of a binary tree is a list of top-to-bottom orderings for each column index starting from the leftmost column and ending on the rightmost column.
There may be multiple nodes in the same row and same column. In such a case, sort these nodes by their values.
Return the vertical order traversal of the binary tree.
Example 1:
Input: root = [3,9,20,null,null,15,7]
Output: [[9],[3,15],[20],[7]]
Explanation:
Column -1: Only node 9 is in this column.
Column 0: Nodes 3 and 15 are in this column in that order from top to bottom.
Column 1: Only node 20 is in this column.
Column 2: Only node 7 is in this column.
Example 2:
Input: root = [1,2,3,4,5,6,7]
Output: [[4],[2],[1,5,6],[3],[7]]
Explanation:
Column -2: Only node 4 is in this column.
Column -1: Only node 2 is in this column.
Column 0: Nodes 1, 5, and 6 are in this column.
          1 is at the top, so it comes first.
          5 and 6 are at the same position (2, 0), so we order them by their value, 5 before 6.
Column 1: Only node 3 is in this column.
Column 2: Only node 7 is in this column.
Example 3:
Input: root = [1,2,3,4,6,5,7]
Output: [[4],[2],[1,5,6],[3],[7]]
Explanation:
This case is the exact same as example 2, but with nodes 5 and 6 swapped.
Note that the solution remains the same since 5 and 6 are in the same location and should be ordered by their values.
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
public class Solution {
    SortedDictionary<int,List<(int,int)>> map = new SortedDictionary<int,List<(int,int)>>();
    public IList<IList<int>> VerticalTraversal(TreeNode root) {
        
        FillMap(root,0,0);
        
        var res = new List<IList<int>>();
        
        foreach(var item in map){
             res.Add(item.Value.OrderBy(x => x.Item2).ThenBy(x => x.Item1).Select(x => x.Item1).ToList());
        }
        return res;
    }
    
    void FillMap(TreeNode root,int hd,int level){
        
        if(root == null){
            return;
        }
        List<int> list = new List<int>();
         if(!map.ContainsKey(hd)){
            map.Add(hd, new List<(int,int)> { (root.val, level) });
        }
        else{ 
            map[hd].Add((root.val,level));
        }
        FillMap(root.left,hd-1,level+1);
        FillMap(root.right,hd+1,level+1);
    }
}
