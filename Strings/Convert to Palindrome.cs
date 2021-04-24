/*Given a string A consisting only of lowercase characters, we need to check whether it is possible to make this string a palindrome after removing exactly one character from this.
If it is possible then return 1 else return 0. 
A = "abcba" Output:1
A = "abecbea" Output:0 */


class Solution {
    public int solve(string A) {
        int i=0;
        int j=A.Length-1;
        int count = 0;
        while(i<j){
            if(A[i] == A[j]){
                i++; j--;
            }
            else{
                if(A[i]==A[j-1]){
                    j--;
                }
                else if(A[i+1] == A[j]){
                    i++;
                }
                else{
                    return 0;
                }
                //as maximum one can be skipped
                count++;
                if(count > 1){
                return 0;
            }
            }    
        }
        return 1; 
    }
}

