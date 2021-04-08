//You are given an array of N non-negative integers, A0, A1 ,…, AN-1.
//Considering each array element Ai as the edge length of some line segment, count the number of triangles which you can form using these array values.
//You can use any value only once while forming each triangle. Order of choosing the edge lengths doesn’t matter. Any triangle formed should have a positive area.
//Return answer modulo 10^9 + 7.


class Solution {
    public int nTriang(List<int> A) {
        A.Sort();
        int n = A.Count;
        int count = 0;
        int mod = 1000000007; 
        for(int i=n-1;i>=1;i--){
            int left=0,right=i-1;
            while(left<right){
              if(A[left]+A[right]>A[i]){ 
                  //if left,right,i can form,then remaining from left+1 to right-1 can also form with i
                  count = (count+right-left)%mod; 
                  right--; 
              } 
              else{
                  left++;
              } 
            } 
        }
        return count; 
    }
}
