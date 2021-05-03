/*Clone an undirected graph. Each node in the graph contains a label and a list of its neighbors. */

//BFS Approach

/**
 * Definition for undirected graph.
 * class UndirectedGraphNode {
 *     int label;
 *     List<UndirectedGraphNode> neighbors;
 *     UndirectedGraphNode(int x) 
 * { label = x; neighbors = new List<UndirectedGraphNode>(); }
 * };
 */
public class Solution {
    
    public UndirectedGraphNode cloneGraph(UndirectedGraphNode node) {
        Queue<UndirectedGraphNode> queue = new Queue<UndirectedGraphNode>();
        Dictionary<int,UndirectedGraphNode> map = new Dictionary<int,UndirectedGraphNode>();
        
        if(node == null){
            return null;
        }
        queue.Add(node);
        UndirectedGraphNode nodeToReturn = new UndirectedGraphNode(node.label);
        map.Add(nodeToReturn.label,nodeToReturn);
        
        while(queue.Count > 0){
            UndirectedGraphNode head = queue.Dequeue;
            foreach(var neighbor in head.neighbors){
                if(map.ContainsKey(neighbor.label)){
                    map[head.label].neighbors.Add(map[neighbor.label]);
                }
                else{
                    queue.Add(neighbor);
                    UndirectedGraphNode neighborNodeCopy = new UndirectedGraphNode(neighbor.label);
                    map.Add(neighbor.label,neighborNodeCopy);
                    map[head.label].neighbors.Add(neighborNodeCopy); 
                }
            }
        }
        return nodeToReturn;
    }
}


