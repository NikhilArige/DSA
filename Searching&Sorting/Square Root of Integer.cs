/*Given an integar A.
Compute and return the square root of A.
If A is not a perfect square, return floor(sqrt(A)).
DO NOT USE SQRT FUNCTION FROM STANDARD LIBRARY*/


class Solution {
    public int sqrt(int A) {
        
        if(A==0){return 0;}
        if(A<4){return 1;}
        if(A==4){return 2;}
        return (int)Search(3,A/2,A);
    }
    public long Search(int start,int end,int A){
        
        long mid = (start+end)/2;
        long num = mid*mid;
        if((num<=A) && (((mid+1)*(mid+1))>A)){
            return mid;
        }
        else if(num>A){
            return Search(start,(int)mid-1,A);
        }
        else{
            return Search((int)mid+1,end,A);
        }
    }
      
}
