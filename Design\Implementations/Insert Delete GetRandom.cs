/* 
Implement the RandomizedSet class:
RandomizedSet() Initializes the RandomizedSet object.
bool insert(int val) Inserts an item val into the set if not present. Returns true if the item was not present, false otherwise.
bool remove(int val) Removes an item val from the set if present. Returns true if the item was present, false otherwise.
int getRandom() Returns a random element from the current set of elements (it's guaranteed that at least one element exists when this method is called). 
Each element must have the same probability of being returned.
You must implement the functions of the class such that each function works in average O(1) time complexity.
Example 1:
Input
["RandomizedSet", "insert", "remove", "insert", "getRandom", "remove", "insert", "getRandom"]
[[], [1], [2], [2], [], [1], [2], []]
Output
[null, true, false, true, 2, true, false, 2]
Explanation
RandomizedSet randomizedSet = new RandomizedSet();
randomizedSet.insert(1); // Inserts 1 to the set. Returns true as 1 was inserted successfully.
randomizedSet.remove(2); // Returns false as 2 does not exist in the set.
randomizedSet.insert(2); // Inserts 2 to the set, returns true. Set now contains [1,2].
randomizedSet.getRandom(); // getRandom() should return either 1 or 2 randomly.
randomizedSet.remove(1); // Removes 1 from the set, returns true. Set now contains [2].
randomizedSet.insert(2); // 2 was already in the set, so return false.
randomizedSet.getRandom(); // Since 2 is the only number in the set, getRandom() will always return 2. */


 public class RandomizedSet {
    
    private readonly Dictionary<int, int> valueSet;
    private readonly Random generator;
    private readonly IList<int> list;

    /** Initialize your data structure here. */
    public RandomizedSet() {
        valueSet = new Dictionary<int, int>();
        generator = new Random();
        list = new List<int>();
    }
    
    /** Inserts a value to the set. Returns true if the set did not already contain the specified element. */
    public bool Insert(int val) {
        if (valueSet.ContainsKey(val))
        {
            return false;
        }
        
        list.Add(val);
        valueSet.Add(val, list.Count - 1);
        return true;
    }
    
    /** Removes a value from the set. Returns true if the set contained the specified element. */
    public bool Remove(int val) {
        if (valueSet.TryGetValue(val, out var index))
        {
            (list[index], list[list.Count - 1]) = (list[list.Count - 1], list[index]); //swapping first and last
            valueSet[list[index]] = index;
            valueSet.Remove(val);
            list.RemoveAt(list.Count - 1);
            return true;
        }
        else
        {
            return false;
        }
    }
    
    /** Get a random element from the set. */
    public int GetRandom() {
         var index = generator.Next(list.Count);
        var val = list[index];
        return val;
    }
}

/**
 * Your RandomizedSet object will be instantiated and called as such:
 * RandomizedSet obj = new RandomizedSet();
 * bool param_1 = obj.Insert(val);
 * bool param_2 = obj.Remove(val);
 * int param_3 = obj.GetRandom();
 */
