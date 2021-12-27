/*
Given two integers representing the numerator and denominator of a fraction, return the fraction in string format.
If the fractional part is repeating, enclose the repeating part in parentheses.
If multiple answers are possible, return any of them.
It is guaranteed that the length of the answer string is less than 104 for all the given inputs.
Example 1:
Input: numerator = 1, denominator = 2
Output: "0.5"
Example 2:
Input: numerator = 2, denominator = 1
Output: "2"
Example 3:
Input: numerator = 4, denominator = 333
Output: "0.(012)"
Constraints:
-231 <= numerator, denominator <= 231 - 1
denominator != 0
*/

public class Solution {
    public string FractionToDecimal(int numerator, int denominator) {
        
        var sb = new StringBuilder();
        var a = (long)numerator;
        var b = (long)denominator;
        if((a<0 && b>0)||(a>0 && b<0))
        {
            sb.Append("-");
        }
         a = Math.Abs(a);
         b = Math.Abs(b);
        sb.Append(a/b);
        var rem = a%b;
        if(rem==0){return sb.ToString();}
        sb.Append(".");
        var map = new Dictionary<long,int>();
        while(rem!=0 && !map.ContainsKey(rem))
        {
            map.Add(rem,sb.Length);
            rem*= 10;
            sb.Append(rem/b);
            rem%=b;
        }
        if(map.ContainsKey(rem))
        {
            sb.Insert(map[rem], "(");
            sb.Append(")");
        }
        return sb.ToString();
    }
}
