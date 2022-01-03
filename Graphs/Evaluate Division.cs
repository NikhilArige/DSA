/*
You are given an array of variable pairs equations and an array of real numbers values, where equations[i] = [Ai, Bi] and values[i] represent the equation Ai / Bi = values[i]. 
Each Ai or Bi is a string that represents a single variable.
You are also given some queries, where queries[j] = [Cj, Dj] represents the jth query where you must find the answer for Cj / Dj = ?.
Return the answers to all queries. If a single answer cannot be determined, return -1.0.
Note: The input is always valid. You may assume that evaluating the queries will not result in division by zero and that there is no contradiction.
Example 1:
Input: equations = [["a","b"],["b","c"]], values = [2.0,3.0], queries = [["a","c"],["b","a"],["a","e"],["a","a"],["x","x"]]
Output: [6.00000,0.50000,-1.00000,1.00000,-1.00000]
Explanation: 
Given: a / b = 2.0, b / c = 3.0
queries are: a / c = ?, b / a = ?, a / e = ?, a / a = ?, x / x = ?
return: [6.0, 0.5, -1.0, 1.0, -1.0 ]
Example 2:
Input: equations = [["a","b"],["b","c"],["bc","cd"]], values = [1.5,2.5,5.0], queries = [["a","c"],["c","b"],["bc","cd"],["cd","bc"]]
Output: [3.75000,0.40000,5.00000,0.20000]
Example 3:
Input: equations = [["a","b"]], values = [0.5], queries = [["a","b"],["b","a"],["a","c"],["x","y"]]
Output: [0.50000,2.00000,-1.00000,-1.00000]
*/

public class Solution {
    Dictionary<string,List<(string divisor,double quot)>> map;
    public double[] CalcEquation(IList<IList<string>> equations, double[] values, IList<IList<string>> queries) {
        
        map = new Dictionary<string,List<(string divisor,double quot)>>();
        for(int i=0;i<equations.Count;i++)
        {
            map.TryAdd(equations[i][0],new List<(string divisor,double quot)>());
            map.TryAdd(equations[i][1],new List<(string divisor,double quot)>());
            map[equations[i][0]].Add((equations[i][1],values[i]));
            map[equations[i][1]].Add((equations[i][0],1/values[i]));
        }
        
        var list = new List<double>();
        foreach(var item in queries){
            
            var val1 = item[0];
            var val2 = item[1];
            if(!map.ContainsKey(val1) || !map.ContainsKey(val2))
            {
                list.Add(-1);
                continue;
            }
            
            list.Add(DFS(item[0],item[1],1,new HashSet<string>()));
        }
        return list.ToArray();
    }
    
    double DFS(string start,string end,double prod,HashSet<string> visited)
    {
        visited.Add(start);
        if(start == end)
        {
            return prod;
        }
        foreach(var item in map[start])
        {
            if(!visited.Contains(item.divisor))
            {
                var res = DFS(item.divisor,end,prod * item.quot,visited);
                if(res >=0){
                   return res; 
                }
            }
        }
        return -1;
    }
}
