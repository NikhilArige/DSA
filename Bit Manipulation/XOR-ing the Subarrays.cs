//Given an integer array A of size N.
//You need to find the value obtained by XOR-ing the contiguous subarrays, followed by XOR-ing the values thus obtained. Determine and return this value.
//A = [4, 5, 7, 5] Ans : 0 
//Explanation:  4 ⊕ 5 ⊕ 7 ⊕ 5 ⊕ (4 ⊕ 5) ⊕ (5 ⊕ 7) ⊕ (7 ⊕ 5) ⊕ (4 ⊕ 5 ⊕ 7) ⊕ (5 ⊕ 7 ⊕ 5) ⊕ (4 ⊕ 5 ⊕ 7 ⊕ 5) = 0


class Solution {
    public int solve(List<int> A) {
        int n = A.Count;
        int result = 0;
        for(int i = 0;i<n;i++){ 
            //will give how many times A[i] will be in xoring
            int freq = (i+1)*(n-i); 
            // if frequency is odd,then include it in the result
            if(freq%2 != 0){
                result ^= A[i];
            }  
        }
        return result;
    }
}

