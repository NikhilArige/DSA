/* How many minimum numbers from fibonacci series are required such that sum of numbers should be equal to a given Number N?
Note : repetition of number is allowed.
Example:
N = 4
Fibonacci numbers : 1 1 2 3 5 .... so on
here 2 + 2 = 4 
so minimum numbers will be 2 */


class Solution {
    public int fibsum(int A) {
        List<int> fib = new List<int>();
        
        fib.Add(1);
        fib.Add(2);
        
        for(int i=2;;i++) {
        int nextfib = fib[i-1] + fib[i-2];
        if(nextfib>A){
            break;
        }
           fib.Add(nextfib);
        }
        
        int count = 0; 
        int n = fib.Count-1;
        while(A>0) {
            //consider 1 1 2 3
            //after first iteration A=1 then A= 1-2 which is wrong
            //so this while loop is used to decrement 
            while(A < fib[n]){
                n--;
            }
            A -= fib[n];
            count++; 
        }
     
     return count;
       
    }
}
