/*Given two binary strings, return their sum (also a binary string).
Example:
a = "100"
b = "11"
Return a + b = “111”.*/


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


