/* 
Serialization is the process of converting a data structure or object into a sequence of bits so that it can be stored in a file or memory buffer, 
or transmitted across a network connection link to be reconstructed later in the same or another computer environment.

Design an algorithm to serialize and deserialize a binary tree. There is no restriction on how your serialization/deserialization algorithm should work.
You just need to ensure that a binary tree can be serialized to a string and this string can be deserialized to the original tree structure.

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
        
        return DFS(root, new StringBuilder()).ToString();
        
    }

    // Decodes your encoded data to tree.
    public TreeNode deserialize(string data) {
        
        string[] str = data.Split(","); 
        
        return des(str.ToList()); 
        
    }
    
    TreeNode des(List<string> str){
        
        if( str.Count() >0)
        {
            if(str[0] == "null")
            {
                str.RemoveAt(0);
                return null;
            }

            TreeNode root = new TreeNode(Convert.ToInt32(str[0]));
            str.RemoveAt(0);
            root.left = des(str);
            root.right = des(str);

            return root;
        }
        
        return null;
    }
    
    StringBuilder DFS(TreeNode root, StringBuilder str){
        
        if( root == null)
        {
            str.Append("null,");
        }
        else
        {
            str.Append(root.val.ToString());
            str.Append(",");
            str = DFS(root.left, str);
            str = DFS(root.right, str);
        }
        return str;
    }
     
}

// Your Codec object will be instantiated and called as such:
// Codec ser = new Codec();
// Codec deser = new Codec();
// TreeNode ans = deser.deserialize(ser.serialize(root));




