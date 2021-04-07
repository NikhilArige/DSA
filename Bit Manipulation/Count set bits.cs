//Write an efficient program to count number of 1s in the binary representation of an integer.


public class Solution {
	public int numSetBits(int a) {
	   {
        int count = 0;
        while (n > 0) {
            count += n & 1;
            n >>= 1;
        }
        return count;
    }
} 
