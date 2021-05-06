/* Given an 1D integer array A containing N distinct integers.
Find the number of unique pairs of integers in the array whose XOR is equal to B.
NOTE:
Pair (a, b) and (b, a) is considered to be same and should be counted once.
Example Input
Input 1:
 A = [5, 4, 10, 15, 7, 6]
 B = 5
Input 2:
 A = [3, 6, 8, 10, 15, 50]
 B = 5
Example Output
Output 1:1
Output 2:2
Example Explanation
Explanation 1:
 (10 ^ 15) = 5
Explanation 2:
 (3 ^ 6) = 5 and (10 ^ 15) = 5 */
 
 
class Solution {
    public int solve(List<int> A, int B) {
        
        HashSet<int> set = new HashSet<int>();
        
        foreach(var item in A){
            set.Add(item);
        }
        int count = 1;
        foreach(var item in A){
            if(set.Contains(B^item)){
                count++;
            }
        }
        return count/2;
    }
}
