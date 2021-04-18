/*Given a string A representing a roman numeral.
Convert A into integer.
A is guaranteed to be within the range from 1 to 3999.
Input 1:
    A = "XIV"
Output 1:
    14
Input 2:
    A = "XX"
Output 2:
    20  */
    
    
class Solution {
    public int romanToInt(string A) {
        
        int val = 0;
        for(int i=0;i<A.Length;i++){
            
            int v1 = value(A[i]);
            if(i+1<A.Length){
                
                int v2 = value(A[i+1]);
                if(v1>=v2){
                    val+=v1;
                }
                else{ 
                    //IV means 10 less than fifty, so 50-40
                    val = val+v2-v1;
                    i++; 
                } 
            }
             else {
                val += v1; 
            } 
        }
            
        return val;
        
    }
    private int value(char r)
    {
        if (r == 'I')
            return 1;
        if (r == 'V')
            return 5;
        if (r == 'X')
            return 10;
        if (r == 'L')
            return 50;
        if (r == 'C')
            return 100;
        if (r == 'D')
            return 500;
        if (r == 'M')
            return 1000;
        return -1;
    }
}
   
