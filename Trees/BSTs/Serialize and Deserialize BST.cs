/*
Serialization is converting a data structure or object into a sequence of bits so that it can be stored in a file or memory buffer, 
or transmitted across a network connection link to be reconstructed later in the same or another computer environment.
Design an algorithm to serialize and deserialize a binary search tree. There is no restriction on how your serialization/deserialization algorithm should work. 
You need to ensure that a binary search tree can be serialized to a string, and this string can be deserialized to the original tree structure.
The encoded string should be as compact as possible.
Example 1:
Input: root = [2,1,3]
Output: [2,1,3]
Example 2:
Input: root = []
Output: []
*/

/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Codec {

    // Encodes a tree to a single string.
    public string serialize(TreeNode root) {
        
        if(root==null){
            return "#,";
        }
        return root.val+","+serialize(root.left)+serialize(root.right);
        
    }

    // Decodes your encoded data to tree.
    public TreeNode deserialize(string data) {
        
        int i = 0;
        return des(data.Split(','),ref i);
    }
    
    private TreeNode des(string[] data,ref int i){
        
        if(data[i]=="#"){
            return null;
        }
        TreeNode root = new TreeNode(Convert.ToInt32(data[i]));
        if(++i<data.Length){
            root.left = des(data,ref i);
        }
        if(++i<data.Length){
            root.right = des(data,ref i);
        }
        return root;
    }
    
}

// Your Codec object will be instantiated and called as such:
// Codec ser = new Codec();
// Codec deser = new Codec();
// String tree = ser.serialize(root);
// TreeNode ans = deser.deserialize(tree);
// return ans;
