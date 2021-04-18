/*Given a positive integer A, return its corresponding column title as appear in an Excel sheet.
1 -> A
2 -> B
3 -> C
...
26 -> Z
27 -> AA
28 -> AB */

class Solution {
    public string convertToTitle(int A) {
        
        string columnName = ""; 
        while (A > 0)
        { 
            int rem = A % 26;
      
            if (rem == 0)
            {
                columnName += "Z";
                A = (A / 26) - 1;
                //we are considering 26 to be ‘Z’
                //but it’s 25th with respect to ‘A’ so doing -1
            } 
            // If remainder is non-zero
            else
            {
                columnName += (char)((rem - 1) + 'A'); //zero indexing
                A = A / 26;
            } 
        } 
         return new string(columnName.ToCharArray().Reverse().ToArray());
    }
}

