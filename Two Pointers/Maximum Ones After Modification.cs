Given a binary array A and a number B, we need to find length of the longest subsegment of ‘1’s possible by changing at most B ‘0’s
//A = [1, 0, 0, 1, 0, 1, 0, 1, 0, 1]  B = 2    
//Here, we can change only 2 zeros. Maximum possible length we can get is by changing the 3rd and 4th (or) 4th and 5th zeros.


class Solution {
    public int solve(List<int> A, int B) {
        //sliding window approach
        int windowstart = 0;
        int n = A.Count;
        int window = 0;
        //to count the number of zeroes in the window, it this exceeds B,start decreasing from left
        int count = 0;
        for(int windowend=0;windowend< n;windowend++){
          
          if(A[windowend]==0){
              count++;
          }
          while(count>B){
              if(A[windowstart]==0){
                  count--;
              }
              windowstart++; 
          } 
            window =Math.Max(window,windowend-windowstart+1); 
        }  
        return window;
    }
}

