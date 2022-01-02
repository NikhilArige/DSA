/*
You are given an integer array nums and you have to return a new counts array. 
The counts array has the property where counts[i] is the number of smaller elements to the right of nums[i].
Example 1:
Input: nums = [5,2,6,1]
Output: [2,1,1,0]
Explanation:
To the right of 5 there are 2 smaller elements (2 and 1).
To the right of 2 there is only 1 smaller element (1).
To the right of 6 there is 1 smaller element (1).
To the right of 1 there is 0 smaller element.
Example 2:
Input: nums = [-1]
Output: [0]
Example 3:
Input: nums = [-1,-1]
Output: [0,0]
*/

public class Solution {
    public IList<int> CountSmaller(int[] nums) {
        
        var res = new int[nums.Length];
        var list = new List<int>();
         BSComparer comparer = new BSComparer();
        for(int i=nums.Length-1;i>=0;i--)
        {
           var index = list.BinarySearch(nums[i],comparer);
            if(index<0)
            {
                index = ~index;
            }
            list.Insert(index,nums[i]);
            res[i] = index;
        }
         
        return res;
    }
    
     public class BSComparer : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            if (x == y){
               return 1; 
            }
                 // making x > y, so we will insert to the right
            return x.CompareTo(y);
        }
    }
}
