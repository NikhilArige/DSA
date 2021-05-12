/*Given an array of points where points[i] = [xi, yi] represents a point on the X-Y plane, return the maximum number of points that lie on the same straight line.
Example 1:
Input: points = [[1,1],[2,2],[3,3]]
Output: 3 */


public class Solution {
    public int MaxPoints(int[][] points) {
        
        var map = new  Dictionary<int,Dictionary<int,int>>();
        
         int result = 0;

         for (int i = 0; i < points.GetLength(0); i++) { 
             
                map.Clear();
                int overlap = 0;
                int max = 0;
             
             for(int j=i+1;j<points.GetLength(0);j++){
                  
                int x = points[j][0] - points[i][0];
                int y = points[j][1] - points[i][1];
                
                if (x == 0 && y == 0) {
                    overlap++;
                    continue;
                }
                 
                int gcd = GCD(x,y); 
                  
                if (gcd != 0) {
                    x /= gcd;
                    y /= gcd;
                }
                 
                 if(map.ContainsKey(x)){
                     
                     if(map[x].ContainsKey(y)){
                         map[x][y]++;
                     }
                     else{
                         map[x].Add(y,1);
                     } 
                 }
                 else{
                     var m = new Dictionary<int,int>();
                     m.Add(y,1);
                     map.Add(x,m);
                 }
                 
                 max = Math.Max(max,map[x][y]);  
             }
            // + 1 to consider current point in consideration
             result = Math.Max(result,max + overlap+ 1);
         }
        return result;
    }
        
        private int GCD(int a, int b) {
            if (b == 0){
                return a;
            } 

            return GCD(b,a%b);
    }
}


