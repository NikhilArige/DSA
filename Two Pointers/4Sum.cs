/*
Given an array nums of n integers, return an array of all the unique quadruplets [nums[a], nums[b], nums[c], nums[d]] such that:
0 <= a, b, c, d < n
a, b, c, and d are distinct.
nums[a] + nums[b] + nums[c] + nums[d] == target
You may return the answer in any order.
Example 1:
Input: nums = [1,0,-1,0,-2,2], target = 0
Output: [[-2,-1,1,2],[-2,0,0,2],[-1,0,0,1]]
Example 2:
Input: nums = [2,2,2,2,2], target = 8
Output: [[2,2,2,2]]
*/
public class Solution {
    public IList<IList<int>> FourSum(int[] nums, int target) {
       
        var res = new List<IList<int>>();
        int n = nums.Length;
        if(n<4){return res;}
        Array.Sort(nums);
        
        for(int a=0;a<n;a++){
            if(a>0 && nums[a]==nums[a-1]){
                continue;
            }
            for(int b=a+1;b<n;b++){
               if(b>a+1 && nums[b]==nums[b-1]){
                continue; 
               }
               int c = b+1,d = n-1; 
               while(c<d){
                   
                    int sum = nums[a] + nums[b] + nums[c] + nums[d];
                    if (sum > target){
                        d--;
                    }
                    else if (sum < target){
                        c++;
                    }
                    else 
                    {
                        res.Add(new List<int>() { nums[a], nums[b], nums[c++], nums[d--]});
                        while (c < d && nums[c - 1] == nums[c]){
                           c++;  
                        }
                    }
               } 
            }
        }
       return res; 
    }
}
