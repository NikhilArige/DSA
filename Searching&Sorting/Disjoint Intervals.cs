/*
Given a set of N intervals denoted by 2D array A of size N x 2, the task is to find the length of maximal set of mutually disjoint intervals.
Two intervals [x, y] & [p, q] are said to be disjoint if they do not have any point in common.
Return a integer denoting the length of maximal set of mutually disjoint intervals.
Problem Constraints
1 <= N <= 105
1 <= A[i][0] <= A[i][1] <= 109
Input Format
First and only argument is a 2D array A of size N x 2 denoting the N intervals.
Output Format
Return a integer denoting the length of maximal set of mutually disjoint intervals.
Example Input
Input 1:
 A = [
       [1, 4]
       [2, 3]
       [4, 6]
       [8, 9]
     ]
Input 2:
 A = [
       [1, 9]
       [2, 3]
       [5, 7]
     ]
*/

class Solution {
    public int solve(List<List<int>> intervals) {
        
        if (intervals.Count == 0){
                return 0;
        }
        int res = 1;
        //ascending start and descending end
        intervals.Sort((i1, i2) =>  i1[1].CompareTo(i2[1])); 
        
        int i = 1,end = intervals[0][1];
        while(i < intervals.Count){
           
            if(intervals[i][0] > end){
                res ++;
                end = intervals[i][1];
            }
            i++;
        } 
        return res;
    }
}
