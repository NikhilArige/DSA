/*The count-and-say sequence is the sequence of integers beginning as follows:
1, 11, 21, 1211, 111221, ...
1 is read off as one 1 or 11.
11 is read off as two 1s or 21.
21 is read off as one 2, then one 1 or 1211.
Given an integer n, generate the nth sequence.
Note: The sequence of integers will be represented as a string.
Example:
if n = 2,
the sequence is 11.*/


class Solution {
    public string countAndSay(int n) {
        
        if(n==1){return "1";}
        if(n==2){return "11";}
        
        string str = "11";
        for(int i=3;i<=n;i++){
            
            int len = str.Length; 
            int cnt = 1;  
            string temp = ""; 
            for(int j=0;j<len;j++){
             
             if (j < len-1 && str[j] == str[j+1]) {
                cnt++;
            } else {
                if (j == (len - 2) && str[j] != str[j+1] && cnt == 1) {
                    temp += "1" + str[j];
                } else {
                    //takes as string of cnt
                    temp += cnt + 0;
                    temp += str[j];
                    cnt = 1;
                }
            }
            }    
            str = temp;
        }
        return str;
    }
}
