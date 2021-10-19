/*
Given a binary tree

struct Node {
  int val;
  Node *left;
  Node *right;
  Node *next;
}
Populate each next pointer to point to its next right node. If there is no next right node, the next pointer should be set to NULL.
Initially, all next pointers are set to NULL.
Example 1:
Input: root = [1,2,3,4,5,null,7]
Output: [1,#,2,3,#,4,5,7,#]
Explanation: Given the above binary tree (Figure A), your function should populate each next pointer to point to its next right node, just like in Figure B. 
The serialized output is in level order as connected by the next pointers, with '#' signifying the end of each level.
Example 2:
Input: root = []
Output: []
*/

/*

// Definition for a Node.
public class Node {
    public int val;
    public Node left;
    public Node right;
    public Node next;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val, Node _left, Node _right, Node _next) {
        val = _val;
        left = _left;
        right = _right;
        next = _next;
    }
}
*/

Space - O(n)
public class Solution {
    public Node Connect(Node root) {
        
        if(root == null){
            return null;
        }
         var q = new Queue<Node>();
        q.Enqueue(root);
        
        while(q.Any()){
            int size = q.Count;
            var dummy  = new Node(-1);
            while(size-- > 0){
                var node = q.Dequeue();
                dummy.next = node;
                dummy=dummy.next;
                if(node.left!=null){
                    q.Enqueue(node.left);
                }
                if(node.right!=null){
                    q.Enqueue(node.right);
                }
            }
            
        }
        
        return root;
    }
}

//Optimal approach

public class Solution {
    public Node Connect(Node root) {
        
         var cur = root;
         while(cur!=null){
             
             var dummy = new Node(-1);
             var temp = dummy;
             
             while(cur!=null){
                 
                 if(cur.left!=null){
                     temp.next = cur.left;
                     temp = temp.next;
                 }
                 if(cur.right!=null){
                     temp.next = cur.right;
                     temp = temp.next;
                 }
                 cur = cur.next;
             }
             
             cur = dummy.next;
         }
        
        return root;
    }
}




