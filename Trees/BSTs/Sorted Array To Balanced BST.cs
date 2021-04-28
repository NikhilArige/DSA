/*Given an array where elements are sorted in ascending order, convert it to a height balanced BST.
Balanced tree : a height-balanced binary tree is defined as a binary tree in which the depth of the two subtrees of every node never differ by more than 1. 
Example :
Given A : [1, 2, 3]
A height balanced BST  : 

      2
    /   \
   1     3 */
   
   
/**
 * Definition for binary tree
 * class TreeNode {
 *     int val;
 *     TreeNode left;
 *     TreeNode right;
 *     TreeNode(int x) {
 *      val = x;
 *      left=null;
 *      right=null;
 *     }
 * }
 */
public class Solution { 
    public TreeNode sortedArrayToBST(int[] A) {
     
        int n = A.Length;
        TreeNode root = GetsortedArrayToBST(A, 0, n - 1); 
        return root;  
    }
    
    private TreeNode GetsortedArrayToBST(int arr[], int start, int end){
        
        if(start>end){
            return null;
        }  
        int mid = (start+end)/2;
        
        TreeNode root = new TreeNode(arr[mid]);
        
        root.left = GetsortedArrayToBST(arr, start, mid - 1); 
        root.right = GetsortedArrayToBST(arr, mid+1, end);
        return root;
    } 
}

