//Find the index of the first occurrence of needle(some string) in haystack(some string), or -1 if needle is not part of haystack.


class Solution {
    public int strStr(string B, string A) {
        //longest proper prefix which is also suffix
        int[] lps = new int[A.Length];
        Filllps(lps,A,A.Length);
        
        int j=0,i=0;
        while(i<B.Length){
            
            if(A[j]==B[i]){ 
                i++;
                j++; 
            }
            if (j == A.Length) { 
                return (i-j);  //occuring at first index
                j = lps[j - 1];
            }
  
            // mismatch  
            else if (i < B.Length && A[j] != B[i]) { 
                if (j != 0){
                    j = lps[j - 1]; 
                }
                else{
                    i = i + 1; 
                }
            }
            
        }
        return -1;
    }
    
    public void Filllps(int[] lps,string pat,int length){
        
        int len=0;
        int i = 1;
        //lps[0] is always 0
        lps[0] = 0;
        while(i<length){
            if(pat[i]==pat[len]){
                len++;
                lps[i]= len;
                i++;
            }
            else{
                 if (len != 0) {
                    len = lps[len - 1];       
                 }
                 else{
                    lps[i] = len;
                    i++;
                 }  
            }   
        }  
    }
}


