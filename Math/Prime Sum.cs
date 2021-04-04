//Given an even number ( greater than 2 ), return two prime numbers whose sum will be equal to given number.
//NOTE A solution will always exist.





class Solution {
    public List<int> primesum(int A) {
        
        bool[] isPrime = new bool[A+1];      //bool array for primes
        isPrime[0]=isPrime[1]= false;
         for (int i = 2; i <= A; i++)
          {  isPrime[i] = true;}
        
        for(int i= 2;i<=Math.Sqrt(A);i++){
            if(isPrime[i]==true){ 
                for(int j=i*i;j<=A;j=j+i){
                    isPrime[j]= false;      //multiples of i
                }
            }  
        }
        List<int> res = new List<int>();
        for (int i = 0; i < A; i++)
        {
            if (isPrime[i] && isPrime[A - i])
            {
                res.Add(i);
                res.Add(A-i);
                break;
            }
        }
        
        return res;
        
    }
}
