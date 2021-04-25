/*Given an array A of N non-negative numbers and you are also given non-negative number B.
You need to find the number of subarrays in A having sum less than B. We may assume that there is no overflow.
Input 1:
A = [2, 5, 6]
B = 10
Input 2:
A = [1, 11, 2, 3, 15]
B = 10
Example Output
Output 1:4
Output 2:4
Example Explanation
Explanation 1:The subarrays with sum less than B are {2}, {5}, {6} and {2, 5},
Explanation 2:The subarrays with sum less than B are {1}, {2}, {3} and {2, 3} */


class Solution {
    public int solve(List<int> arr, int k) {
        
        int n = arr.Count;
        int start = 0, end = 0;
        int count = 0, sum = arr[0];
        while (start < n && end < n) {
            if (sum < k) {
                end++;
                if (end >= start){
                    count += end - start;   
                } 
                if (end < n)
                    sum += arr[end];
            }
            else {
                sum -= arr[start];
                start++;
            }
        }
        return count;
    }
}


