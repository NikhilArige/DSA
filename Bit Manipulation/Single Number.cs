//Given an array of integers, every element appears twice except for one. Find that single one.
//Note: Your algorithm should have a linear runtime complexity. Could you implement it without using extra memory?


class Solution {
    public int singleNumber(List<int> A) {
        int num = A[0];
        int n = A.Count;
        for(int i =1;i<n;i++){
            num ^= A[i];                                       //xor of two same numbers give 0 and xor of a num with 0 gives that number
        }
        return num;
    }
}
