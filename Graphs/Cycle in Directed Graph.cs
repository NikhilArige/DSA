/* Given an directed graph having A nodes. A matrix B of size M x 2 is given which represents the M edges such that there is a edge directed from node B[i][0] to node B[i][1].
Find whether the graph contains a cycle or not, return 1 if cycle is present else return 0.
NOTE:
The cycle must contain atleast two nodes.
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
Output 1:1
Output 2:0
Example Explanation*
Explanation 1:
 The given graph contain cycle 1 -> 3 -> 4 -> 1 or the cycle 1 -> 2 -> 4 -> 1
Explanation 2:
 The given graph doesn't contain any cycle. */
 
 
 
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
        bool[] recStack = new bool[A];
        for(int i=0; i<A; i++){ 
                if(dfs(list,i, visited, recStack)){
                    return true;
                }  
        }
        return false; 
    }
    
     private bool dfs(List<List<int>> list, int i,bool[] visited,bool[] recStack){ 
        
         if (recStack[i]){
            return true;  
         }  
        if (!visited[i]){
             visited[i] = true;  
            recStack[i] = true; 
            List<int> children = list[i]; 
              
            foreach (var c in children){
                if (dfs(list,c, visited, recStack)){
                     return true;  
                }  
            }  
          //marking it false back after coming back           
          recStack[i] = false;
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
        } 
        return result;
    
    } 
    
}


