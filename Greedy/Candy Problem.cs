//There are N children standing in a line. Each child is assigned a rating value.
//You are giving candies to these children subjected to the following requirements:
//1. Each child must have at least one candy.
//2. Children with a higher rating get more candies than their neighbors.
//What is the minimum candies you must give?
//Input 1: A = [1, 2] Output 1:  3
//Explanation 1: The candidate with 1 rating gets 1 candy and candidate with rating cannot get 1 candy as 1 is its neighbor. 
//               So rating 2 candidate gets 2 candies. In total, 2 + 1 = 3 candies need to be given out.
//Input 2: A = [1, 5, 2, 1] Output 2: 7
//Explanation 2:  Candies given = [1, 3, 2, 1]

class Solution {
    public int candy(List<int> A) { 
        int n = A.Count;
        
        int[] left = new int[n];
        int[] right = new int[n];
        for(int i=0;i<n;i++){
            left[i] = 1;
            right[i] = 1;           //condition 1
        }
        for(int i=1;i<n;i++){
           if(A[i]>A[i-1]){
               left[i] = left[i-1] + 1;
           }
        }
        for(int i=n-2;i>=0;i--){
           if(A[i]>A[i+1]){
               right[i] = right[i+1] + 1;
           }
        }
        
        int count = 0;
        for(int i=0;i<n;i++){
            count+= Math.Max(left[i],right[i]);   //max of left and right
        }
        
        return count;
    }
}
