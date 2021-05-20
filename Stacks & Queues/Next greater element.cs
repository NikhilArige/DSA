/* Given an array, find the next greater element G[i] for every element A[i] in the array. 
The Next greater Element for an element A[i] is the first greater element on the right side of A[i] in array.
More formally,
G[i] for an element A[i] = an element A[j] such that 
    j is minimum possible AND 
    j > i AND
    A[j] > A[i]
Elements for which no greater element exist, consider next greater element as -1.
Example:
Input : A : [4, 5, 2, 10]
Output : [5, 10, 10, -1]
Example 2:
Input : A : [3, 2, 1]
Output : [-1, -1, -1] */

class Solution {
    public List<int> nextGreater(List<int> A) {
        
        Stack<int> st = new Stack<int>();
        List<int> result = new List<int>();
        for(int i=A.Count-1;i>=0;i--){ 
            if(st.Count == 0){
                result.Add(-1);
            }
            else{
                while(st.Count>0 && A[i]>=A[st.Peek()]){
                    st.Pop();
                }
                int val = (st.Count == 0 ) ? -1 : A[st.Peek()]; 
                result.Add(val);
            }
            st.Push(i); 
        }
        result.Reverse();
        return result;
    }
}
