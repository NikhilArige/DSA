/*There is a rectangle with left bottom as  (0, 0) and right up as (x, y). There are N circles such that their centers are inside the rectangle.
Radius of each circle is R. Now we need to find out if it is possible that we can move from (0, 0) to (x, y) without touching any circle.
Note : We can move from any cell to any of its 8 adjecent neighbours and we cannot move outside the boundary of the rectangle at any point of time.
Input:
    x = 2
    y = 3
    N = 1
    R = 1
    A = [2]
    B = [3]
Output:
    NO   
Explanation:
    There is NO valid path in this case */
    
class Solution {
    public string solve(int A, int B, int nofC, int r, List<int> E, List<int> F) {
        
        int[,] rect = new int[A+1,B+1];
        for(int i=0;i<=A;i++){
            for(int j=0;j<=B;j++){
                rect[i,j] = 0;
            }
        } 
        for (int i = 0; i <=A; i++) {
            for (int j = 0; j <=B; j++) {
                for (int p = 0; p < nofC; p++) {
                    if (Math.Sqrt((Math.Pow((E[p]-i),2)+Math.Pow((F[p]-j),2)))<= r){
                        rect[i,j] = -1;
                    }
                }
            }
        } 
        if(rect[0,0]==-1 || rect[A,B]==-1){
            return "NO";
        }
        
        // for(int i=0;i<=A;i++){
        //     for(int j=0;j<=B;j++){
        //         if(rect[i,j]!=-1 && rect[i,j]!=1){
        //             dfs(i,j,rect); 
        //         }
        //     }  
        // }   
        //only from 0  
        dfs(0,0,rect); 
          
        if(rect[A,B]==1){
            return "YES";
        }
        else{
            
        return "NO";
        }
    }
    
    private void dfs(int i,int j,int[,] rect){
        
        if(i<0 || j<0 || i>=rect.GetLength(0) || j>=rect.GetLength(1) ||
          rect[i,j]==-1 || rect[i,j]==1){
            return;
        } 
        rect[i,j] = 1;
        dfs(i,j+1,rect);
        dfs(i,j-1,rect);
        dfs(i+1,j,rect);
        dfs(i-1,j,rect);
        dfs(i+1,j+1,rect);
        dfs(i-1,j-1,rect);
        dfs(i+1,j-1,rect);
        dfs(i-1,j+1,rect); 
    }  
}
