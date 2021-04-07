//Given an array of integers, every element appears thrice except for one which occurs once.
//Find that element which does not appear thrice.
//Note: Your algorithm should have a linear runtime complexity.
//Could you implement it without using extra memory?

class Solution {
    public int singleNumber(List<int> A) {
        int n = A.Count;
        if(n<3) {
        return A[0];
        }
 
    /*
    *    we keep ones for first occurence of the element
    *    we keep twos for second occurence of the same element found earlier.
    *    when ones and twos reset back to original then element occured 3 times
    */
    int ones = 0, twos = 0; 
    for(int i=0;i<n;i++) {
        ones = (ones ^ A[i]) & (~twos);
        twos = (twos ^ A[i]) & (~ones);
    }
    return ones; 
    }
}
