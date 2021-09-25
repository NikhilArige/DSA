/*
Given an n x n array of integers matrix, return the minimum sum of any falling path through matrix.
A falling path starts at any element in the first row and chooses the element in the next row that is either directly below or diagonally left/right. 
Specifically, the next element from position (row, col) will be (row + 1, col - 1), (row + 1, col), or (row + 1, col + 1).
Example 1:
Input: matrix = [[2,1,3],[6,5,4],[7,8,9]]
Output: 13
Explanation: There are two falling paths with a minimum sum underlined below:
[[2,1,3],      [[2,1,3],
 [6,5,4],       [6,5,4],
 [7,8,9]]       [7,8,9]]
Example 2:
Input: matrix = [[-19,57],[-40,-5]]
Output: -59
Explanation: The falling path with a minimum sum is underlined below:
[[-19,57],
 [-40,-5]]
*/

public class Solution {
    public int MinFallingPathSum(int[][] A) {
        for(int i = 1; i < A.Length; i++)
        {
            for(int j = 0; j < A[0].Length; j++)
            {
                int diagLeft = A[i-1][Math.Max(j-1,0)];
                int diagRight = A[i-1][Math.Min(j+1, A[0].Length-1)];
                
                A[i][j] += Math.Min(Math.Min(diagLeft, A[i-1][j]), diagRight);
            }
        }
        return A[A.Length-1].Min();
    }
}
