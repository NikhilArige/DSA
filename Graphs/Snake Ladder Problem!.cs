Rishabh takes out his Snakes and Ladders Game, stares the board and wonders: "If I can always roll the die to whatever number I want, what would be the least number of rolls to reach the destination?"
RULES:
The game is played with cubic dice of 6 faces numbered from 1 to A.
Starting from 1 , land on square 100 with the exact roll of the die. If moving the number rolled would place the player beyond square 100, no move is made.
If a player lands at the base of a ladder, the player must climb the ladder. Ladders go up only.
If a player lands at the mouth of a snake, the player must go down the snake and come out through the tail. Snakes go down only.
BOARD DESCRIPTION:
The board is always 10 x 10 with squares numbered from 1 to 100.
The board contains N ladders given in a form of 2D matrix A of size N * 2 where (A[i][0], A[i][1]) denotes a ladder that has its base on square A[i][0] and end at square A[i][1].
The board contains M snakes given in a form of 2D matrix B of size M * 2 where (B[i][0], B[i][1]) denotes a snake that has its mouth on square B[i][0] and tail at square B[i][1].
Example Input
Input 1:
 A = [  [32, 62]
        [42, 68]
        [12, 98]
     ]
 B = [  [95, 13]
        [97, 25]
        [93, 37]
        [79, 27]
        [75, 19]
        [49, 47]
        [67, 17]
Input 2:
 A = [  [8, 52]
        [6, 80]
        [26, 42]
        [2, 72]
     ]
 B = [  [51, 19]
        [39, 11]
        [37, 29]
        [81, 3]
        [59, 5]
        [79, 23]
        [53, 7]
        [43, 33]
        [77, 21] 
Example Output
Output 1:3
Output 2:5
Example Explanation
Explanation 1:
 The player can roll a 5 and a 6 to land at square 12. There is a ladder to square 98. A roll of 2 ends the traverse in 3 rolls.
Explanation 2:
 The player first rolls 5 and climbs the ladder to square 80. Three rolls of 6 get to square 98.
 A final roll of 2 lands on the target square in 5 total rolls. */
 
 
 class Solution {
    public Dictionary<int,int> ladder = new Dictionary<int,int>();
    public Dictionary<int,int> snake = new Dictionary<int,int>();
    public int snakeLadder(List<List<int>> A, List<List<int>> B) { 
        
        foreach(var item in A){
            ladder.Add(item[0],item[1]);
        }
        foreach(var item in B){
            snake.Add(item[0],item[1]);
        }
        
        Queue<int> q = new Queue<int>();
        
        q.Enqueue(1);
        HashSet<int> visited = new HashSet<int>();
        visited.Add(1);
        int diceCount = 0;
        while(q.Count!=0){
         
          int size = q.Count;
          
          for(int i=0;i<size;i++){
              
              int val = q.Dequeue();
              if(val == 100){
                  return diceCount;
              }
              for(int j=1;j<=6;j++){ 
                  int newval = val+j;
                  if(!visited.Contains(newval)){
                      
                      if(ladder.ContainsKey(newval)){
                          q.Enqueue(ladder[newval]);
                          visited.Add(ladder[newval]);
                      }
                      else if(snake.ContainsKey(newval)){
                           q.Enqueue(snake[newval]);
                           visited.Add(snake[newval]);
                      }
                      else{
                          q.Enqueue(newval);
                      } 
                      visited.Add(newval);
                  }
              }
          }
          diceCount ++;
        }
        return -1;
    }
}

 
