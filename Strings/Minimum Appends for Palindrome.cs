/*Given a string A consisting of lowercase characters.
We need to tell minimum characters to be appended (insertion at end) to make the string A a palindrome.
A = "abede"  Output:2
A = "aabb"   Output:2 */


class Solution {
    public int solve(string A) {
        
        int start=0;
        int f=0;
        int i=0,j=A.Length-1;
        while(i<j){
            if(A[i]==A[j]){
                i++;
                j--;
                f=1;
            }
            else{
                if(f==1){
                //moving right to right most when mismatch and increasing i
                j=A.Length-1;
                f=0;
                }
                else{
                    i++;
                }
             start=i;
            }  
            
        }
        return start;
    }
}
