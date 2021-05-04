/*There are a total of A courses you have to take, labeled from 1 to A.
Some courses may have prerequisites, for example to take course 2 you have to first take course 1, which is expressed as a pair: [1,2].
Given the total number of courses and a list of prerequisite pairs, is it possible for you to finish all courses?
Return 1 if it is possible to finish all the courses, or 0 if it is not possible to finish all the courses.
Input Format:
The first argument of input contains an integer A, representing the number of courses.
The second argument of input contains an integer array, B.
The third argument of input contains an integer array, C.
Output Format:
Return a boolean value:
    1 : If it is possible to complete all the courses.
    0 : If it is not possible to complete all the courses.
Input 1:
    A = 3
    B = [1, 2]
    C = [2, 3]
Output 1:1
Explanation 1:
    It is possible to complete the courses in the following order:
        1 -> 2 -> 3
Input 2:
    A = 2
    B = [1, 2]
    C = [2, 1]
Output 2:0
Explanation 2:
    It is not possible to complete all the courses. */
    
//finding cycle in a directed graph
class Solution {
    public int solve(int A, List<int> B, List<int> C) {
        List<List<int>> list = GetAdjacencyList(A,B,C); 
         if(isCycle(A,list)){
                return 0;  //if cycle exists, its not possible
            }
            else{
               return 1; 
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
    
    
    private List<List<int>> GetAdjacencyList(int A,List<int> B,List<int> C){
        
        List<List<int>> result = new List<List<int>>();
        for(int i=0;i<A;i++){
            result.Add(new List<int>());
        }
        for(int i=0;i<B.Count;i++){
            //0-indexing
            result[B[i]-1].Add(C[i]-1);
        } 
        return result;
    
    } 
}
