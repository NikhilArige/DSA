/*Given an integer array A and two integers B and C.
You need to find the number of subarrays in which the number of occurrences of B is equal to number of occurrences of C.
NOTE: Don't count empty subarrays.
Example Input
Input 1:
 A = [1, 2, 1]
 B = 1
 C = 2
Input 2:
 A = {1, 2, 1}
 B = 4
 C = 6
Example Output
Output 1:2
Output 2:6
Example Explanation
Explanation 1:
 The possible sub-arrays have same equal number of occurrences of B and C are:
    1) {1, 2}, B and C have same occurrence(1).
    2) {2, 1}, B and C have same occurrence(1).
Explanation 2:
 The possible sub-arrays have same equal number of occurrences of B and C are:
    1) {1}, B and C have same occurrence(0).
    2) {2}, B and C have same occurrence(0).
    3) {1}, B and C have same occurrence(0).
    4) {1, 2}, B and C have same occurrence(0).
    5) {2, 1}, B and C have same occurrence(0).
    6) {1, 2, 1}, B and C have same occurrence(0). */
    
 class Solution {
    public int solve(List<int> A, int B, int C) {
        Dictionary<int,int> dic = new Dictionary<int,int>();
        int sum=0,count=0;
        for(int i=0;i<A.Count;i++)
        {
            if(A[i]==B)
            {
                sum++;
            }
            else if(A[i]==C)
            {
                sum--;
            }
            if(sum==0)
            {
                count++;
            }
            if(dic.ContainsKey(sum))
            {
                count+=dic[sum];
                dic[sum]++;
            }
            else{
                dic.Add(sum,1);
            }
        }
        return count;
    }
}
