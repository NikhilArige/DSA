/* Given an array of integers A and an integer B.
Find the total number of subarrays having exactly B odd numbers.
Example Input
Input 1:
 A = [4, 3, 2, 3, 4]
 B = 2
Input 2:
 A = [5, 6, 7, 8, 9]
 B = 3
Example Output
Output 1: 4
Output 2: 1
Example Explanation
Explanation 1:
 The subarrays having exactly B odd numbers are:
 [4, 3, 2, 3], [4, 3, 2, 3, 4], [3, 2, 3], [3, 2, 3, 4]
Explanation 2:
 The subarrays having exactly B odd numbers is [5, 6, 7, 8, 9] */
 
 
 class Solution {
    public int solve(List<int> A, int B) {
        
        for(int i=0;i<A.Count;i++){
            if(A[i]%2==0){
                A[i]=0;
            }
            else{
                A[i] = 1; //Now the problem is same as finding sum = B
            }
        }
        int count = 0;
        int sum = 0;
        Dictionary<int,int> set = new Dictionary<int,int>();
        for(int i=0;i<A.Count;i++){
            
            sum+= A[i];
            if(sum == B){
                count++;
            }
            
            if(set.ContainsKey(sum-B)){
                count+=set[sum-B];
            }
            if(set.ContainsKey(sum)){
                set[sum]++;
            }
            else{ 
                set.Add(sum,1);
            }
        }
        return count;
    }
}



