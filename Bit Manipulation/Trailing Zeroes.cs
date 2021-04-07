//Given an integer A, count and return the number of trailing zeroes.

class Solution {
    public int solve(int A) {
        
        string s = Convert.ToString(A,2);     //converts number to string bits
        int n = s.Length;
        int sum =0;
        for(int i=n-1;i>=0;i--){
            if(s[i]=='0'){
                sum++;
            }
            else{ 
                break;
            } 
        }
        return sum; 
    }
}


