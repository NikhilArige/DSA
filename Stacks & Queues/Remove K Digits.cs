/*
Given string num representing a non-negative integer num, and an integer k, return the smallest possible integer after removing k digits from num.
Example 1:
Input: num = "1432219", k = 3
Output: "1219"
Explanation: Remove the three digits 4, 3, and 2 to form the new number 1219 which is the smallest.
Example 2:
Input: num = "10200", k = 1
Output: "200"
Explanation: Remove the leading 1 and the number is 200. Note that the output must not contain leading zeroes.
Example 3:
Input: num = "10", k = 2
Output: "0"
Explanation: Remove all the digits from the number and it is left with nothing which is 0.
*/

public class Solution {
    public string RemoveKdigits(string num, int k) { 
        var n = num.Length;
        if(n==k){return "0";}
        int i=0;
        var st = new Stack<char>();
        while(i<n){
            while(k>0 && st.Count>0 && st.Peek() > num[i]){
                st.Pop();
                k--;
            }
            st.Push(num[i]);
            i++; 
        }
        while (k-- > 0){
            st.Pop();
        }
        var chararray = st.ToArray();
        Array.Reverse(chararray);
        var res = new string(chararray);
        res = res.TrimStart('0');
         return (res != string.Empty) ? res : "0";
    }
}
