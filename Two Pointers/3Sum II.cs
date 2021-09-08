/* 
Given an integer array nums, return all the triplets [nums[i], nums[j], nums[k]] such that i != j, i != k, and j != k, and nums[i] + nums[j] + nums[k] == 0.
Notice that the solution set must not contain duplicate triplets.
Example 1:
Input: nums = [-1,0,1,2,-1,-4]
Output: [[-1,-1,2],[-1,0,1]]
Example 2:
Input: nums = []
Output: []
Example 3:
Input: nums = [0]
Output: []
*/

public class Solution {
    public IList<IList<int>> ThreeSum(int[] A) {
        int n = A.Length;
        Array.Sort(A);
       
        var result = new List<IList<int>>();
        
        for(int i=0;i<n;i++){
            int cur = A[i];
            if (i > 0 && A[i - 1] == A[i]){
                  continue;          //to avoid dupicates
            } 
             int left = i+1;
             int right = n-1;
            while(left<right){
                int sum = A[left]+A[right]+cur;
                if(sum > 0){
                    right--;
                }
                else if(sum < 0){
                    left++;
                }
                else{
                    result.Add(new List<int>{cur,A[left],A[right]});
                    left++;
                    right--;
                    
                    while(left<right && A[left-1]==A[left]){
                         left++;
                    }
                }
            }
        }
        
        return result;
    }
}
