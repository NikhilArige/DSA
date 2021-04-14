//Given an integer array A, find if an integer p exists in the array such that the number of integers greater than p in the array equals to p.
//A = [3, 2, 1, 3] Output:1
//Explanation :For integer 2, there are 2 greater elements in the array. So, return 1. 



class Solution {
    public int solve(List<int> A) {
        A.Sort();
        if(A[A.Count-1]==0){     //if last one is 0
            return 1;
        }
        for(int i=0;i<A.Count-1;i++){ 
            if(A[i]!=A[i+1]){
                if((A.Count-i-1)==((A[i]))){
                    return 1;
                }
            } 
        } 
        return -1;
    }
}
