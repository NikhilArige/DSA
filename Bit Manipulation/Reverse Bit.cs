//Reverse the bits of an 32 bit unsigned integer
//Input : 3 Output: 3221225472


public class Solution {
    public long reverse(long a) {
        long b = 0;
        //if its not all 32 means, a>0 is enough
        for(int i = 0; i <32; i++){
        b<<=1;
        b|=(a&1);
        a>>=1;
        }
        return b;
    }
}
