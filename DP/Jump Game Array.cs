/* Given an array of non-negative integers, A, you are initially positioned at the first index of the array.
Each element in the array represents your maximum jump length at that position.
Determine if you are able to reach the last index.
Input Format:
The first and the only argument of input will be an integer array A.
Output Format:
Return an integer, representing the answer as described in the problem statement.
    => 0 : If you cannot reach the last index.
    => 1 : If you can reach the last index.
    Examples:
Input 1:
    A = [2,3,1,1,4]
Output 1: 1
Explanation 1:
    Index 0 -> Index 2 -> Index 3 -> Index 4 -> Index 5
Input 2:
    A = [3,2,1,0,4]
Output 2:0
Explanation 2:
    There is no possible path to reach the last index. */
    


class Solution {
    public int canJump(List<int> A) {
        
        if(A[0]==0 && A.Count > 1){
            return 0;
        }
        if(A[0]==0 && A.Count == 1){
            return 1;
        }
         
        if(isPossible(A)){ 
            return 1;   
        }
        else{
            return 0;
        }
    }
    
    private bool isPossible(List<int> A){
        
        int max = 0;
        for(int i=0;i<A.Count;i++){
            
            if(max<i){
                return false;
            }
            
            max = Math.Max(max,i+A[i]);
        }
        return true;
    }
}
 
 
//using dp
class Solution {
    public int canJump(List<int> A) { 
        if(A[0]==0 && A.Count > 1){
            return 0;
        } 
        bool[] dp = new bool[A.Count]; 
        dp[0] = true; 
        for(int i=0;i<A.Count;i++){ 
            if(dp[i] && A[i]>0){ 
                int max = A[i]; 
                for(int jump=1;jump<=max;jump++){
                    if(i+jump < A.Count){
                        dp[i+jump] = true;
                    } 
                } 
            } 
        }
        if(dp[A.Count-1]){ 
            return 1;   
        }
        else{
            return 0;
        }
    }
}
