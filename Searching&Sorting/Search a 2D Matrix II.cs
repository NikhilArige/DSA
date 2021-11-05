/*
Write an efficient algorithm that searches for a target value in an m x n integer matrix. The matrix has the following properties:
Integers in each row are sorted in ascending from left to right.
Integers in each column are sorted in ascending from top to bottom.
Example 1:
Input: matrix = [[1,4,7,11,15],[2,5,8,12,19],[3,6,9,16,22],[10,13,14,17,24],[18,21,23,26,30]], target = 5
Output: true
Example 2:
Input: matrix = [[1,4,7,11,15],[2,5,8,12,19],[3,6,9,16,22],[10,13,14,17,24],[18,21,23,26,30]], target = 20
Output: false
*/

public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        if(matrix==null || matrix.Length==0)
            return false;
        
        int rows = matrix.Length;
        int columns = matrix[0].Length;
        int i = 0;
        int j = columns-1;
        
        while(i<rows && j>=0)
        {
            if(matrix[i][j]==target)
                return true;
            
            if(matrix[i][j] < target)
                i++;
            else
                j--;
        }
        
        return false;
    }
}
