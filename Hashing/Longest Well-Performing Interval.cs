/*
We are given hours, a list of the number of hours worked per day for a given employee.
A day is considered to be a tiring day if and only if the number of hours worked is (strictly) greater than 8.
A well-performing interval is an interval of days for which the number of tiring days is strictly larger than the number of non-tiring days.
Return the length of the longest well-performing interval.
Example 1:
Input: hours = [9,9,6,0,6,6,9]
Output: 3
Explanation: The longest well-performing interval is [9,9,6].
Example 2:
Input: hours = [6,6,6]
Output: 0
*/

public class Solution {
    public int LongestWPI(int[] hours) {
        
        int res = 0,sum = 0;
        var map = new Dictionary<int,int>();
        for(int i=0;i<hours.Length;i++){
            
            var val = hours[i] > 8 ? 1 : -1;
            sum += val;
            if(sum >= 1){
                res = i+1;
            }
            else{
                if(!map.ContainsKey(sum)){
                    map.Add(sum,i);
                }
                if(map.ContainsKey(sum - 1)){
                    res = Math.Max(res,i - map[sum-1]);
                }
            }
            
        }
        return res;
    }
}
