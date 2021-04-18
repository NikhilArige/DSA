/*Given a column title A as appears in an Excel sheet, return its corresponding column number.
A  -> 1
B -> 2
C -> 3
...
Z -> 26
AA -> 27
AB -> 28 */


class Solution {
    public int titleToNumber(string A) {
        //if s='AZ' then  s[0]-'A' => 0 ;s[0]-'A' => 25 starts from 0
        int result = 0;
        //result is 0 not 1
        for (int i = 0; i < A.Length; i++)
        {
            result *= 26;
            result += A[i] - 'A' + 1;
            //if s='AZ' then  s[0]-'A' => 0 ;s[0]-'A' => 25 starts from 0
            //so adding 1
        }
        return result; 
    }
}
