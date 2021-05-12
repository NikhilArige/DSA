/* Given a 2D matrix, find the number non-empty sub matrices, such that the sum of the elements inside the sub matrix is equal to 0. (note: elements might be negative).
Example:
Input
-8 5  7
3  7 -8
5 -8  9
Output
2 */


class Solution {
    public int solve(List<List<int>> A) {
        
        int count = 0;
        int rows = A.Count;
        if(rows==0){
            return 0;
        }
        int cols = A[0].Count;
        if(cols==0){
            return 0;
        }
         
        for(int i=0;i<rows;i++){
            int[] res = new int[cols];
            for(int j=i;j<rows;j++){
                for(int k=0;k<cols;k++){
                    res[k]+=A[j][k]; 
                }
                count+=subwithzero(res);
            }
        }
        return count;
    }
     //similarily for maxsum submatrix means, we will use kadane's function instead of this
    private int subwithzero(int[] A){
        int sum=0;
        int count = 0;
        var set =  new Dictionary<int,int>();
        set.Add(0,1);
        for(int i=0;i<A.Length;i++){
            sum+=A[i];
            if(set.ContainsKey(sum)){
               count+=set[sum]; 
               set[sum]++;
            } 
            else{
                set.Add(sum,1);
            } 
        }
        return count; 
    }
}

 
