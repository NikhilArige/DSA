/*
You are given an array points representing integer coordinates of some points on a 2D-plane, where points[i] = [xi, yi].
The cost of connecting two points [xi, yi] and [xj, yj] is the manhattan distance between them: |xi - xj| + |yi - yj|, where |val| denotes the absolute value of val.
Return the minimum cost to make all points connected. All points are connected if there is exactly one simple path between any two points.
Example 1:
Input: points = [[0,0],[2,2],[3,10],[5,2],[7,0]]
Output: 20
Explanation:
We can connect the points as shown above to get the minimum cost of 20.
Notice that there is a unique path between every pair of points.
Example 2:
Input: points = [[3,12],[-2,5],[-4,1]]
Output: 18
Example 3:
Input: points = [[0,0],[1,1],[1,0],[-1,1]]
Output: 4
Example 4:
Input: points = [[-1000000,-1000000],[1000000,1000000]]
Output: 4000000
Example 5:
Input: points = [[0,0]]
Output: 0
Constraints:
1 <= points.length <= 1000
-106 <= xi, yi <= 106
All pairs (xi, yi) are distinct.
*/

public class Solution {
    public int MinCostConnectPoints(int[][] points) {
        
        int cost =  0 ;
        
        var list = new List<int[]>();
        
        for(int i=0;i<points.Length;i++){
            for(int j=i+1;j<points.Length;j++){
                
                int dis = Math.Abs(points[i][0]-points[j][0])+Math.Abs(points[i][1]-points[j][1]);
                list.Add(new int[]{i,j,dis});
            }
        }
        
        if(list.Count==1){
            return list[0][2];
        }
        
        list.Sort((x,y)=>(x[2]).CompareTo(y[2]));
        
        int[] p = new int[list.Count];
        
         for(int i=0;i<list.Count;i++){
             p[i] = -1;
         }
        
        for(int i=0;i<list.Count;i++){
            
            int a = Find(p,list[i][0]);
            int b = Find(p,list[i][1]);
            //when no cycle is formed
            if(a!=b){
                p[a]= b;
                cost+=list[i][2];
            } 
        }
        return cost;
        
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
