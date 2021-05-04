/*There are A islands and there are M bridges connecting them. Each bridge has some cost attached to it.
We need to find bridges with minimal cost such that all islands are connected.
It is guaranteed that input data will contain at least one possible scenario in which all islands are connected with each other.
Input Format:
The first argument contains an integer, A, representing the number of islands.
The second argument contains an 2-d integer matrix, B, of size M x 3:
    => Island B[i][0] and B[i][1] are connected using a bridge of cost B[i][2].
Output Format:
Return an integer representing the minimal cost required.
Input 1:
    A = 4
    B = [   [1, 2, 1]
            [2, 3, 4]
            [1, 4, 3]
            [4, 3, 2]
            [1, 3, 10]  ]
Output 1: 6
Explanation 1:
    We can choose bridges (1, 2, 1), (1, 4, 3) and (4, 3, 2), where the total cost incurred will be (1 + 3 + 2) = 6.
Input 2:
    A = 4
    B = [   [1, 2, 1]
            [2, 3, 2]
            [3, 4, 4]
            [1, 4, 3]   ]
Output 2:6
Explanation 2:
    We can choose bridges (1, 2, 1), (2, 3, 2) and (1, 4, 3), where the total cost incurred will be (1 + 2 + 3) = 6. */
    
    
using System.Linq;
//Kruskal's Algo
class Solution {
    public int solve(int A, List<List<int>> B) {
        B=B.OrderBy(x=>x[2]).ToList(); 
         int[] p = new int[A];
         for(int i=0;i<A;i++){
             p[i] = -1;
         }
         int sum = 0;
        for(int i=0;i<B.Count;i++){
            
            int a = Find(p,B[i][0]-1);
            int b = Find(p,B[i][1]-1);
            //when no cycle is formed
            if(a!=b){
                p[a]= b;
                sum+=B[i][2];
            } 
        }
        return sum;
    }
    
    private int Find(int[] p,int x){
        
        if(p[x]!=-1){
           int a = Find(p,p[x]);
           p[x] = a;
           return a;
        }
        return x;
    } 
}
