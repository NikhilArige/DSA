/*Given an m x n matrix. If an element is 0, set its entire row and column to 0. Do it in-place.
Follow up:
A straight forward solution using O(mn) space is probably a bad idea.
A simple improvement uses O(m + n) space, but still not the best solution.
Could you devise a constant space solution?
Input 1:
    [   [1, 0, 1],
        [1, 1, 1], 
        [1, 1, 1]   ]

Output 1:
    [   [0, 0, 0],
        [1, 0, 1],
        [1, 0, 1]   ]

Input 2:
    [   [1, 0, 1],
        [1, 1, 1],
        [1, 0, 1]   ]

Output 2:
    [   [0, 0, 0],
        [1, 0, 1],
        [0, 0, 0]   ]*/
        
//no extra space approach        
public class Solution {
    public void SetZeroes(int[][] matrix) {
        int rows = matrix.Length;
        int columns = matrix[0].Length;
        
        //this is for matrix[0][0]
        int col = 1;
        
        for(int i =0;i<rows;i++){
            if(matrix[i][0]==0){col =0;}
            //from j=1
            for(int j=1;j<columns;j++){
                if(matrix[i][j]==0){
                matrix[i][0] = matrix[0][j]=0;
            }
            }
        }
         
        for(int i=rows-1;i>=0;i--){
            //j>=1
            for(int j=columns-1;j>=1;j--){ 
                if(matrix[i][0]==0 || matrix[0][j]==0){
                    matrix[i][j]=0;
                }   
            }
            if(col==0){
                matrix[i][0]=0;
            }
        } 
    }
}

public class Solution {
    public void SetZeroes(int[][] mat) {
        
        var r = mat.Length;
        var c = mat[0].Length;
        
        bool firstColZero = false;
        
        for(int i=0;i<r;i++){
            if(mat[i][0]==0){
                firstColZero = true;
            }
            for(int j=1;j<c;j++){
                if(mat[i][j]==0){
                    mat[0][j]=mat[i][0] = 0;
                }
            }
        }
        
        for(int i=1;i<r;i++){ 
            for(int j=1;j<c;j++){
                if(mat[0][j]==0 || mat[i][0]==0){
                    mat[i][j]= 0;
                }
            }
        }
        
        if(mat[0][0]==0){
            for(int i=0;i<c;i++){
                mat[0][i]=0;
            }
        }
            
        if(firstColZero){
            for(int i=0;i<r;i++){
                mat[i][0]=0;
            }
        }        
         
        
    }
}

//or we can take two arrays/hashsets to store respective 0s and fill matrix values to 0 based on them
