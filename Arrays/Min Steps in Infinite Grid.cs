//You are in an infinite 2D grid where you can move in any of the 8 directions
//(x,y) to (x+1, y),(x - 1, y),(x, y+1),(x, y-1),(x-1, y-1),(x+1,y+1),(x-1,y+1),(x+1,y-1) 
//You are given a sequence of points and the order in which you need to cover the points.. 
//Give the minimum number of steps in which you can achieve it. You start from the first point.
//A = [0, 1, 1] B = [0, 1, 2] Output:2
//Explanation :
//Given three points are: (0, 0), (1, 1) and (1, 2).
//It takes 1 step to move from (0, 0) to (1, 1). It takes one more step to move from (1, 1) to (1, 2).


class Solution {
    public int coverPoints(List<int> A, List<int> B) {
        int n = A.Count;
        int cnt = 0;
        for(int i=0;i<n-1;i++){
            cnt += Math.Max(Math.Abs(A[i]-A[i+1]),Math.Abs(B[i]-B[i+1]));
        } 
        return cnt; 
    }
}

