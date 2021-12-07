/*
The string "PAYPALISHIRING" is written in a zigzag pattern on a given number of rows like this: (you may want to display this pattern in a fixed font for better legibility)
P   A   H   N
A P L S I I G
Y   I   R
And then read line by line: "PAHNAPLSIIGYIR"
Write the code that will take a string and make this conversion given a number of rows:
string convert(string s, int numRows);
Example 1:
Input: s = "PAYPALISHIRING", numRows = 3
Output: "PAHNAPLSIIGYIR"
Example 2:
Input: s = "PAYPALISHIRING", numRows = 4
Output: "PINALSIGYAHRPI"
Explanation:
P     I    N
A   L S  I G
Y A   H R
P     I
Example 3:
Input: s = "A", numRows = 1
Output: "A"
*/

public class Solution {
    public string Convert(string s, int numRows) {
        
        if(numRows == 1)
        {
            return s;
        }
        var res = new List<StringBuilder>();
        for(int i=0;i<numRows;i++)
        {
            res.Add(new StringBuilder());
        }
        int row = -1;
        bool isDown = true;
        for(int i=0;i<s.Length;i++){
            if(isDown){
                row++;
            }
            else{
                row--;
            }
            res[row].Append(s[i]);
            if(row==0){
                isDown = true;
            }
            if(row==numRows-1){
                isDown = false;
            }
        }
        string st = "";
        foreach(var item in res){
            st+= item.ToString();
        }
        return st;            
    }
}
