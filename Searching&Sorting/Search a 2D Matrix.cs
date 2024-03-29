/*
Write an efficient algorithm that searches for a value in an m x n matrix. This matrix has the following properties:
Integers in each row are sorted from left to right.
The first integer of each row is greater than the last integer of the previous row.
Example 1:
Input: matrix = [[1,3,5,7],[10,11,16,20],[23,30,34,60]], target = 3
Output: true
Example 2:
Input: matrix = [[1,3,5,7],[10,11,16,20],[23,30,34,60]], target = 13
Output: false
*/
public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        if(matrix.Length == 0) return false;
    
    for(int i = 0; i < matrix.Length; i++)
    { 
        if(target >= matrix[i][0] && target <= matrix[i][matrix[i].Length - 1])
        {
            for(int j = 0; j < matrix[i].Length; j++)
            {
                if(matrix[i][j] == target) return true;
            }
        }
    }
    return false;
    }
}

public boolean searchMatrix(int[][] matrix, int target) {
	
	int row_num = matrix.length;
	int col_num = matrix[0].length;
	
	int begin = 0, end = row_num * col_num - 1;
	
	while(begin <= end){
		int mid = (begin + end) / 2;
		int mid_value = matrix[mid/col_num][mid%col_num];
		
		if( mid_value == target){
			return true;
		
		}else if(mid_value < target){
			//Should move a bit further, otherwise dead loop.
			begin = mid+1;
		}else{
			end = mid-1;
		}
	}
	
	return false;
}
