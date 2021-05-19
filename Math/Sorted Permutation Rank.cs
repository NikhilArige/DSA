/* Given a string, find the rank of the string amongst its permutations sorted lexicographically.
Assume that no characters are repeated.
Example :
Input : 'acb'
Output : 2
The order permutations with letters 'a', 'c', and 'b' : 
abc
acb
bac
bca
cab
cba
The answer might not fit in an integer, so return your answer % 1000003 */

class Solution {
    public int findRank(string A) { 
        var chr = A.ToCharArray();
        Array.Sort(chr);
        string sorted = new string(chr);
        int n = A.Length;
        if(n==1){
            return 1;  //only one is there
        }
        int[] fact = new int[n];
        fact[0] = 1;
        fact[1] = 1;
        for(int i=2;i<n;i++){
            fact[i] = i * fact[i-1] % 1000003;
        }
        int[] check = new int[n];
        int ans = 0;
        int ind = 0;
        for(int i=0;i<n;i++){ 
            if(check[i]==-1){
                continue;
            }
            else if (A[ind] != sorted[i]){ 
                ans += fact[n-ind-1]; //ex: if 'cba' and ind=0 means fact[3-0-1] ie., 2!
            }
            else{
                check[i]=-1;
                ind++;
                i=-1;
            } 
        }
        return (ans+1)% 1000003;
    }
}
