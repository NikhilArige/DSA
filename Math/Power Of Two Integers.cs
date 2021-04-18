/*Given a positive integer which fits in a 32 bit signed integer, find if it can be expressed as A^P where P > 1 and A > 0. A and P both should be integers.
Example
Input : 4
Output : True  
as 2^2 = 4. */
 
class Solution {
    public int isPower(int A) {
        if(A==1)
        return 1;
        int flag=0;
        for(int i=2;i<=Math.Sqrt(A);i++){
            if(A%i==0){
                if((A/i)==i){
                return 1;
                }
                else if((isPower(A/i)==1)&&(A/i)%i==0){
                return 1;
                }
            }
        }
        return 0;
        }
}
