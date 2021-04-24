/* Implement atoi to convert a string to an integer.
Input: "9 2704"
Output: 9 */



class Solution {
    public int atoi(string str) {
        
        int sign = 1, result = 0, i = 0;
        //ignoring white spaces
        while (str[i] == ' ') {
            i++;
        }
 
        // sign of number
        if (str[i] == '-') {
            sign = -1;
            i++; 
        }
        else if(str[i] == '+'){
            sign = 1;
            i++;
        }
 
        while ( i < str.Length && str[i] >= '0' && str[i] <= '9') {
 
            // handling overflow test case
            if (result > int.MaxValue / 10 || (result == int.MaxValue / 10 && str[i] - '0' > 7)) {
                if (sign == 1)
                    return int.MaxValue;
                else
                    return int.MinValue;
            }
            result = 10 * result + (str[i++] - '0');
        }
        return result * sign;
    }
}



