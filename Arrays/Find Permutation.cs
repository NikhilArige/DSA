/*Given a positive integer n and a string s consisting only of letters D or I, you have to find any permutation of first n positive integer that satisfy the given input string.
D means the next number is smaller, while I means the next number is greater.
Notes
Length of given string s will always equal to n - 1
Your solution should run in linear time and space.
Example :
Input 1:
n = 3
s = ID
Return: [1, 3, 2] */


public class Solution {
    public List<int> findPerm(string A, int B) {
        int ds=1;
        int is=B; 
        List<int> result = new List<int>(); 
        for(int i=0;i<A.Length;i++){
            if(A[i]=='D'){
                result.Add(is);
                is--;
            }
            else{
                 result.Add(ds);
                ds++;
            }
        }
         for(int j=ds;j<=is;j++){
               result.Add(ds);
               //pending ones 
         }
        return result;
    }
}

