/*
On an 2 x 3 board, there are five tiles labeled from 1 to 5, and an empty square represented by 0.
A move consists of choosing 0 and a 4-directionally adjacent number and swapping it.
The state of the board is solved if and only if the board is [[1,2,3],[4,5,0]].
Given the puzzle board board, return the least number of moves required so that the state of the board is solved. 
If it is impossible for the state of the board to be solved, return -1.
Example 1:
Input: board = [[1,2,3],[4,0,5]]
Output: 1
Explanation: Swap the 0 and the 5 in one move.
Example 2:
Input: board = [[1,2,3],[5,4,0]]
Output: -1
Explanation: No number of moves will make the board solved.
Example 3:
Input: board = [[4,1,2],[5,0,3]]
Output: 5
Explanation: 5 is the smallest number of moves that solves the board.
An example path:
After move 0: [[4,1,2],[5,0,3]]
After move 1: [[4,1,2],[0,5,3]]
After move 2: [[0,1,2],[4,5,3]]
After move 3: [[1,0,2],[4,5,3]]
After move 4: [[1,2,0],[4,5,3]]
After move 5: [[1,2,3],[4,5,0]]
*/

public class Solution {
    public int SlidingPuzzle(int[][] board) { 
        var key = $"{string.Join("", board[0])}{string.Join("", board[1])}";  //gets the string for input
        var result = "123450";
        var q = new Queue<string>();
        var set = new HashSet<string>();
        q.Enqueue(key);
        set.Add(key);
        var dirs = new int[] { -1, 1, -3, 3 };
        var res = 0;
        while(q.Any()){
            var cnt = q.Count;
            while(cnt-->0){
                var cur = q.Dequeue();
                if(cur==result){
                    return res;
                }
                var pos = cur.IndexOf("0");
                foreach(var dir in dirs){
                    var newindx = pos + dir;
                    if(newindx < 0 || newindx > 5 ||(dir == 1 && pos == 2)|| (pos==3 && dir == -1)){
                        continue;
                    }
                    var charArray = cur.ToCharArray();
                    (charArray[pos],charArray[newindx]) = (charArray[newindx],charArray[pos]);
                    var newstring = new string(charArray);
                    if(set.Add(newstring)){
                        q.Enqueue(newstring);
                    }
                }
                
            }
            res++;
        } 
        return -1;        
    }
}
