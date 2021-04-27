/*Implement pow(x, n) % d.
In other words, given x, n and d,
find (xn % d)
Note that remainders on division cannot be negative.
In other words, make sure the answer you return is non negative.
Input : x = 2, n = 3, d = 3
Output : 2
2^3 % 3 = 8 % 3 = 2. */



public class Solution {
    long  res = 0;
	public int pow(int x, int n, int d) {
	    
	    long a = x;
	    long b= n;
	    long c= d;
	    
	    if(a==0){
	        return 0;
	    }
	    if(b==0){
	        return 1;
	    }
	    if(b==1){
	         res = a%c;
	    }
	    
	    res = pow((int)a,(int)b/2,(int)c);
	    
	    if(b%2==1){
	      res = (((res*res)%c)*a)%c;  
	    } 
        else{
          res = ((res%c)*(res%c))%c;  
        } 
        if(res<0){
          return Math.Abs((int)(res+c)%(int)c);  
        } 
        else{
           return Math.Abs((int)res%(int)c); 
        }
	}
}
