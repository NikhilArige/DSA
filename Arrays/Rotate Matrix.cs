/*You are given an n x n 2D matrix representing an image.
Rotate the image by 90 degrees (clockwise).
You need to do this in place.
Note that if you end up using an additional array, you will only receive partial score.
Example:
If the array is
[
    [1, 2],
    [3, 4]
]
Then the rotated array becomes:
[
    [3, 1],
    [4, 2]
] */




public class Solution {
    public void Rotate(int[][] A) {
        //1  2  3  4
        //5  6  7  8
        //9  10 11 12  
        //13 14 15 16
        int n= A.Length;
        for(int i=0;i<n;i++){
            //j=i
            for(int j=i;j<n;j++){
                swap(A,i,j,j,i);
                //A[i][j],A[j][i]
            }
        }
        //1  5  9  13
        //2  6  10 14
        //3  7  11 15  
        //4  8  12 16
        for(int i=0;i<n;i++){ 
            for(int j=0;j<n/2;j++){
                swap(A,i,j,i,n-j-1);
            }
        }
        //13  9  5  1
        //14  10  6  2
        //15  11  7  3  
        //16  12  8  4
    }
    
    public void swap(int[][]A,int row1,int col1,int row2,int col2 ){
        
        int temp = A[row1][col1];
        A[row1][col1] = A[row2][col2] ;
        A[row2][col2] = temp;
    }
}
