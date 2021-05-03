/*Given an undirected graph having A nodes labelled from 1 to A with M edges given in a form of matrix B of size M x 2 where (B[i][0], B[i][1]) represents two nodes B[i][0] and B[i][1] connected by an edge.
Find whether the graph contains a cycle or not, return 1 if cycle is present else return 0.
NOTE:
The cycle must contain at least three nodes.
There are no self-loops in the graph.
There are no multiple edges between two nodes.
The graph may or may not be connected.
Nodes are numbered from 1 to A.
Your solution will run on multiple test cases. If you are using global variables make sure to clear them.
Example Input
Input 1:
 A = 5
 B = [  [1. 2]
        [1, 3]
        [2, 3]
        [1, 4]
        [4, 5]
     ]
Input 2:
 A = 3
 B = [  [1. 2]
        [1, 3]
     ]
Example Output
Output 1:1
Output 2:0
Example Explanation*
Explanation 1:
 There is a cycle in the graph i.e 1 -> 2 -> 3 -> 1 so we will return 1
Explanation 2:
 No cycle present in the graph so we will return 0. */

class Solution {
    public int solve(int A, List<List<int>> B) {
         List<List<int>> list = GetAdjacencyList(A,B); 
         if(isCycle(A,list)){
                return 1;
            }
            else{
               return 0; 
           }
    } 
     private bool isCycle(int A,List<List<int>> list){ 
        
        bool[] visited = new bool[A]; 
        for(int i=0; i<A; i++){ 
            if(!visited[i]){ 
                if(dfs(list,i, visited,-1)){
                    return true;
                }  
            } 
        }
        return false; 
    }
    
   
     private bool dfs(List<List<int>> list, int i,bool[] visited,int parent){ 
          
        visited[i] = true; 
        foreach(var item in list[i])
        { 
            if (!visited[item])
            {
                if (dfs(list,item, visited,i)){
                    return true;
                }  
            } 
            // If an adjacent is visited and not parent of current vertex
            else if (item != parent){
                return true;
            }    
        } 
        return false;  
    } 
    
  
    private List<List<int>> GetAdjacencyList(int A,List<List<int>> B){
        
        List<List<int>> result = new List<List<int>>();
        for(int i=0;i<A;i++){
            result.Add(new List<int>());
        }
        foreach(var item in B){
            //0-indexing
            result[item[0]-1].Add(item[1]-1);
            result[item[1]-1].Add(item[0]-1);
            //
            //As bidirectional 
            //
        } 
        return result;
    
    } 
}

