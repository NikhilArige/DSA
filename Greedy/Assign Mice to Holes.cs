//There are N Mice and N holes are placed in a straight line.
//Each hole can accomodate only 1 mouse.
//A mouse can stay at his position, move one step right from x to x + 1, or move one step left from x to x − 1. Any of these moves consumes 1 minute.
//Assign mice to holes so that the time when the last mouse gets inside a hole is minimized.
//Example:
//positions of mice are:
//4 -4 2
//positions of holes are:
//4 0 5
//Assign mouse at position x=4 to hole at position x=4 : Time taken is 0 minutes 
//Assign mouse at position x=-4 to hole at position x=0 : Time taken is 4 minutes 
//Assign mouse at position x=2 to hole at position x=5 : Time taken is 3 minutes 
//After 4 minutes all of the mice are in the holes.
//Since, there is no combination possible where the last mouse`s time is less than 4, 
//answer = 4



class Solution {
    public int mice(List<int> A, List<int> B) {
        A.Sort();
        B.Sort();
        int max = 0;
        for(int i=0;i<A.Count;i++){
            max = Math.Max(max,Math.Abs(A[i]-B[i]));
        } 
        return max;
    }
}

