/*
You are given a list of songs where the ith song has a duration of time[i] seconds.
Return the number of pairs of songs for which their total duration in seconds is divisible by 60. 
Formally, we want the number of indices i, j such that i < j with (time[i] + time[j]) % 60 == 0.
Example 1:
Input: time = [30,20,150,100,40]
Output: 3
Explanation: Three pairs have a total duration divisible by 60:
(time[0] = 30, time[2] = 150): total duration 180
(time[1] = 20, time[3] = 100): total duration 120
(time[1] = 20, time[4] = 40): total duration 60
Example 2:
Input: time = [60,60,60]
Output: 3
Explanation: All three pairs have a total duration of 120, which is divisible by 60.
*/

public class Solution {
    public int NumPairsDivisibleBy60(int[] time) {
        
        int cnt = 0;
        var arr = new int[60];
        
         for(int i=0;i<time.Length;i++){ 
             var mod = time[i] % 60; 
             cnt += arr[(mod == 0)? 0 : 60-mod];  
             arr[mod]++;   
        }
        
        
//         int cnt = 0;
//         for(int i=0;i<time.Length;i++){
//             for(int j=i+1;j<time.Length;j++){
//                 if((time[i]+time[j])%60 == 0){
//                     cnt++;
//                 }
//             }
//         }
        
        return cnt;
    }
}
