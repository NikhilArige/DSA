/*Given a string A and integer B, remove all consecutive same characters that have length exactly B.
A = "aabcd"
B = 2 Output : "bcd" */


class Solution {
    public string solve(string A, int B) {
        string res = "";
         int i =0;
        while( i < A.Length) {
            int j = i;
            while(j < A.Length && A[j] == A[i]) {
                j++;
            }
            if(j - i == B) {
                i = j;
            } else {
                res += A[i];
                i++;
            }
        }
        return res; 
    }
}

