/* Given a number A in a form of string.
You have to find the smallest number that has same set of digits as A and is greater than A.
If A is the greatest possible number with its set of digits, then return -1.
Input 1:
 A = "218765"
Input 2:
 A = "4321"
Example Output
Output 1:
 "251678"
Output 2:
 "-1"
Example Explanation
Explanation 1:
 The smallest number greater then 218765 with same set of digits is 251678.
Explanation 2:
 The given number is the largest possible number with given set of digits so we will return -1. */
 
 class Solution {
    public string solve(string str) {
        char[] A = str.ToCharArray();
        int index= -1;
        int n = A.Length;
        for(int i = n-1;i>0;i--){
            if(Convert.ToInt32(A[i])>Convert.ToInt32(A[i-1])){
                index = i;
                break;
            }
        }
        if(index==-1){
            return "-1";
        }
        
        int num = Convert.ToInt32(A[index-1]);
        int nextgreaterindex = index;
        for(int i = index;i<n;i++){
            if(Convert.ToInt32(A[i])>num && 
            Convert.ToInt32(A[i])<=Convert.ToInt32(A[nextgreaterindex])){
                nextgreaterindex = i;
            }
        } 
        char temp = A[nextgreaterindex];
        A[nextgreaterindex] = A[index-1];
        A[index-1] = temp; 
        Array.Reverse(A,index,n-index); 
        return new string(A);
         
        
    }
}
