//Given an index k, return the kth row of the Pascal’s triangle.
//Pascal’s triangle : To generate A[C] in row R, sum up A’[C] and A’[C-1] from previous row R - 1.
//Example:  k = 3 Ouput : [1,3,3,1]
//NOTE : k is 0 based. k = 0, corresponds to the row [1]. 


class Solution {
    public List<int> getRow(int N) {
    
    List<int> res = new List<int>();    
    int prev = 1; 
    res.Add(prev); 
    for(int i = 1; i <= N; i++)
    { 
        // nCr = (nCr-1 * (n - r + 1))/r
        int curr = (prev * (N - i + 1)) / i;
        res.Add(curr);
        prev = curr;
    }
    return res;
    }
}
