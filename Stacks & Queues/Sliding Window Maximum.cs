/* Given an array of integers A. There is a sliding window of size B which
is moving from the very left of the array to the very right.
You can only see the w numbers in the window. Each time the sliding window moves
rightwards by one position. You have to find the maximum for each window.
The following example will give you more clarity.
The array A is [1 3 -1 -3 5 3 6 7], and B is 3.
Window position	Max
———————————-	————————-
[1 3 -1] -3 5 3 6 7	3
1 [3 -1 -3] 5 3 6 7	3
1 3 [-1 -3 5] 3 6 7	5
1 3 -1 [-3 5 3] 6 7	5
1 3 -1 -3 [5 3 6] 7	6
1 3 -1 -3 5 [3 6 7]	7
Return an array C, where C[i] is the maximum value of from A[i] to A[i+B-1].

Note: If B > length of the array, return 1 element with the max of the array. */

using System;
using System.Collections.Generic;
using System.Linq;
class Solution {
    public List<int> slidingMaximum(List<int> arr, int k) {
        
         int n = arr.Count; 
           
         List<int> Qi = new List<int>();
         List<int> res = new List<int>(); 
         //for First Window
        int i;
        for (i = 0; i < k; ++i) {
            // For every element, the previous smaller elements are useless so
            // remove them from Qi
            while (Qi.Any() && arr[i] >= arr[Qi[Qi.Count-1]]){
                 
                // Removing from last
                Qi.RemoveAt(Qi.Count-1);
            }
                
            // Adding new element at rear of queue
            Qi.Insert(Qi.Count,i);
        }
  
        // Process rest of the elements, 
        // i.e., from arr[k] to arr[n-1]
        for (; i < n; ++i) 
        {
            // The element at the front of 
            // the queue is the largest element of
            // previous window, so print it
            res.Add(arr[Qi[0]]);
  
            // Remove the elements which are out of this window
            while ((Qi.Count != 0) && Qi[0] <= i - k){
                 Qi.RemoveAt(0);
            }
                
            // Remove all elements smaller 
            // than the currently
            // being added element (remove 
            // useless elements)
            while ((Qi.Count != 0) && arr[i] >=  arr[Qi[Qi.Count - 1]]){
                Qi.RemoveAt(Qi.Count - 1);
            } 
            // Add current element at the rear of Qi
            Qi.Insert(Qi.Count, i);
        }
  
        // Adding maximum element of last window
        res.Add(arr[Qi[0]]);
        
        return res;
    }
}
