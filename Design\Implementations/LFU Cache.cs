/*
Design and implement a data structure for a Least Frequently Used (LFU) cache.
Implement the LFUCache class:
LFUCache(int capacity) Initializes the object with the capacity of the data structure.
int get(int key) Gets the value of the key if the key exists in the cache. Otherwise, returns -1.
void put(int key, int value) Update the value of the key if present, or inserts the key if not already present. When the cache reaches its capacity, 
it should invalidate and remove the least frequently used key before inserting a new item.
For this problem, when there is a tie (i.e., two or more keys with the same frequency), the least recently used key would be invalidated.
To determine the least frequently used key, a use counter is maintained for each key in the cache. The key with the smallest use counter is the least frequently used key.
When a key is first inserted into the cache, its use counter is set to 1 (due to the put operation).
The use counter for a key in the cache is incremented either a get or put operation is called on it.
The functions get and put must each run in O(1) average time complexity.
Example 1:
Input
["LFUCache", "put", "put", "get", "put", "get", "get", "put", "get", "get", "get"]
[[2], [1, 1], [2, 2], [1], [3, 3], [2], [3], [4, 4], [1], [3], [4]]
Output
[null, null, null, 1, null, -1, 3, null, -1, 3, 4]
Explanation
// cnt(x) = the use counter for key x
// cache=[] will show the last used order for tiebreakers (leftmost element is  most recent)
LFUCache lfu = new LFUCache(2);
lfu.put(1, 1);   // cache=[1,_], cnt(1)=1
lfu.put(2, 2);   // cache=[2,1], cnt(2)=1, cnt(1)=1
lfu.get(1);      // return 1
                 // cache=[1,2], cnt(2)=1, cnt(1)=2
lfu.put(3, 3);   // 2 is the LFU key because cnt(2)=1 is the smallest, invalidate 2.
                 // cache=[3,1], cnt(3)=1, cnt(1)=2
lfu.get(2);      // return -1 (not found)
lfu.get(3);      // return 3
                 // cache=[3,1], cnt(3)=2, cnt(1)=2
lfu.put(4, 4);   // Both 1 and 3 have the same cnt, but 1 is LRU, invalidate 1.
                 // cache=[4,3], cnt(4)=1, cnt(3)=2
lfu.get(1);      // return -1 (not found)
lfu.get(3);      // return 3
                 // cache=[3,4], cnt(4)=1, cnt(3)=3
lfu.get(4);      // return 4
                 // cache=[3,4], cnt(4)=2, cnt(3)=3
*/


public class LFUCache {
    
    int cap;
    Dictionary<int,LinkedList<int>> countList;
    Dictionary<int,(int val,int count,LinkedListNode<int> node)> keyCount;
    int minFreq;
    
    public LFUCache(int capacity) {
        cap = capacity;
        countList = new Dictionary<int,LinkedList<int>>();
        keyCount = new Dictionary<int,(int val,int count,LinkedListNode<int> node)>();
        minFreq = 0;
    }
    
    public int Get(int key) {
        
        if(!keyCount.ContainsKey(key)){
            return -1;
        }
        else{
            var val = keyCount[key].val;
            Update(key,val);
            return val;
        } 
    }
    
    public void Put(int key, int value) {
        
        if (cap < 1)
        {
            return;
        }
        
        if(!keyCount.ContainsKey(key)){
            
            if(keyCount.Count >= cap){
                var minNode  = countList[minFreq].Last;
                keyCount.Remove(minNode.Value);
                countList[minFreq].Remove(minNode);
                if(countList[minFreq].Count == 0){
                    countList.Remove(minFreq);
                }
            }
            minFreq = 1;
            int count = 1;
            var newnode = new LinkedListNode<int>(key);
            var cur = (value,count,newnode);
            keyCount.Add(key,cur);
            if(!countList.ContainsKey(count)){
                countList.Add(count,new LinkedList<int>());
            }
            countList[count].AddFirst(newnode);
        }
        else{
            Update(key,value);
        }
    }
    
    void Update(int key,int val){ 
        var item = keyCount[key];
        var count = item.count;
        var curnode = item.node;
        countList[count].Remove(curnode);
        if (countList[count].Count == 0)
        {
            if (minFreq == count)
            {
                minFreq++;
            }
            countList.Remove(count);
        }
        var newnode = new LinkedListNode<int>(key);
        var newitem = (val,count+1,newnode);
        keyCount[key] = newitem;
        if (!countList.ContainsKey(count + 1))
        {
            countList[count + 1] = new LinkedList<int>();
        }
        countList[count + 1].AddFirst(newnode);
    }
}

/**
 * Your LFUCache object will be instantiated and called as such:
 * LFUCache obj = new LFUCache(capacity);
 * int param_1 = obj.Get(key);
 * obj.Put(key,value);
 */
