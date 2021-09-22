/*Given a triangle array, return the minimum path sum from top to bottom.
For each step, you may move to an adjacent number of the row below. More formally,
if you are on index i on the current row, you may move to either index i or index i + 1 on the next row.
Example 1:
Input: triangle = [[2],[3,4],[6,5,7],[4,1,8,3]]
Output: 11
Explanation: The triangle looks like:
   2
  3 4
 6 5 7
4 1 8 3
The minimum path sum from top to bottom is 2 + 3 + 5 + 1 = 11 (underlined above).
Example 2:
Input: triangle = [[-10]]
Output: -10 */

public class Solution {
    public int MinimumTotal(IList<IList<int>> triangle) {
        int rows = triangle.Count;
        if (rows == 0){
            return 0;
        }
        //Bottomup approach    
        for (int i = rows-2;i >= 0;i--) {
            for (int k = 0; k < i + 1; k++){
                  triangle[i][k] += Math.Min(triangle[i+1][k], triangle[i+1][k+1]);
            }
        }
        return triangle[0][0];
    }
}
