/* Given a target A on an infinite number line, i.e. -infinity to +infinity.
You are currently at position 0 and you need to reach the target by moving according to the below rule:
In ith move you can take i steps forward or backward.
Find the minimum number of moves required to reach the target.
Input 1: 3
Input 2: 2
Example Output
Output 1: 2
Output 2: 3
Example Explanation
Explanation 1:
 On the first move we step from 0 to 1.
 On the second step we step from 1 to 3.
Explanation 2:
 On the first move we step from 0 to 1.
 On the second move we step  from 1 to -1.
 On the third move we step from -1 to 2. */
 
 
 class Solution {
    public int solve(int A) {
        int ans = 0, sum = 0;
        int n = Math.Abs(A);
        while( sum < n || ((sum-n)%2)!=0){
              ans++;
              sum += ans;  
        } 
        return ans;
    }
}
