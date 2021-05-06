/*Given an array of integers A and an integer B.
Find the total number of subarrays having bitwise XOR of all elements equals to B.
Example Input
Input 1:
 A = [4, 2, 2, 6, 4]
 B = 6
Input 2:
 A = [5, 6, 7, 8, 9]
 B = 5
Example Output
Output 1:4
Output 2:2
Example Explanation
Explanation 1:
 The subarrays having XOR of their elements as 6 are:
 [4, 2], [4, 2, 2, 6, 4], [2, 2, 6], [6]
Explanation 2:
 The subarrays having XOR of their elements as 2 are [5] and [5, 6, 7, 8, 9] */
 
 class Solution {
    public int solve(List<int> A, int B) {
        
        Dictionary<int,int> dic = new Dictionary<int,int>();
        
        int xr = 0,count = 0;
        
        for(int i = 0;i<A.Count;i++){
            
            xr ^= A[i];
            
            if(xr == B){
                count++;
            }
            if(dic.ContainsKey(xr^B)){
                count+=dic[xr^B];
            }
            if(dic.ContainsKey(xr)){
                dic[xr]++;
            }
            else{
                dic.Add(xr,1);
            }
        } 
        
        return count;
    }
}
