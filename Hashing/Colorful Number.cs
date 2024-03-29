/* For Given Number N find if its COLORFUL number or not
Return 0/1
COLORFUL number:
A number can be broken into different contiguous sub-subsequence parts. 
Suppose, a number 3245 can be broken into parts like 3 2 4 5 32 24 45 324 245. 
And this number is a COLORFUL number, since product of every digit of a contiguous subsequence is different 
N = 23
2 3 23
2 -> 2
3 -> 3
23 -> 6
this number is a COLORFUL number since product of every digit of a sub-sequence are different. 
Output : 1 */

class Solution {
    public int colorful(int A) {
        
        List<int> num = new List<int>();
        while(A>0) {
            int x = A % 10;
            num.Add(x);
            A = A/10;
        }
        HashSet<int> hash = new HashSet<int>();
        for(int i = 0; i < num.Count; i++){
            int prod = 1;
			for (int j = i;  j < num.Count; j++){  
				prod = prod * num[j];
				if(hash.Contains(prod)){
				     return 0;
				}
				else{
					hash.Add(prod);
				}
			}
		}
        return 1;
    }
}



