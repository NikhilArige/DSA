/*
Design a data structure to store the strings' count with the ability to return the strings with minimum and maximum counts.
Implement the AllOne class:
AllOne() Initializes the object of the data structure.
inc(String key) Increments the count of the string key by 1. If key does not exist in the data structure, insert it with count 1.
dec(String key) Decrements the count of the string key by 1. If the count of key is 0 after the decrement, remove it from the data structure. It is guaranteed that key exists in the data structure before the decrement.
getMaxKey() Returns one of the keys with the maximal count. If no element exists, return an empty string "".
getMinKey() Returns one of the keys with the minimum count. If no element exists, return an empty string "".
Example 1:
Input
["AllOne", "inc", "inc", "getMaxKey", "getMinKey", "inc", "getMaxKey", "getMinKey"]
[[], ["hello"], ["hello"], [], [], ["leet"], [], []]
Output
[null, null, null, "hello", "hello", null, "hello", "leet"]
Explanation
AllOne allOne = new AllOne();
allOne.inc("hello");
allOne.inc("hello");
allOne.getMaxKey(); // return "hello"
allOne.getMinKey(); // return "hello"
allOne.inc("leet");
allOne.getMaxKey(); // return "hello"
allOne.getMinKey(); // return "leet"
Constraints:
1 <= key.length <= 10
key consists of lowercase English letters.
It is guaranteed that for each call to dec, key is existing in the data structure.
At most 5 * 104 calls will be made to inc, dec, getMaxKey, and getMinKey.
*/

public class AllOne {

        Dictionary<int,LinkedList<string>> map;
        Dictionary<string,(int count,LinkedListNode<string> node)> nodes;
        SortedSet<int> count;
    
    public AllOne() {
        map = new  Dictionary<int,LinkedList<string>>();
        nodes = new Dictionary<string,(int count,LinkedListNode<string> node)>();
        count = new SortedSet<int>();
    }
    
    public void Inc(string key) {
        
        if(!nodes.ContainsKey(key)){
            var newnode = new LinkedListNode<string>(key);
            var cnt = 1;
            nodes.Add(key,(cnt,newnode));
            if(!map.ContainsKey(1)){
                map.Add(1,new LinkedList<string>());
            }
            map[1].AddFirst(newnode);
            count.Add(1);
        }
        else{
            var item = nodes[key];
            var curCount = item.count;
            var prevNode = item.node;
            map[curCount].Remove(prevNode);
            if(map[curCount].Count==0){
            map.Remove(curCount);
            count.Remove(curCount);
            }
            var newCount = curCount+1;
            var newnode = new LinkedListNode<string>(key);
            nodes[key] = (newCount,newnode);
            if(!map.ContainsKey(newCount)){
                map.Add(newCount,new LinkedList<string>());
            }
            map[newCount].AddFirst(newnode);
            count.Add(newCount);
        }
    }
    
    public void Dec(string key) {
        
        var item = nodes[key];
        var curCount = item.count;
        var prevNode = item.node; 
        map[curCount].Remove(prevNode);
        if(map[curCount].Count==0){
            map.Remove(curCount);
            count.Remove(curCount);
        }
        if(curCount == 1){
            nodes.Remove(key); 
        } 
        else if(curCount > 1){
            var newCount = curCount-1;
            var newnode = new LinkedListNode<string>(key);
            nodes[key] = (newCount,newnode);
            if(!map.ContainsKey(newCount)){
                map.Add(newCount,new LinkedList<string>());
            }
            map[newCount].AddFirst(newnode);
            count.Add(newCount); 
        }
         
    }
    
    public string GetMaxKey() {
        if(count.Count == 0){
            return "";
        }
        return map[count.Max].Last.Value;
    }
    
    public string GetMinKey() {
        if(count.Count == 0){
            return "";
        }
        return map[count.Min].Last.Value;
    }
}

/**
 * Your AllOne object will be instantiated and called as such:
 * AllOne obj = new AllOne();
 * obj.Inc(key);
 * obj.Dec(key);
 * string param_3 = obj.GetMaxKey();
 * string param_4 = obj.GetMinKey();
 */
