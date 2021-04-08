//Given an array S of n integers, find three integers in S such that the sum is closest to a given number, target.
//Return the sum of the three integers.
//Assume that there will only be one solution
//Example:
//given array S = {-1 2 1 -4},
//and target = 1.
//The sum that is closest to the target is 2. (-1 + 2 + 1 = 2)

class Solution {
    public int threeSumClosest(List<int> A, int B) {
        A.Sort();
        int n = A.Count;
        int min = int.MaxValue;
        int ans =0;
        for(int i =0;i< n-2;i++){
            
            int low = i+1;
            int high = n-1;
            while(low<high){
            int res = A[i]+A[low]+A[high];
            if(res==B){return res;} 
             if(Math.Abs(B-res)<min){
                 min = Math.Abs(B-res);
                 ans=res;
             } 
            if(res>B){high--;}
            if(res<B){low++;}
            }
        }
        return ans;
    }
}
