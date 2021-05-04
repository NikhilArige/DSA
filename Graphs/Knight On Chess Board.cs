/* Given any source point, (C, D) and destination point, (E, F) on a chess board, we need to find whether Knight can move to the destination or not.
Knights movements on a chess board
The above figure details the movements for a knight ( 8 possibilities ).
If yes, then what would be the minimum number of steps for the knight to move to the said point.
If knight can not move from the source point to the destination point, then return -1.
Note: A knight cannot go out of the board.
Input Format:
The first argument of input contains an integer A.
The second argument of input contains an integer B.
    => The chessboard is of size A x B.
The third argument of input contains an integer C.
The fourth argument of input contains an integer D.
    => The Knight is initially at position (C, D).
The fifth argument of input contains an integer E.
The sixth argument of input contains an integer F.
    => The Knight wants to reach position (E, F).
Output Format:
If it is possible to reach the destination point, return the minimum number of moves.
Else return -1.
Input 1:
    A = 8
    B = 8
    C = 1
    D = 1
    E = 8
    F = 8
Output 1: 6
Explanation 1:
    The size of the chessboard is 8x8, the knight is initially at (1, 1) and the knight wants to reach position (8, 8).
    The minimum number of moves required for this is 6. */
    
class Solution { 
    public class cell{ 
        public int x;
        public int y;
        public int dist;
        public cell(int x,int y,int dist){
            this.x = x;
            this.y = y;
            this.dist = dist;
        } 
    } 
    public int knight(int A, int B, int C, int D, int E, int F) {
        int[] dx = { -2, -1, 1, 2, -2, -1, 1, 2 };
        int[] dy = { -1, -2, -2, -1, 1, 2, 2, 1 };
        
        bool[,] visited = new bool[A,B];
        cell c = new cell(C-1,D-1,0);
        Queue<cell> q = new Queue<cell>();
        q.Enqueue(c);
        visited[c.x,c.y] = true;
        while(q.Count!=0){
            
            cell ce = q.Dequeue();
            if(ce.x == E-1 && ce.y==F-1){
                return ce.dist;
            }
            for(int i=0;i<8;i++){ 
              int m = ce.x+dx[i];
              int n = ce.y+dy[i];
              if(isValid(m,n,A,B) && !visited[m,n]){ 
                  visited[m,n] = true;
                  cell newcell = new cell(m,n,ce.dist+1);
                  q.Enqueue(newcell);
              }  
            } 
        }
        return -1;
    } 
    private bool isValid(int x,int y,int A,int B){
        
        if(x>=0 && y>=0 && x<A && y<B){
            return true;
        }
        return false;
    } 
}
    

