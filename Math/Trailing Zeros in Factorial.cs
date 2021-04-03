//Given an integer A, return the number of trailing zeroes in A!.
//Input = 5; Output = 1; 5!= 120 => 1


class Solution {
    public int trailingZeroes(int n) {
        if(n<5){
        return 0;
        }
        int cnt = 0;
        for(int i = 5;(n/i)>0;i=i*5){            //taking count of number 5s under given n (prime factors 2*5 gives 10 which has a zero and so taking count of 5s)
            cnt+=n/i;  
        } 
        return cnt;
    }
}
