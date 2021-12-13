/*
Given the root of a binary tree, the value of a target node target, and an integer k, return an array of the values of all nodes that have a distance k from the target node.
You can return the answer in any order.
Example 1:
Input: root = [3,5,1,6,2,0,8,null,null,7,4], target = 5, k = 2
Output: [7,4,1]
Explanation: The nodes that are a distance 2 from the target node (with value 5) have values 7, 4, and 1.
Example 2:
Input: root = [1], target = 1, k = 3
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
public class Solution {
    public IList<int> DistanceK(TreeNode root, TreeNode target, int k) {
        
        var res = new List<int>();
        if(root == null){
            return res;
        }
        
        var map = new Dictionary<TreeNode,TreeNode>();
        FillMap(map,root,null);
        var q = new Queue<TreeNode>();
        var visited = new HashSet<TreeNode>();
        q.Enqueue(target);
        visited.Add(target);
        int dist = 0;
        while(q.Count > 0){
            int size = q.Count;
            for(int i=0;i<size;i++){
                
                var temp = q.Dequeue();
                if(dist == k){
                    res.Add(temp.val);
                    continue;
                }
                if(dist>k){
                    return res;
                }
                if(temp.left!=null && !visited.Contains(temp.left)){
                    q.Enqueue(temp.left);
                    visited.Add(temp.left);
                }
                if(temp.right!=null && !visited.Contains(temp.right)){
                    q.Enqueue(temp.right);
                    visited.Add(temp.right);
                }
                if(map[temp]!=null && !visited.Contains(map[temp])){
                    q.Enqueue(map[temp]);
                    visited.Add(map[temp]);
                }
            }
            dist++;
        }
        return res;
    }
    
    void FillMap(Dictionary<TreeNode,TreeNode> map,TreeNode root,TreeNode parent){
        
        if(root!=null){
            map[root] = parent;
            FillMap(map,root.left,root);FillMap(map,root.right,root);
        }
    }
}
