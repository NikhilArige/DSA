/*You are given a binary string(i.e. with characters 0 and 1) S consisting of characters S1, S2, …, SN. 
In a single operation, you can choose two indices L and R such that 1 ≤ L ≤ R ≤ N and flip the characters SL, SL+1, …, SR.
By flipping, we mean change character 0 to 1 and vice-versa.
Your aim is to perform ATMOST one operation such that in final string number of 1s is maximised.
If you don’t want to perform the operation, return an empty array. Else, return an array consisting of two elements denoting L and R.
If there are multiple solutions, return the lexicographically smallest pair of L and R.
Notes:
Pair (a, b) is lexicographically smaller than pair (c, d) if a < c or, if a == c and b < d.
For example,
S = 010
Pair of [L, R] | Final string
_______________|_____________
[1 1]          | 110
[1 2]          | 100
[1 3]          | 101
[2 2]          | 000
[2 3]          | 001
We see that two pairs [1, 1] and [1, 3] give same number of 1s in final string. So, we return [1, 1].
Another example,
If S = 111
No operation can give us more than three 1s in final string. So, we return empty array [] */



class Solution {
    //modified Kadanes Algo with l and r indices
    //we need to find substring = max(OCount-1Count)
    public List<int> flip(string A) {
        int n = A.Length;
        bool allOne = true;
        for(int i=0;i<n;i++){
            if(A[i]=='0'){
                allOne= false;
            }
        }
        if(allOne || n == 0){return new List<int>();}
         
        int maxtillNow=0;
        int totalmax = 0;
        int l=0,r=0;
        int reqi=0,reqj=0;
        for(int i=0;i<n;i++){
            r=i;
            if(A[i]=='1'){
                maxtillNow--;
            }
            else{
                maxtillNow++;
            }
            if(maxtillNow<0){
                 maxtillNow = 0;
                 l=i+1; 
             }
             if(totalmax<maxtillNow){
              totalmax = maxtillNow;
               reqi= l;
               reqj= r;
               //as first encountered indices to be returned if multiple are there
             }
        }
         return new List<int>{(reqi+1),(reqj+1)};
                          //as indices are one based in ques
    }
}


