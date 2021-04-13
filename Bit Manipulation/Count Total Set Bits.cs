//Given a positive integer A, the task is to count the total number of set bits in the binary representation of all the numbers from 1 to A.
//Return the count modulo 10^9 + 7.
//Input:3;Output = 4;
//DECIMAL    BINARY  SET BIT COUNT
//    1          01        1
//    2          10        1
//    3          11        2
// 1 + 1 + 2 = 4 
// Answer = 4 % 1000000007 = 4



class Solution {
    public int solve(int A) {
         if(A==0){return 0;}
         double ans = 0;    //as we are using power
         int p = 0;
         while(Math.Pow(2,p)<=A){
             p++;
         }
         p--;
         //try with 1 to 10 to understand
         //       till 7             most significant of 8,9,10      solve(2)i.e, 1to2
         ans+=((p*Math.Pow(2,p))/2)+ (A-Math.Pow(2,p)+1) +        solve((int)(A-Math.Pow(2,p)));
          
         ans%=1000000007;
         return (int)ans;
    }
}


