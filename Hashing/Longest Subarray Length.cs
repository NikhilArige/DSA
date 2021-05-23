/* Given an integer array A of size N containing 0's and 1's only.
You need to find the length of the longest subarray having count of 1’s one more than count of 0’s.
Example Input
Input 1:
 A = [0, 1, 1, 0, 0, 1]
Input 2:
 A = [1, 0, 0, 1, 0]
Example Output
Output 1:5
Output 2:1
Example Explanation
Explanation 1:
 Subarray of length 5, index 1 to 5 i.e 1, 1, 0, 0, 1. Count of 1 = 3, Count of 0 = 2.
Explanation 2:
 Subarray of length 1 will be only subarray that follow the above condition. */
 
 class Solution {
    public int solve(List<int> A) {
        Dictionary<int,int> dic = new Dictionary<int,int>();
        int mx = 0;
        int s = 0;
        for(int i=0;i<A.Count;i++){
            if(A[i]==0){
                s--;
            }   
            else{
                s++;
            }
            if(s==1){
                mx=i+1;         //for the firsttime
            }
            if(dic.ContainsKey(s-1)){
                mx=Math.Max(mx,i-dic[s-1]);    //reason for (s-1), ex:consider current sum =5 and there exists s-1 i.e., 5-1=4 in dictionary,
                                               //this means 5-4=1 i.e., present ones are greater than 0s
            }
            if(!dic.ContainsKey(s)){
               dic.Add(s,i); 
            } 
        } 
        return mx; 
    }
}
