/*
We run a preorder depth-first search (DFS) on the root of a binary tree.
At each node in this traversal, we output D dashes (where D is the depth of this node), then we output the value of this node.  
If the depth of a node is D, the depth of its immediate child is D + 1.  The depth of the root node is 0.
If a node has only one child, that child is guaranteed to be the left child.
Given the output traversal of this traversal, recover the tree and return its root.
Example 1:
Input: traversal = "1-2--3--4-5--6--7"
Output: [1,2,5,3,4,6,7]
Example 2:
Input: traversal = "1-2--3---4-5--6---7"
Output: [1,2,5,3,null,6,null,4,null,7]
Example 3:
Input: traversal = "1-401--349---90--88"
Output: [1,401,null,349,88,90]
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
    public TreeNode RecoverFromPreorder(string s) {
        
        var set = new Dictionary<int,TreeNode>();
        int i = 0;
        while(i<s.Length){
            int curlev = 0,curnum = 0;
            
            while(i < s.Length && s[i]=='-'){
                ++curlev;
                ++i;
            }
            
            while(i < s.Length && s[i]>='0' && s[i]<='9'){
                curnum = curnum*10 + s[i]-'0';
                i++;
            }
            var curNode = new TreeNode(curnum);
            set[curlev]= curNode;
            if(curlev > 0) {
                var parent = set[curlev - 1];
                if(parent.left == null){
                   parent.left = curNode; 
                }
                else{
                  parent.right = curNode;  
                } 
            }
        }
        return set[0];
    }
}
