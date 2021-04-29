/*Given a binary search tree T, where each node contains a positive integer, and an integer K,
you have to find whether or not there exist two different nodes A and B such that A.value + B.value = K.
Return 1 to denote that two such nodes exist. Return 0, otherwise.
Notes
Your solution should run in linear time and not take memory more than O(height of T).
Assume all values in BST are distinct.
Example :
Input 1: 
T :       10
         / \
        9   20
K = 19
Return: 1
Input 2: 
T:        10
         / \
        9   20
K = 40
Return: 0 */



/**
 * Definition for binary tree
 * class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) {this.val = x; this.left = this.right = null;}
 * }
 */

//O(n) and O(n) Approach
class Solution {
    public int t2Sum(TreeNode A, int B) {
       HashSet<int> set = new HashSet<int>();
       if(check(A,B,set)){
           return 1;
       }
       else{
           return 0;
       }
    }
    
    public bool check(TreeNode A, int sum,HashSet<int> set){
        
        if(A==null){
            return false;
        }
        if(check(A.left,sum,set)){
            return true;
        }
           
        if(set.Contains(sum-A.val)){ 
            return true;
        }
        
        else{
            set.Add(A.val);
        }
        
        return check(A.right,sum,set);
    }
}

//O(n) and O(logn) Approach

class Solution {
    public int t2Sum(TreeNode A, int B) { 
       if(check(A,B)){
           return 1;
       }
       else{
           return 0;
       }
    }
    
    public bool check(TreeNode A, int B){
        
        if(A==null){
            return false;
        }
        Stack<TreeNode> st1 = new Stack<TreeNode>();
        Stack<TreeNode> st2 = new Stack<TreeNode>();
        push_left_nodes(st1, A);
        push_right_nodes(st2, A);
        TreeNode low = st1.Peek();
        TreeNode high = st2.Peek();
        while (low!=null && high!=null && low.val < high.val)
        {
            int sum = low.val + high.val;
            if (sum < B) // increase low
            {
                push_left_nodes(st1, low.right);
                low = st1.Peek();
                st1.Pop();
            }
            else if (sum > B) // decrease high
            {
                push_right_nodes(st2, high.left);
                high = st2.Peek();
                st2.Pop();
            }
            else{
                return true; 
            }     
        }
        return false; 
    }
    
    private void push_left_nodes(Stack<TreeNode> st1, TreeNode node)
    {
        while (node!=null)
        {
            st1.Push(node);
            node = node.left;
        }
    }
    
    private void push_right_nodes(Stack<TreeNode> st2, TreeNode node)
    {
        while(node!=null)
        {
            st2.Push(node);
            node = node.right;
        }
    }
}

