/*Hamming distance between two non-negative integers is defined as the number of positions at which the corresponding bits are different.
Given an array A of N non-negative integers, find the sum of hamming distances of all pairs of integers in the array. Return the answer modulo 1000000007.
A = [2, 4, 6] Answer = 8
We return, f(2, 2) + f(2, 4) + f(2, 6) + f(4, 2) + f(4, 4) + f(4, 6) + f(6, 2) + f(6, 4) + f(6, 6) = 8 */


class Solution {
    //count number of ones and zeros for every bit till 32
    //result +=2(1count)(n-1count) //2 as say for pairs 1,3 and 3,1  
    public int hammingDistance(List<int> A) {
      
        long n = A.Count;
        long result = 0; 
        long count = 0;
        for(int i =0;i<31;i++){
             count = 0;
            for(int j=0;j<n;j++){
                //1<<0= 1; 1<<1=2 i.e., 10 ; 1<<2=4 i.e., 100 and so on..
                if((A[j]&(1<<i))!=0){
                    //!=0 or ==0 to be used, not ==1
                count++;
                } 
            } 
            result = (result + count*(n-count)*2)%1000000007;
            //result+= ((count)*2*(n-count))%1000000007; not working for bigger testcases
        } 
        return (int)result;
    }
}

 
