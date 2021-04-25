/*Given a string A and integer B, what is maximal lexicographical stringthat can be made from A if you do atmost B swaps.
Example Input
Input 1:
A = "254" B = 1
Input 2:
A = "254" B = 2
Example Output
Output 1:524
Output 2:542
Example Explanation
Explanation 1: Swap 2 and 5.
Explanation 2: Swap 2 and 5 then swap 4 and 2. */

class Solution {
    public string res = "0";
    public string solve(string A, int B) {
        
        findMaximum(A,B);
        return res;
    }
    private void findMaximum(string A,int k){
        
        if(long.Parse(A)>long.Parse(res)){
            res = A;
        }
        if(k==0){
            return;
        } 
        //taken till length-1 only
        for(int i = 0;i<A.Length-1;i++){
            for(int j=i+1;j<A.Length;j++){
                
                if(A[j]>A[i]){
                   A=swap(A,i,j);
                   findMaximum(A,k-1);
                   A=swap(A,i,j);
                }
            }
        }
    }
    
    private string swap(string A,int i ,int j){
        
        char[] ch = A.ToCharArray();
        char temp = ch[i];
        ch[i]=ch[j];
        ch[j]=temp;
        return new string(ch); 
        
    }
}
