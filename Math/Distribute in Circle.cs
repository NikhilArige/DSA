//A items are to be delivered in a circle of size B.
//Find the position where the Ath item will be delivered if we start from a given position C.
//NOTE: Items are distributed at adjacent positions starting from C.
// A = 8;B = 5;C = 2 Output: 4
 
 
class Solution {
    public int solve(int A, int B, int C) {
       return (C + (A -1)) % B;
    }
}
