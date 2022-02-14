/*
You are given a binary matrix matrix of size m x n, and you are allowed to rearrange the columns of the matrix in any order.
Return the area of the largest submatrix within matrix where every element of the submatrix is 1 after reordering the columns optimally.
Example 1:
Input: matrix = [[0,0,1],[1,1,1],[1,0,1]]
Output: 4
Explanation: You can rearrange the columns as shown above.
The largest submatrix of 1s, in bold, has an area of 4.
Example 2:
Input: matrix = [[1,0,1,0,1]]
Output: 3
Explanation: You can rearrange the columns as shown above.
The largest submatrix of 1s, in bold, has an area of 3.
Example 3:
Input: matrix = [[1,1,0],[1,0,1]]
Output: 2
Explanation: Notice that you must rearrange entire columns, and there is no way to make a submatrix of 1s larger than an area of 2.
*/

public class Solution {
    public int LargestSubmatrix(int[][] matrix) {
        
        var heights = new int[matrix[0].Length];
        int result = 0;

        for (int row = 0; row < matrix.Length; row++)
        {
            for (int column = 0; column < matrix[0].Length; column++)
            {
                if (matrix[row][column] == 0)
                {
                    heights[column] = 0;
                }

                else
                {
                    heights[column]++;
                }
            }

            var sortedHeights = heights.OrderByDescending(x => x).ToArray();
            for (int column = 0; column < sortedHeights.Length; column++)
            {
                result = Math.Max(result, sortedHeights[column] * (column + 1));
            }
        }

        return result;
    }
}
