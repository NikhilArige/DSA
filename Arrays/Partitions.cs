/*You are given a 1D integer array B containing A integers.
Count the number of ways to split all the elements of the array into 3 contiguous parts so that the sum of elements in each part is the same.
Such that : sum(B[1],..B[i]) = sum(B[i+1],...B[j]) = sum(B[j+1],...B[n])
A = 5 
B = [1, 2, 3, 0, 3]
Input 2:
A = 4
B = [0, 1, -1, 0]
Example Output
Output 1:2
Output 2:1
Example Explanation
Explanation 1:
 There are no 2 ways to make partitions -
 1. (1,2)+(3)+(0,3).
 2. (1,2)+(3,0)+(3).
Explanation 2:
 There is only 1 way to make partition -
 1. (0)+(-1,1)+(0). */
 
 class Solution {
    public int solve(int A, List<int> B) {
        int n = B.Count;
        int maxSum = 0;
        foreach(var item in B){
            maxSum+=item;
        }
        //sum of all should be divisible by 3 as three partitions are to be made
        if(maxSum%3!=0){
            return 0;
        } 
        int sum = maxSum/3; //sum of one partition values
          
        int[] count = new int[n];
        int tempsum=0;
        //[1, 2, 3, 0, 3]
        //[0, 0, 0, 1, 1]
        for(int i = n-1;i>=0;i--){
            tempsum+=B[i];
            count[i]= (tempsum==sum)? 1:0;
        }
        //[1, 2, 3, 0, 3]
        //[0, 0, 0, 1, 1]
        //[2, 2, 2, 2, 1]
        for(int i = n-2;i>=0;i--){
            count[i]+=count[i+1]; 
        }
        int result = 0;
        tempsum = 0;
        //[1, 2here(tempsum will be sum) , 3, 0, 3] 
        //[2, 2, 2, here2(ways), 1] 
        for (int i = 0 ; i + 2 < n ; i++)
        {
            tempsum += B[i];
            if (tempsum == sum){
                result += count[i + 2];}
        }
        return result;
    }
}
