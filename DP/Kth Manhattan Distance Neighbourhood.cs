/* Given a matrix M of size nxm and an integer K, find the maximum element in the K manhattan distance neighbourhood for all elements in nxm matrix.
In other words, for every element M[i][j] find the maximum element M[p][q] such that abs(i-p)+abs(j-q) <= K.
Note: Expected time complexity is O(N*N*K)
Constraints:
1 <= n <= 300
1 <= m <= 300
1 <= K <= 300
0 <= M[i][j] <= 1000
Example:
Input:
M  = [[1,2,4],[4,5,8]] , K = 2
Output:
ans = [[5,8,8],[8,8,8]] */


class Solution {
    public List<List<int>> solve(int A, List<List<int>> B) {
        
        int rows = B.Count;
        int cols = B[0].Count;
         
        int[,] dp = new int[rows,cols]; 
        
        for(int i = 0;i<A;i++){
            for(int j=0;j<rows;j++){
                for(int k=0;k<cols;k++){
                    
                    int cur = B[j][k];
                    int up =  j==0 ? -1 : B[j-1][k]; 
                    int down = j==rows-1 ? -1 : B[j+1][k];
                    int left = k==0 ? -1 : B[j][k-1];
                    int right = k==cols-1 ? -1 : B[j][k+1]; 
                    dp[j,k] = max(up,down,left,right,cur);
                    int n = max(up,down,left,right,cur); 
                }
            }
            for(int m=0;m<rows;m++){
                for(int n=0;n<cols;n++){
                    B[m][n] = dp[m,n];
                } 
        }
        } 
        return B;
    }
    
    private int max(int a,int b,int c,int d,int e){
        
        if(a>=b && a>=c && a>=d && a>=e){
            return a;
        }
        else if(b>=a && b>=c && b>=d && b>=e){
            return b;
        }
        else if(c>=b && c>=a && c>=d && c>=e){
            return c;
        }
        else if(d>=b && d>=c && d>=a && d>=e){
            return d;
        }
        else{
            return e;
        }
    }
}
