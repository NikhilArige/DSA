//Given an integer array A containing N distinct integers, you have to find all the leaders in the array A.
//An element is leader if it is strictly greater than all the elements to its right side.
//NOTE:The rightmost element is always a leader.
//A = [16, 17, 4, 3, 5, 2] Output :  [17, 2, 5]


class Solution {
    public List<int> solve(List<int> A) {
        
        int n = A.Count;
        int max = A[n-1];
        List<int> res = new List<int>();
        res.Add(A[n-1]);
        for(int i=n-2;i>=0;i--){
            if(A[i]>max){
                res.Add(A[i]);
            } 
            max=Math.Max(A[i],max);
        }
        res.Reverse();
        return res;
    }
}

