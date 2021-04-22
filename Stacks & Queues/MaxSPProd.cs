/* You are given an array A containing N integers. The special product of each ith integer in this array is defined as the product of the following:
LeftSpecialValue: For an index i, it is defined as the index j such that A[j]>A[i] and (i>j). If multiple A[j]'s are present in multiple positions, the LeftSpecialValue is the maximum value of j.
RightSpecialValue: For an index i, it is defined as the index j such that A[j]>A[i] and (j>i). If multiple A[j]'s are present in multiple positions, the RightSpecialValue is the minimum value of j.
Write a program to find the maximum special product of any integer in the array.
NOTE: As the answer can be large, output your answer modulo 109 + 7.
Input 1: A = [1, 4, 3, 4]
Input 2: A = [10, 7, 100]
Example Output
Output 1: 3
Output 2:0
Example Explanation
Explanation 1:
For A[2] = 3, LeftSpecialValue is 1 and RightSpecialValue is 3.
So, the ans is 1*3 = 3.
Explanation 2:
There is not any integer having maximum special product > 0. So, the ans is 0. */


class Solution {
    public int maxSpecialProduct(List<int> A) {
        
        int n = A.Count;
        long[] left = new long[n];
        long[] right = new long[n];
        int mod = 1000000007;
        Stack<long> st = new Stack<long>();
        for(int i=0;i<n;i++){ 
            if(st.Count==0){
                left[i] = 0;
                st.Push(i); 
            }
            else{
                while(st.Count>0 && A[(int)st.Peek()]<=A[i]){ 
                    st.Pop();  
                } 
                long val = (st.Count==0) ? 0 : st.Peek();
                left[i] = val;
                st.Push(i); 
            }  
        }
        st.Clear();
        for(int i=n-1;i>=0;i--){ 
            if(st.Count==0){
                right[i] = 0;
                st.Push(i); 
            }
            else{
                while(st.Count>0 && A[(int)st.Peek()]<=A[i]){ 
                    st.Pop();  
                } 
                long val = (st.Count==0) ? 0 : st.Peek();
                right[i] = val;
                st.Push(i); 
            }  
        }
        long max = int.MinValue;
        for(int i=0;i<n;i++){ 
            max = Math.Max((left[i]*right[i]),max); 
        }
           //taken mod here as taking it before would change the prod value
           return (int)(max%mod);
    }
}
