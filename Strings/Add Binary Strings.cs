/*Given two binary strings, return their sum (also a binary string).
Example:
a = "100"
b = "11"
Return a + b = “111”.*/

//getting TLE for this
using System.Text;
class Solution {
    public string addBinary(string A, string B) {
        
            //taking max of both
            int size=Math.Max(A.Length,B.Length);
            //appending 0s to smaller one in front
            while(A.Length<size){
                 A='0'+A;
            }
            while(B.Length<size){
                 B='0'+B;
            }
            StringBuilder ans= new StringBuilder();
            int carry=0;
            for(int i=size-1;i>=0;i--){
                if(A[i]=='0'&& B[i]=='0'){
                    if(carry==1){
                        ans.Append("1");
                        carry=0;
                     }
                     else{
                     ans.Append("0");
                     }
                }
                else if(A[i]=='1' && B[i]=='1'){
                    if(carry==1){
                    ans.Append("1");
                    carry=1;
                    }
                    else{
                    ans.Append("0");
                    carry=1;
                    }
                }
                else {
                    if(carry==1){
                    ans.Append("0");
                    carry=1;
                    }
                    else{
                    ans.Append("1");
                        }
                    }
                }
            if(carry==1){
            ans.Append("1");
            }
            
            return new string(ans.ToString().Reverse().ToArray()); 
    }
}

//Got no TLE with this
using System.Text;
using System.Linq;
class Solution {
    public string addBinary(string A, string B) {
            
            A = new string(A.ToCharArray().Reverse().ToArray());
            B = new string(B.ToCharArray().Reverse().ToArray());
           int m = A.Length;
           int n = B.Length;
           int dif = 0;
           if(m>n){
               dif = m-n;
               string s= "";
               for(int i=0;i<dif;i++){
                   s+="0";
               }
               B+=s;
           }
           else if(n>m){
               dif = n-m;
               string s= "";
               for(int i=0;i<dif;i++){
                   s+="0";
               }
               A+=s; 
           }
           StringBuilder result = new StringBuilder();
           
           char ch = '0';
           for(int i=0;i<A.Length;i++){
               
               if(ch == '1' && (A[i]=='1' && B[i]=='1')){
                   
                   result.Append("1");
                   continue;
               }
               else if(A[i]=='1' && B[i]=='1' && ch=='0'){ 
                   result.Append("0");
                   ch = '1';
                   continue;
               }
               else if(A[i]=='0' && B[i]=='0' && ch=='0'){
                   result.Append("0");
                   continue;
               }
               else if(A[i]=='0' && B[i]=='0' && ch=='1'){
                   result.Append("1");
                   ch = '0';
                   continue;
               }
               else if(((A[i]=='1' && B[i]=='0')||(A[i]=='0' && B[i]=='1')) && ch=='1'){
                   result.Append("0"); 
                   continue;
               }
               else if(((A[i]=='1' && B[i]=='0')||(A[i]=='0' && B[i]=='1')) && ch=='0'){
                   result.Append("1");
                   continue;
               } 
           }
           if(ch=='1'){
               result.Append("1");
           } 
          string res = result.ToString();
           res = new string(res.ToCharArray().Reverse().ToArray()); 
           return res;    
    }
}

