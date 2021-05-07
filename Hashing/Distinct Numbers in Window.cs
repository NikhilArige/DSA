/* You are given an array of N integers, A1, A2 ,..., AN and an integer B. Return the of count of distinct numbers in all windows of size B.
Formally, return an array of size N-B+1 where i'th element in this array contains number of distinct elements in sequence Ai, Ai+1 ,..., Ai+B-1.
NOTE: if B > N, return an empty array. */
Example Input
Input 1:
 A = [1, 2, 1, 3, 4, 3]
 B = 3
Input 2:
 A = [1, 1, 2, 2]
 B = 1
Example Output
Output 1:
 [2, 3, 3, 2]
Output 2:
 [1, 1, 1, 1]
Example Explanation
Explanation 1:
 A=[1, 2, 1, 3, 4, 3] and B = 3
 All windows of size B are
 [1, 2, 1]
 [2, 1, 3]
 [1, 3, 4]
 [3, 4, 3]
 So, we return an array [2, 3, 3, 2].
Explanation 2:
 Window size is 1, so the output array is [1, 1, 1, 1]. */
 
 
 class Solution {
    public List<int> dNums(List<int> A, int B) {
        
        List<int> result = new List<int>();
        Dictionary<int,int>dict = new Dictionary<int,int>();
        int distcount = 0;
        int i;
        for(i=0;i<B;i++){
            
            if(!dict.ContainsKey(A[i])){
                dict.Add(A[i],1);
                distcount++;
            }
            else{
                dict[A[i]]++;
            }  
        }
        
        result.Add(distcount);
        
        for(;i<A.Count;i++){
            
            if(dict[A[i-B]]==1){
                distcount--;
                dict.Remove(A[i-B]);
            }
            else{
                dict[A[i-B]]--;
            }
            if(!dict.ContainsKey(A[i])){
                dict.Add(A[i],1);
                distcount++;
            }
            else{
                dict[A[i]]++;
            }
             result.Add(distcount);
        }
         return result;
    }
}
