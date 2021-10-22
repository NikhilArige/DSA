/*
You are given n balloons, indexed from 0 to n - 1. Each balloon is painted with a number on it represented by an array nums. You are asked to burst all the balloons.
If you burst the ith balloon, you will get nums[i - 1] * nums[i] * nums[i + 1] coins. If i - 1 or i + 1 goes out of bounds of the array, 
then treat it as if there is a balloon with a 1 painted on it.
Return the maximum coins you can collect by bursting the balloons wisely.
Example 1:
Input: nums = [3,1,5,8]
Output: 167
Explanation:
nums = [3,1,5,8] --> [3,5,8] --> [3,8] --> [8] --> []
coins =  3*1*5    +   3*5*8   +  1*3*8  + 1*8*1 = 167
Example 2:
Input: nums = [1,5]
Output: 10
*/

public class Solution {
    public int MaxCoins(int[] nums) {
        int n = nums.Length;
        if(n == 0){
            return 0;
        }
        var dp = new int[n,n];
        for(int l=1;l<=n;l++){
            for(int i=0;i<=n-l;i++){
                
                 int j = i + l - 1;
                for (int k = i; k <= j; k++)
                {
                    int leftSum = k - 1 < i ? 0 : dp[i, k - 1];
                    int rightSum = k + 1 > j ? 0 : dp[k + 1, j];

                    int leftNum = i - 1 < 0 ? 1 : nums[i - 1];      
                    int rtNum = j + 1 >= n ? 1 : nums[j + 1];        

                    dp[i, j] = Math.Max(dp[i, j], leftSum + (leftNum * nums[k] * rtNum) + rightSum);
                }
            }
        }
        return dp[0,n-1];
    }
}

/*
intuition
ex: [3,1,5,8]
result =  Math.Max(  
        1*3*1 + somefunc(1,5,8) , 1*1*1 + somefunc(3,5,8) , 1*5*1 + somefunc(3,1,8),1*8*1 + somefunc(3,1,5)
)

*/
