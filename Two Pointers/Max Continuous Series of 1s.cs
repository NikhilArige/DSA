/*You are given with an array of 1s and 0s. And you are given with an integer M, which signifies number of flips allowed.
Find the position of zeros which when flipped will produce maximum continuous series of 1s.
For this problem, return the indices of maximum continuous series of 1s in order.
Example:
Input : 
Array = {1 1 0 1 1 0 0 1 1 1 } 
M = 1
Output : 
[0, 1, 2, 3, 4] */

class Solution {
    public List<int> maxone(List<int> A, int B) {
        List<int> result = new List<int>();   //sliding window approach
        int windowstart = 0;
        int n = A.Count;
        int window = 0;
        int startindex = 0;
        int endindex = 0;
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
          if(window<(windowend-windowstart+1)){
             window =windowend-windowstart+1; 
             startindex = windowstart;
             endindex = windowend;
          }
        } 
        for(int i=startindex;i<=endindex;i++){
            result.Add(i);
        }
        return result;
    }   
}

