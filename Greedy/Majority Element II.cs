/*
Given an integer array of size n, find all elements that appear more than ⌊ n/3 ⌋ times.
Example 1:
Input: nums = [3,2,3]
Output: [3]
Example 2:
Input: nums = [1]
Output: [1]
Example 3:
Input: nums = [1,2]
Output: [1,2]
*/

public class Solution {
    public IList<int> MajorityElement(int[] nums) {
        
        int n = nums.Length;
        int ind1 = -1,ind2 = -1;
        int c1 = 1,c2 = 1;
        for(int i=0;i<n;i++){
            var num = nums[i]; 
            if(ind1 == -1){
                ind1 = i;
                c1 = 1;
            }
            else if(ind2 == -1 && num!=nums[ind1]){
                ind2 = i;
                c2 = 1;
            }
            else if(ind1 != -1 && num == nums[ind1]){
                c1++;
            }
            else if(ind2 != -1 && num == nums[ind2]){
                c2++;
            }
            else if(c1 == 0){
                c1 = 1;
                ind1 = i;
            }
            else if(c2 == 0){
                c2 = 1;
                ind2 = i;
            }
            else{
                c1--;
                c2--;
            }
        }
        var list = new List<int>();
        int cnt1 = 0,cnt2 = 0;
        for(int i=0;i<n;i++){
            if(ind1 != -1 && nums[i] == nums[ind1]){
                cnt1++;
            }
            if(ind2 != -1 && nums[i] == nums[ind2]){
                cnt2++;
            }
        }
        if(cnt1 > n/3){
            list.Add(nums[ind1]);
        }
        if(cnt2 > n/3){
            list.Add(nums[ind2]);
        }
        return list;
    }
}
