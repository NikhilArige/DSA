/*Given an array of integers A of size N. A represents a histogram i.e A[i] denotes height of
the ith histogram’s bar. Width of each bar is 1.
Largest Rectangle in Histogram: Example 1
Above is a histogram where width of each bar is 1, given height = [2,1,5,6,2,3].
Largest Rectangle in Histogram: Example 2
The largest rectangle is shown in the shaded area, which has area = 10 unit.
Find the area of largest rectangle in the histogram.
 Input Format
The only argument given is the integer array A.
Output Format
Return the area of largest rectangle in the histogram.
For Example
Input 1:
    A = [2, 1, 5, 6, 2, 3]
Output 1:
    10
Explanation 1:
The largest rectangle is shown in the shaded area, which has area = 10 unit. */


class Solution {
    public int largestRectangleArea(List<int> A) {
        
        int n = A.Count;
        if(n==1){return A[0];}
        int[] left = new int[n]; 
        int[] right = new int[n];
        Stack<int> st = new Stack<int>();
        for(int i=0;i<n;i++){
            if(st.Count==0){
                left[i]=0;
                st.Push(i);
            }
            else{
                while(st.Count > 0 && A[st.Peek()]>=A[i]){
                    st.Pop();
                }
                 left[i] = (st.Count==0)?0:(st.Peek()+1);
                 st.Push(i); 
            }  
        }
        st.Clear();
        for(int i=n-1;i>=0;i--){
            if(st.Count==0){
                right[i]=n-1;
                st.Push(i);
            }
            else{
                while(st.Count > 0 && A[st.Peek()]>=A[i]){
                    st.Pop();
                }
                 right[i] = (st.Count==0)?n-1:(st.Peek()-1);
                 st.Push(i); 
            }  
        } 
        int mx_area = 0;     
        for(int i=0;i<n;i++){
            mx_area = Math.Max(mx_area,A[i]*(right[i]-left[i]+1));
            }
        return mx_area;  
    }
}
