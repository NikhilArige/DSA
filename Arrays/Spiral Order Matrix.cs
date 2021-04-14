//Given an integer A, generate a square matrix filled with elements from 1 to A2 in spiral order.
//A = 3
//Output :
//    [   [ 1, 2, 3 ],
//        [ 8, 9, 4 ],
//        [ 7, 6, 5 ]   ]

class Solution {
    public List<List<int>> generateMatrix(int A) {
        
        int[,] mat = new int[A,A];
        int n = 1; 
        int i;
        int t = 0;   //top most
        int b = A-1; //bottom most// rows-1
        int l = 0;   //left most
        int r = A-1; //right most // columns-1
        int dir = 0;
        while(t<=b && l<=r){
         if(dir==0){
             for(i=l;i<=r;i++){
                 mat[t,i] = n++;
             }
             t++;
             dir = 1;
         }
         else if(dir==1){
             for(i=t;i<=b;i++){
                 mat[i,r] = n++;
             }
             r--;
             dir = 2;
         }
         else if(dir==2){
             for(i=r;i>=l;i--){
                 mat[b,i] = n++;
             }
             b--;
             dir = 3;
         }
         else if(dir==3){
             for( i=b;i>=t;i--){
                 mat[i,l] = n++;
             }
             l++;
             dir = 0;
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

