/*
You have an undirected, connected graph of n nodes labeled from 0 to n - 1.
You are given an array graph where graph[i] is a list of all the nodes connected with node i by an edge.
Return the length of the shortest path that visits every node. You may start and stop at any node, you may revisit nodes multiple times, and you may reuse edges.
Example 1:
Input: graph = [[1,2,3],[0],[0],[0]]
Output: 4
Explanation: One possible path is [1,0,2,0,3]
Example 2:
Input: graph = [[1],[0,2,4],[1,3,4],[2],[1,2]]
Output: 4
Explanation: One possible path is [0,1,4,2,3]
Constraints:
n == graph.length
1 <= n <= 12
0 <= graph[i].length < n
graph[i] does not contain i.
If graph[a] contains b, then graph[b] contains a.
The input graph is always connected.
*/

public class Solution {
    public int ShortestPathLength(int[][] graph) {
     
        int n = graph.Length;
        if(n==1){
            return 0;
        }
        int max = (1 << n) - 1; //if n = 4; (1 << n) => 10000 => (1 << n) -1 = 1111 => visited all nodes
        var queue = new Queue<Node>();
        var map = new HashSet<(int node,int mask)>();
        for(int i=0;i<n;i++){
            var mask = 1<<i;
            var node = new Node(i,0,mask);
            queue.Enqueue(node);
            map.Add((i,mask));
        }
        while(queue.Any()){
            var cur = queue.Dequeue();
            foreach(var i in graph[cur.node]){
                var newmask = cur.mask | (1 << i) ;  // 1000 | 0100 => 1100
                if(newmask == max){
                    return cur.dist + 1;
                }
                else if(map.Contains((i,newmask))){
                   continue;
                }
                 map.Add((i,newmask));
                queue.Enqueue(new Node(i,cur.dist+1,newmask));
            }
        }
        return 0;
    }
    
    public class Node{
        
        public int node{get;set;}
        public int dist{get;set;}        
        public int mask{get;set;}        
        
        public Node(int n,int d,int m){
            node = n;
            dist = d;
            mask = m;
        }
    }
}
