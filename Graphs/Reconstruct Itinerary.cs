/*
You are given a list of airline tickets where tickets[i] = [fromi, toi] represent the departure and the arrival airports of one flight. 
Reconstruct the itinerary in order and return it.
All of the tickets belong to a man who departs from "JFK", thus, the itinerary must begin with "JFK". 
If there are multiple valid itineraries, you should return the itinerary that has the smallest lexical order when read as a single string.
For example, the itinerary ["JFK", "LGA"] has a smaller lexical order than ["JFK", "LGB"].
You may assume all tickets form at least one valid itinerary. You must use all the tickets once and only once.
Example 1:
Input: tickets = [["MUC","LHR"],["JFK","MUC"],["SFO","SJC"],["LHR","SFO"]]
Output: ["JFK","MUC","LHR","SFO","SJC"]
Example 2:
Input: tickets = [["JFK","SFO"],["JFK","ATL"],["SFO","ATL"],["ATL","JFK"],["ATL","SFO"]]
Output: ["JFK","ATL","JFK","SFO","ATL","SFO"]
Explanation: Another possible reconstruction is ["JFK","SFO","ATL","JFK","ATL","SFO"] but it is larger in lexical order.
*/

public class Solution {
    public IList<string> FindItinerary(IList<IList<string>> tickets) {
        
        var map = new Dictionary<string,List<string>>();
        foreach(var item in tickets){
            
            if(!map.ContainsKey(item[0])){
                map.Add(item[0],new List<string>());
            }
            if(!map.ContainsKey(item[1])){
                map.Add(item[1],new List<string>());
            }
            map[item[0]].Add(item[1]);
        }
        foreach(var item in map){
            item.Value.Sort();
        }
        var res = new LinkedList<string>();
        DFS(res,"JFK",map);
        return res.ToList();
    }
    
    void DFS(LinkedList<string> res,string airport,Dictionary<string,List<string>> map){
        
        while(map[airport].Count>0){
            var nextport = map[airport][0];
            map[airport].RemoveAt(0);
            DFS(res,nextport,map);
        }
        
        res.AddFirst(airport);
    }
}
