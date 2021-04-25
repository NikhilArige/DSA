/*Given a string A representating json object. Return an array of string denoting json object with proper indentaion.
Rules for proper indentaion:
Every inner brace should increase one indentation to the following lines.
Every close brace should decrease one indentation to the same line and the following lines.
The indents can be increased with an additional ‘\t’
Note:
[] and {} are only acceptable braces in this case.
Assume for this problem that space characters can be done away with.
Input Format
The only argument given is the integer array A.
Output Format
Return a list of strings, where each entry corresponds to a single line. The strings should not have "\n" character in them.
For Example
Input 1:
    A = "{A:"B",C:{D:"E",F:{G:"H",I:"J"}}}"
Output 1:
    { 
        A:"B",
        C: 
        { 
            D:"E",
            F: 
            { 
                G:"H",
                I:"J"
            } 
        } 
    }

Input 2:
    A = ["foo", {"bar":["baz",null,1.0,2]}]
Output 2:
   [
        "foo", 
        {
            "bar":
            [
                "baz", 
                null, 
                1.0, 
                2
            ]
        }
    ] */


using System;
using System.Text;
using System.Collections.Generic;					
public class Solution {
    public List<string> prettyJSON(string A) {
     List<string> result = new List<string>();
        if (A == null || A.Length == 0) return result;
        StringBuilder sb = new StringBuilder();
        int brackets = 0; 
        for (int i = 0; i < A.Length; i ++) {
           char c = A[i];
           if (c == ' ')
           continue;
           sb.Append(c);
           if (c == ',' || c == '{' || c == '[' || c == '}' || c == ']') {
                if (c == '{' || c == '[') {
                    addTab(sb, brackets);
                    brackets ++;
                }
                else if (c == '}' || c == ']') {
                    brackets --;
                    addTab(sb, brackets);
                    if (i + 1 < A.Length) {
                        char n = A[i+1];
                        if (n == ',') {
                            sb.Append(n);
                            i++;
                        }
                    }
                }
                else {
                    addTab(sb, brackets);
                }
                result.Add(sb.ToString());
                sb.Length = 0;
            } 
            else if (i + 1 < A.Length) {
                char n = A[i+1];
                if (n == '{' || n == '[' || n == '}' || n == ']') {
                    addTab(sb, brackets);
                    result.Add(sb.ToString());
                    sb.Length =0;
               }
            } 
        }
        return result;
    }
    
    private void addTab(StringBuilder sb, int noOfBrackets) {
        for (int i = 0; i < noOfBrackets; i ++) {
            sb.Insert(0,'\t');
        }
    }
}
