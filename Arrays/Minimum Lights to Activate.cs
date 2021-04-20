/*There is a corridor in a Jail which is N units long. Given an array A of size N. The ith index of this array is 0 if the light at ith position is faulty otherwise it is 1.
All the lights are of specific power B which if is placed at position X, it can light the corridor from [ X-B+1, X+B-1].
Initially all lights are off.
Return the minimum number of lights to be turned ON to light the whole corridor or -1 if the whole corridor cannot be lighted.
Input 1:
A = [ 0, 0, 1, 1, 1, 0, 0, 1].
B = 3
Input 2:
A = [ 0, 0, 0, 1, 0].
B = 3
Example Output
Output 1:2
Output 2:-1
Example Explanation
Explanation 1:
In the first configuration, Turn on the lights at 3rd and 8th index.
Light at 3rd index covers from [ 1, 5] and light at 8th index covers [ 6, 8].
Explanation 2:
In the second configuration, there is no light which can light the first corridor.*/


class Solution {
    public int solve(List<int> A, int B) {
         //Greedy approach
    int s=0, ans = 0, cs, n=A.Count;
    //s points to first dark location
    //cs will find the best position bulb that can be used to light up positions
    //if no cs position possible then we return -1
    //then we update s to the next dark location after we use the cs bulb
    //while performing all the above steps 0<=s,cs<A.size()
    while(s<n) 
    {
        cs = (s+B-1 < n ? s+B-1 : n-1);
        while(cs>=0 && cs>=(s-B+1) && A[cs]!=1){
            cs--;
        }
        if(cs<(s-B+1) || cs<0){
            return -1;
        }
        s = cs + B;
        ans++;
    }
    return ans;
        
    }
}
