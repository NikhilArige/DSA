/*Find the contiguous subarray within an array (containing at least one number) which has the largest product.
Return an integer corresponding to the maximum product possible.
Input : [2, 3, -2, 4]
Return : 6 
Possible with [2, 3]*/


class Solution {
    public int maxProduct(List<int> A) {
        
        int n = A.Count; 
        if(n==1){return A[0];}
        int max_pos_prod = 1;
        int min_neg_prod = 1;
        int totalmax = 0;
        int flag = 0;
  
        for (int i = 0; i < n; i++)
        {
            if (A[i] > 0) {
                max_pos_prod = max_pos_prod * A[i];
                min_neg_prod = Math.Min(min_neg_prod * A[i], 1);
                flag = 1;
            }
            else if (A[i] == 0)
            {
                max_pos_prod = 1;
                min_neg_prod = 1;
            }
            else
            {    // -10    2     3          -4 
                //maxprod  2     6(temp)    240(-60*-4)
                //minprod  -20  -60         -24(temp*-4)
                int temp = max_pos_prod;
                max_pos_prod = Math.Max(min_neg_prod*A[i],1);
                min_neg_prod = temp * A[i];
            }
            totalmax= Math.Max(totalmax,max_pos_prod);
        }
        if (flag == 0 && totalmax == 1){
            return 0;
        }
        return totalmax;
    }
}

public class Solution {
    public int MaxProduct(int[] A) {
        int n =  A.Length;
        if(n==1){
            return A[0];
        }
        int maxprod = A[0];
        int minprod = A[0];
        int res  = A[0];
        int choice1,choice2;
        for(int i=1;i<n;i++){
            choice1 = maxprod*A[i];
            choice2 = minprod*A[i]; 
            maxprod = Math.Max(A[i],Math.Max(choice1,choice2));
            minprod = Math.Min(A[i],Math.Min(choice1,choice2));
            res = Math.Max(res,maxprod);
        }
        return res;
    }
}
