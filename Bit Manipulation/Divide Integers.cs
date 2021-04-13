//Divide two integers without using multiplication, division and mod operator.Return the floor of the result of the division.
//Example:5 / 2 = 2


class Solution {
    public int divide(int x, int y) {
        long a = x;   //need to take as long here only!!! as x or y is <int.Min,its taken as 0
        long b = y;
        int sign = 0;
        if((a<0 && b>0) || (a>0&&b<0)){
            sign = 1;
        } 
        if(a==0){return 0;}
        if(b==0){return int.MaxValue;}
        if(a<0){a=-a;}   //taking only pos
        if(b<0){b=-b;} 
        
        long temp = 0;
        long ans = 0; 
        for(int i = 31;i>=0;i--){
            
            if(temp+(b<<i)<=a){          //b<<i = b*2^i
                temp+=(b<<i);   
                ans+=(1LL<<i);
            } 
        } 
        if(sign ==1){ans = -ans;}
        if(ans>int.MaxValue || ans < int.MinValue){return int.MaxValue;}
          return (int)ans;
    }
}
