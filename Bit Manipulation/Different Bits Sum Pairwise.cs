//We define f(X, Y) as number of different corresponding bits in binary representation of X and Y. For example, f(2, 7) = 2, since binary representation of 2 and 7 are 010 and 111, respectively. The first and the third bit differ, so f(2, 7) = 2.
//You are given an array of N positive integers, A1, A2 ,…, AN. Find sum of f(Ai, Aj) for all pairs (i, j) such that 1 ≤ i, j ≤ N. Return the answer modulo 109+7.
//For example,A=[1, 3, 5]
//We return
//f(1, 1) + f(1, 3) + f(1, 5) + 
//f(3, 1) + f(3, 3) + f(3, 5) +
//f(5, 1) + f(5, 3) + f(5, 5) =
//0 + 1 + 1 +
//1 + 0 + 2 +
//1 + 2 + 0 = 8


class Solution {
    //be careful about Long!!
    public int cntBits(List<int> arr) {
        long n = arr.Count;  //need to take as long!!!!!!
        long  ans = 0;  
        long mod = 1000000007L;  //long
        // traverse over all bits
        for (int i = 0; i < 32; i++) {
            // count number of elements with set
            // with ith bit set
            long ones = 0;
            long zeroes = 0;
            for (int j = 0; j < n; j++){
                if ((arr[j]&1)==1) {
                    ones++;
                    } 
            else {
                    zeroes++;
                }
                arr[j]>>=1;
            }
            // count of no of 1s in last bits of all number* count of no of 0s in them * 2(as 1,3 and 3,1 both fetch same result)
            ans += (ones * zeroes * 2L)%mod;   //2L-long
        } 
        return (int)(ans%mod);
    }
}
