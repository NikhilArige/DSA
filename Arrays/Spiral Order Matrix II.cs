/*Given a matrix of m * n elements (m rows, n columns), return all elements of the matrix in spiral order.
Example:
Given the following matrix:
[
    [ 1, 2, 3 ],
    [ 4, 5, 6 ],
    [ 7, 8, 9 ]
]
You should return
[1, 2, 3, 6, 9, 8, 7, 4, 5]*/

class Solution {
    public List<int> spiralOrder(List<List<int>> mat) {
        int rows = mat.Count; 
        int cols = mat[0].Count;
        int i;
        List<int> res = new List<int>();
        int t = 0;   //top most
        int b = rows-1; //bottom most// rows-1
        int l = 0;   //left most
        int r = cols-1; //right most // columns-1
        int dir = 0;
        while(t<=b && l<=r){
         if(dir==0){
             for(i=l;i<=r;i++){
                 res.Add(mat[t][i]);
             }
             t++;
             dir = 1;
         }
         else if(dir==1){
             for(i=t;i<=b;i++){
                res.Add(mat[i][r]);
             }
             r--;
             dir = 2;
         }
         else if(dir==2){
             for(i=r;i>=l;i--){
                 res.Add(mat[b][i]);
             }
             b--;
             dir = 3;
         }
         else if(dir==3){
             for( i=b;i>=t;i--){
                 res.Add(mat[i][l]);
             }
             l++;
             dir = 0;
         } 
        } 
        return res; 
    }
}
