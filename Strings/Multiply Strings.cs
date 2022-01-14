/*Given two numbers represented as strings, return multiplication of the numbers as a string.
Note: The numbers can be arbitrarily large and are non-negative.
Note2: Your answer should not have leading zeroes. For example, 00 is not a valid answer. 
For example,
given strings "12", "10", your answer should be “120”.
NOTE : DO NOT USE BIG INTEGER LIBRARIES ( WHICH ARE AVAILABLE IN JAVA / PYTHON ).
We will retroactively disqualify such submissions and the submissions will incur penalties.*/


class Solution {
    public string multiply(string num1, string num2) {
        
            int len1 = num1.Length;
            int len2 = num2.Length;
            if (len1 == 0 || len2 == 0){
                return "0";
            }
            if (num1 == "0" || num2 == "0"){
                return "0";
            }
           
            int[] result = new int[len1 + len2];
         
            // Below two indices are used to find positions in result.
            int i_n1 = 0;
            int i_n2 = 0;
            int i;
             
            // Going from right to left in num1
            for (i = len1 - 1; i >= 0; i--)
            {
                int carry = 0;
                int n1 = num1[i] - '0';
         
                // To shift position to left after every
                // multipliccharAtion of a digit in num2
                i_n2 = 0;
                 
                // Go from right to left in num2            
                for (int j = len2 - 1; j >= 0; j--)
                {
                    // Take current digit of second number
                    int n2 = num2[j] - '0';
         
                    // Multiply with current digit of first number
                    // and add result to previously stored result
                    // charAt current position.
                    int sum = n1 * n2 + result[i_n1 + i_n2] + carry;
         
                    // Carry for next itercharAtion
                    carry = sum / 10;
         
                    // Store result
                    result[i_n1 + i_n2] = sum % 10;
         
                    i_n2++;
                }
         
                // store carry in next cell
                if (carry > 0){
                     result[i_n1 + i_n2] += carry;
                }
                    
                // To shift position to left after every
                // multipliccharAtion of a digit in num1.
                i_n1++;
            }
            // ignore '0's from the right
            i = result.Length - 1;
            while (i >= 0 && result[i] == 0){
                i--;
            }
            string s = "";
            while (i >= 0){
                s += (result[i--]); 
            }   
            return s;       
    }
}








public class Solution {
    public string Multiply(string num1, string num2) {
        if(num1 == "0" || num2 == "0"){
            return "0";
        }
        int m = num1.Length,n = num2.Length;
        var res = new int[m+n];
        for(int i=m-1;i>=0;i--){
            for(int j=n-1;j>=0;j--){ 
                int prod = (num1[i]-'0')*(num2[j]-'0');
                var sum = res[i+j+1] + prod;
                res[i+j+1] = sum%10;
                res[i+j] += sum/10; 
            }
        }
        var sb = new StringBuilder();
        for(int k=0;k<m+n;k++){
            if(k==0 && res[k]==0){
                continue;
            }
            sb.Append(res[k]);
        }
        return sb.ToString();
    }
}
