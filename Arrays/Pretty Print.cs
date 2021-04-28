/*Print concentric rectangular pattern in a 2d matrix.
Let us show you some examples to clarify what we mean.
Example 1:
Input: A = 4.
Output:
4 4 4 4 4 4 4 
4 3 3 3 3 3 4 
4 3 2 2 2 3 4 
4 3 2 1 2 3 4 
4 3 2 2 2 3 4 
4 3 3 3 3 3 4 
4 4 4 4 4 4 4 
Example 2:
Input: A = 3.
Output:
3 3 3 3 3 
3 2 2 2 3 
3 2 1 2 3 
3 2 2 2 3 
3 3 3 3 3 
The outermost rectangle is formed by A, then the next outermost is formed by A-1 and so on.
You will be given A as an argument to the function you need to implement, and you need to return a 2D array.*/


class Solution {
    public List<List<int>> prettyPrint(int val) {
        
        int A = 2*val - 1;
        int[,] mat = new int[A,A];
        int n = val; 
        int i;
        int t = 0;   //top most
        int b = A-1; //bottom most// rows-1
        int l = 0;   //left most
        int r = A-1; //right most // columns-1
        int dir = 0;
        int count = 4;
        while(t<=b && l<=r){
         if(dir==0){
             for(i=l;i<=r;i++){
                 mat[t,i] = n;
             }
             t++;
             dir = 1;
             count--;
         }
         else if(dir==1){
             for(i=t;i<=b;i++){
                 mat[i,r] = n;
             }
             r--;
             dir = 2;
             count--;
         }
         else if(dir==2){
             for(i=r;i>=l;i--){
                 mat[b,i] = n;
             }
             b--;
             dir = 3;
             count--;
         }
         else if(dir==3){
             for( i=b;i>=t;i--){
                 mat[i,l] = n;
             }
             l++;
             dir = 0;
             count--;
         }
         if(count == 0){
             n--;
             count =4;
         }
        }
        int[] arr = new int[A];
        List<int> list = new List<int>();
        List<List<int>> result = new List<List<int>>();
        for(int p =0;p<A;p++){
            for(int q=0;q<A;q++){
                arr[q]= mat[p,q]; 
            }
            list = arr.ToList();
            result.Add(new List<int>(list));
        } 
        return result;  
    }
    
}
