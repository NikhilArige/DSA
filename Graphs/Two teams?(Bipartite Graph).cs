/* There are A people numbered 1 to A in a football academy.
The coach of the academy wants to make two teams (not necessary of equal size) but unfortunately, not all people get along, 
and several refuse to be put on the same team as that of their enemies.
Given a 2-D array B of size M x 2 denoting the enemies i.e B[i][0] and B[i][1] both are enemies of each other.
Return 1 if it possible to make exactly two teams else return 0.
Input 1:
 A = 5
 B = [ [1, 2],
       [2, 3],
       [1, 5],
       [2, 4] ] 
Input 2:
 A = 4
 B = [ [1, 4],
       [3, 1],
       [4, 3],
       [2, 1] ]
Example Output
Output 1: 1 
Output 2: 0 
Example Explanation
Explanation 1:
 We can make two teams [1, 3, 4] and [2, 5].
Explanation 2:
 No possible way to create two teams. So, we need to return 0. */
 
 
 class Solution {
    public int solve(int A, List<List<int>> B) {
        List<List<int>> result = new List<List<int>>();
        for(int i=0;i<A;i++){
            result.Add(new List<int>());
        }
        foreach(var item in B){
            //0-indexing
            result[item[0]-1].Add(item[1]-1);//As bidirectional  
            result[item[1]-1].Add(item[0]-1);
        } 
        int[] visited = new int[A];
        for(int i=0;i<A;i++){
            visited[i] = -1;
        }
    
        for(int i=0; i<A; i++){
            if(visited[i]==-1 && !isbipartite(i,1, visited, result)) {
                return 0;
            }
        }
        return 1; 
    }
    //dfs      //color is taken as 1 or 2
    private bool isbipartite(int par,int colour,int[] visited,List<List<int>> adj){
         
        visited[par]=colour;
        foreach(var item in adj[par]){ 
            // if colour of child is same as that of node return 0
            if(visited[item]==colour){
                return false;
            } 
            // col[child]==-1 means child is not visited
            if(visited[item]==-1 && !isbipartite(item, 3-colour, visited, adj)){
                return false;
            } 
        }
        return true; 
    } 
}
