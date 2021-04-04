//Given an integer array A of non-negative integers representing an elevation map where the width of each bar is 1, compute how much water it is able to trap after raining.
//A = [0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1]  Ans = 6


//O(n) & O(n)
class Solution {
    public int trap(List<int> A) {
        int n = A.Count;
        int[] left = new int[n];
        int[] right= new int[n];
        left[0]=A[0];
        right[n-1]=A[n-1]; 
        for (int i = 1; i < n; i++)
            left[i] = Math.Max(left[i - 1], A[i]);  
        for (int i = n - 2; i >= 0; i--)
            right[i] = Math.Max(right[i + 1], A[i]);
        
        int maxarea = 0;
        for(int i=0;i<n;i++){
            maxarea += (Math.Min(left[i],right[i])-A[i]);
        } 
        return maxarea;
    }
}

//O(n) & O(1)
class Solution {
    public int trap(List<int> A) {
        int n = A.Count;
            int l=0,r=n-1;
    int ans=0,lm=0,rm=0;
    while(l<r){
        if(A[l]<A[r]){
            lm=Math.Max(lm,A[l]);
            ans+=lm-A[l];
            l++;
        }
        else{
            rm=Math.Max(rm,A[r]);
            ans+=rm-A[r];
            r--;
        }
    }
    return ans;
}
}

