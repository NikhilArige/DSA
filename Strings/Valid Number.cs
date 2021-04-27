/*Validate if a given string is numeric.
Examples:
"0" => true
" 0.1 " => true
"abc" => false
"1 a" => false
"2e10" => true
Return 0 / 1 ( 0 for false, 1 for true ) for this problem
Clarify the question using “See Expected Output”
Is 1u ( which may be a representation for unsigned integers valid?
For this problem, no.
Is 0.1e10 valid?
Yes
-01.1e-10?
Yes
Hexadecimal numbers like 0xFF?
Not for the purpose of this problem
3. (. not followed by a digit)?
No
Can exponent have decimal numbers? 3e0.1?
Not for this problem.
Is 1f ( floating point number with f as prefix ) valid?
Not for this problem.
How about 1000LL or 1000L ( C++ representation for long and long long numbers )?
Not for this problem.
How about integers preceded by 00 or 0? like 008?
Yes for this problem */


class Solution {
    public int isNumber(string A) {
        
        A=A.Trim();
        int n = A.Length;
        if(n==0){
            return 0;
        }
        
        if(n == 1 && !Char.IsDigit(A[0])){
            return 0;
        }
         
        if (A[0] != '+' && A[0] != '-' && !Char.IsDigit(A[0]) && A[0] != '.'){
            return 0;
        }
            
        bool isE = false;
        
        for(int i =1;i<n;i++){
            
            var val = A[i];
            if(!Char.IsDigit(val)  && val != 'e' && val != '.' 
            && val != '+' && val != '-'){
               return 0; 
            }
            
            if(val == '.'){
                
                 if(isE){
                    return 0;
                 } 
                //if . is the last character
                if (i+1 >= n){
                    return 0;
                } 
                if (!Char.IsDigit(A[i+1])){
                    return 0;
                }
            }
             else if(val == 'e'){
                
                 isE = true;
                if (!Char.IsDigit(A[i-1])){
                    return 0;
                }
  
                // If 'e' is the last Character
                if (i + 1 >= n){
                    return 0;
                }
  
                // if e is not followed by either '+', '-' or a digit
                if (!Char.IsDigit(A[i+1])  && A[i+1] != '+'
                    && A[i+1] != '-'){
                    return 0;
                }
            }   
        } 
        return 1;
    }
}
