/*Given an integer array A of size N, find the first repeating element in it.
We need to find the element that occurs more than once and whose index of first occurrence is smallest.
If there is no repeating element, return -1.
A = [10, 5, 3, 4, 3, 5, 6]
Output  = 5 */

class Solution {
    public int solve(List<int> A) {
        int n = A.Count;
        Dictionary<int, int> dict = new Dictionary<int,int>();
            for(int i = 0; i<n; i++){
                if(dict.ContainsKey(A[i])){
                   dict[A[i]]++; 
                }
                else{
                    dict.Add(A[i],1);
                }   
            }
            for(int i = 0; i<n; i++){
                if(dict[A[i]] > 1) 
                {
                    return A[i];  
                }
            }
            return -1;
            }
}

