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


 
