/*
Given a sorted integer array arr, two integers k and x, return the k closest integers to x in the array. The result should also be sorted in ascending order.
An integer a is closer to x than an integer b if:
|a - x| < |b - x|, or
|a - x| == |b - x| and a < b
Example 1:
Input: arr = [1,2,3,4,5], k = 4, x = 3
Output: [1,2,3,4]
Example 2:
Input: arr = [1,2,3,4,5], k = 4, x = -1
Output: [1,2,3,4]
*/

public class Solution {
    public IList<int> FindClosestElements(int[] arr, int k, int x) {
        List<int> result = new List<int>();
        int left = 0;
        int right = arr.Length - k;
        while (left < right)
        {
            int mid = left + (right - left) / 2;
            if (x - arr[mid] > arr[mid + k] - x)
            {
                left = mid + 1;
            }
            else
            {
                right = mid;
            }
        }
        for (int i = left; i < left + k; i++)
        {
            result.Add(arr[i]);
        }
        return result;
    }
}
