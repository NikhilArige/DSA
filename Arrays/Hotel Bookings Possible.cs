//A hotel manager has to process N advance bookings of rooms for the next season. His hotel has C rooms. Bookings contain an arrival date and a departure date. 
//He wants to find out whether there are enough rooms in the hotel to satisfy the demand. Write a program that solves this problem in time O(N log N) .
//A = [1, 3, 5] B = [2, 6, 8] C = 1 Output :0


class Solution {
    public int hotel(List<int> A, List<int> B, int C) {
        A.Sort();
        B.Sort();
        int n = A.Count;
        int i=1,j=0;
        int cnt = 1;
        int max = 1;
        while(i<n && j<n){
            if(A[i]<B[j]){
                cnt++;
                i++;
            }
            else{
                cnt--;
                j++;
            } 
            max = Math.Max(max,cnt);
             if(C<max){
                return 0;
              }
        } 
        return 1; 
    }
}
