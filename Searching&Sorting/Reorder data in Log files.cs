/*
You are given an array of logs. Each log is a space-delimited string of words, where the first word is the identifier.
There are two types of logs:
Letter-logs: All words (except the identifier) consist of lowercase English letters.
Digit-logs: All words (except the identifier) consist of digits.
Reorder these logs so that:
The letter-logs come before all digit-logs.
The letter-logs are sorted lexicographically by their contents. If their contents are the same, then sort them lexicographically by their identifiers.
The digit-logs maintain their relative ordering.
Return the final order of the logs.
Example 1:
Input: logs = ["dig1 8 1 5 1","let1 art can","dig2 3 6","let2 own kit dig","let3 art zero"]
Output: ["let1 art can","let3 art zero","let2 own kit dig","dig1 8 1 5 1","dig2 3 6"]
Explanation:
The letter-log contents are all different, so their ordering is "art can", "art zero", "own kit dig".
The digit-logs have a relative order of "dig1 8 1 5 1", "dig2 3 6".
Example 2:
Input: logs = ["a1 9 2 3 1","g1 act car","zo4 4 7","ab1 off key dog","a8 act zoo"]
Output: ["g1 act car","a8 act zoo","ab1 off key dog","a1 9 2 3 1","zo4 4 7"]
*/

public class Solution {
    public string[] ReorderLogFiles(string[] logs) {
        
        var dig = new List<string>();
        var letr = new List<string>(); 
        foreach(var item in logs){
            if(Char.IsDigit(item.Split(' ')[1][0])){
                dig.Add(item);
            }
            else{
                letr.Add(item);
            }
        }
        var comp = new Compclass();
        letr.Sort(comp.Compare);
        letr.AddRange(dig); //adding digit-logs after letterlogs are sorted
        return letr.ToArray();        
    }
    
    private class Compclass : IComparer<string>{
        
        public int Compare(string x,string y){
            var log1 = x.Split(new char[] { ' ' }, 2); //splitting into two
            var log2 = y.Split(new char[] { ' ' }, 2);
            var comp = log1[1].CompareTo(log2[1]);
            
            if(comp!=0){
                return comp;  //if they are not same 
            }
            else{
                return log1[0].CompareTo(log2[0]);
            }
        }
    }
}
