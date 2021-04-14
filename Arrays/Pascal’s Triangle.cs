//Given numRows, generate the first numRows of Pascal’s triangle.
//Pascal’s triangle : To generate A[C] in row R, sum up A’[C] and A’[C-1] from previous row R - 1.
//Example:Given numRows = 5,
//Return
//[
//    [1],
//     [1,1],
//     [1,2,1],
//     [1,3,3,1],
//     [1,4,6,4,1]
//]


class Solution {
    public List<List<int>> solve(int A) {
        
        List<List<int>> result = new List<List<int>>();
        if(A==0){return result;}
        result.Add(new List<int>{1});
        for(int n = 1;n<A;n++){
         List<int> res = new List<int>();    
          int prev = 1; 
          res.Add(prev); 
        for(int i = 1; i <= n; i++)
        { 
        // nCr = (nCr-1 * (n - r + 1))/r
        int curr = (prev * (n - i + 1)) / i;
        res.Add(curr);
        prev = curr;
        }
        result.Add(res);
        }
        return result;  
    }
}
