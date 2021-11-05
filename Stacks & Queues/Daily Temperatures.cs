/*
Given an array of integers temperatures represents the daily temperatures, 
return an array answer such that answer[i] is the number of days you have to wait after the ith day to get a warmer temperature.
If there is no future day for which this is possible, keep answer[i] == 0 instead.
Example 1:
Input: temperatures = [73,74,75,71,69,72,76,73]
Output: [1,1,4,2,1,1,0,0]
Example 2:
Input: temperatures = [30,40,50,60]
Output: [1,1,1,0]
Example 3:
Input: temperatures = [30,60,90]
Output: [1,1,0]
*/

public class Solution {
    public int[] DailyTemperatures(int[] t) {
        
        var res = new int[t.Length];
        var st = new Stack<int>();
        for(int i=t.Length-1;i>=0;i--){
            
            while(st.Count>0 && t[st.Peek()]<=t[i]){
                st.Pop();
            }
            res[i] = st.Count>0 ? st.Peek()-i : 0;
            st.Push(i);
        }
        return res;        
    }
}
