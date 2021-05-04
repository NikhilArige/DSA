/* Given an directed graph having A nodes labelled from 1 to A containing M edges given by matrix B of size M x 2such that there is a edge directed from node
B[i][0] to node B[i][1].
Find whether a path exists from node 1 to node A.
Return 1 if path exists else return 0.
NOTE:
There are no self-loops in the graph.
There are no multiple edges between two nodes.
The graph may or may not be connected.
Nodes are numbered from 1 to A.
Your solution will run on multiple test cases. If you are using global variables make sure to clear them.
Example Input
Input 1:
 A = 5
 B = [  [1, 2] 
        [4, 1] 
        [2, 4] 
        [3, 4] 
        [5, 2] 
        [1, 3] ]
Input 2:
 A = 5
 B = [  [1, 2]
        [2, 3] 
        [3, 4] 
        [4, 5] ]
Example Output
Output 1: 0
Output 2: 1
Example Explanation*
Explanation 1:
 The given doens't contain any path from node 1 to node 5 so we will return 0.
Explanation 2:
 Path from node1 to node 5 is ( 1 -> 2 -> 3 -> 4 -> 5 ) so we will return 1. */
 
 class Solution {
    public int solve(int A, List<List<int>> B) {
        List<List<int>> list = new List<List<int>>();
        for(int i=0;i<A;i++){
            list.Add(new List<int>());
        }
        foreach(var item in B){
            //0-indexing
            list[item[0]-1].Add(item[1]-1);
        }  
        
        bool[] visited = new bool[A];
        if(dfs(list,0, visited,A)){
                    return 1;
            }
        return 0;
    }
    
    private bool dfs(List<List<int>> list,int i,bool[] visited,int a){
        
        visited[i]= true;
        if(visited[a-1]){
            return true;
        } 
        if(list[i].Count>0){
          foreach(var item in list[i]){
            if(!visited[item]){
               if(dfs(list,item,visited,a)){
                return true;
            } 
            } 
        }  
        } 
        return false;
    }
}
