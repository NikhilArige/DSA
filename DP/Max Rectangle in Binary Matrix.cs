/* Given a 2D binary matrix filled with 0’s and 1’s, find the largest rectangle containing all ones and return its area.
Bonus if you can solve it in O(n^2) or less.
Example :
A : [  1 1 1
       0 1 1
       1 0 0 
    ]
Output : 4 
As the max area rectangle is created by the 2x2 rectangle created by (0,1), (0,2), (1,1) and (1,2) */

class Solution {
    public int maximalRectangle(List<List<int>> A) {
        
        int max = int.MinValue;
        int[] rec = new int[A[0].Count];
        
        for(int i =0;i<A.Count;i++){
            
            for(int j=0;j<A[0].Count;j++){ 
                
                if(A[i][j] == 0){
                    rec[j] = 0;
                }
                else{
                    rec[j]+=A[i][j];
                } 
            }
            max = Math.Max(max,maxAreaHistogram(rec,rec.Length));
        } 
        return max;
    }
    
    private int maxAreaHistogram(int[] A,int n){
        int[] left = new int[n]; 
        int[] right = new int[n];
        Stack<int> st = new Stack<int>();
        for(int i=0;i<n;i++){
            if(st.Count==0){
                left[i]=0;
            }
            else{
                while(st.Count > 0 && A[st.Peek()]>=A[i]){
                    st.Pop();
                }
                 left[i] = (st.Count==0)?0:(st.Peek()+1); 
            }   
                st.Push(i);
        }
        st.Clear();
        for(int i=n-1;i>=0;i--){
            if(st.Count==0){
                right[i]=n-1; 
            }
            else{
                while(st.Count > 0 && A[st.Peek()]>=A[i]){
                    st.Pop();
                }
                 right[i] = (st.Count==0)?n-1:(st.Peek()-1);
            }   
                st.Push(i);
        } 
        int mx_area = 0;     
        for(int i=0;i<n;i++){
            mx_area = Math.Max(mx_area,A[i]*(right[i]-left[i]+1));
            }
        return mx_area;    
    }
}

