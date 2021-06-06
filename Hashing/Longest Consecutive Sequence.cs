/* Given an unsorted array of integers nums, return the length of the longest consecutive elements sequence.
You must write an algorithm that runs in O(n) time.
Example 1:
Input: nums = [100,4,200,1,3,2]
Output: 4
Explanation: The longest consecutive elements sequence is [1, 2, 3, 4]. Therefore its length is 4.
Example 2:
Input: nums = [0,3,7,2,5,8,4,6,0,1]
Output: 9 */


public class Solution {
    public int LongestConsecutive(int[] A) {
        
        var set = new HashSet<int>(A);
        int ans = 0;
        for(int i=0;i<A.Length;i++){
            if(!set.Contains(A[i]-1))  //if the current is starting element
            {
                int current = A[i];
                int cnt = 0;
                while(set.Contains(current)){
                    current++;
                    cnt++;
                }
                ans = Math.Max(ans,cnt);
            }
        }
        return ans;
    }
}
