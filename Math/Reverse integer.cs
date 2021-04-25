/*Reverse digits of an integer.
Example1:
x = 123,
return 321
Example2:
x = -123,
return -321
Return 0 if the result overflows and does not fit in a 32 bit signed integer */

class Solution {
    public int reverse(int A) {
        int flag=0;
        if(A<0) {
            flag=1;
            A = A*-1;
        }
        long result=0;
        while(A!=0) {
              result = (result*(10))+A%10;
                A = A/10;
                if(result <int.MinValue || result>int.MaxValue){
                    result=0;
                    break;
                }
            }
        if(flag==1){
           result = -1*(result); 
        } 
        return (int)result;
    }
}


