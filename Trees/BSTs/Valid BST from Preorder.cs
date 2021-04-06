//You are given a preorder traversal A, of a Binary Search Tree.
//Find if it is a valid preorder traversal of a BST.

class Solution {
    public int solve(List<int> A) {
        
        int root = int.MinValue;
        Stack<int> st = new Stack<int>();
        
        for(int i =0;i<A.Count;i++){
            //If we find the next greater element than root,then all the coming elements
            //should be greater than that else false
            if(A[i]<root){
                return 0;
            }
            //Pushing only greater
            while(st.Count>0 && st.Peek()<A[i]){
                root=st.Peek();
                st.Pop();
            }
            
            st.Push(A[i]);
        }
        return 1;
    }
}
