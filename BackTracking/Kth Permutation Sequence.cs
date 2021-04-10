//The set [1,2,3,…,n] contains a total of n! unique permutations.
//By listing and labeling all of the permutations in order,
//We get the following sequence (ie, for n = 3 ) :
//1. "123"
//2. "132"
//3. "213"
//4. "231"
//5. "312"
//6. "321"
//Given n and k, return the kth permutation sequence.
//For example, given n = 3, k = 4, ans = "231"



public class Solution {
    List<int> num = new List<int>();
    List<int> fact = new List<int>();
    public String getPermutation(int A, int B) { 
         
        //filling fact and num
        int f = 1;
        fact.Add(1);
        for(int i=1;i<=A;i++){
            f*=i;
            fact.Add(f);
            num.Add(i);
        }    
        string result = "";
        FindPermutation(A,B,ref result);
        
        return result;
    }
     public void FindPermutation(int A,int B,ref string result){
         
         if(A==1){
             result+=Convert.ToString(num[0]);  //Adding last remining digit
             return;
         }
         
         int index = B/fact[A-1];  //number of blocks to skip
         if(B%fact[A-1]==0)  //We need to convert 1 based indexing to 0 based.So,decrese index by 1
           { index-=1;}
        result+=Convert.ToString(num[index]);  //Adding new character
        num.RemoveAt(index);    //Removing digit after using
        
        B -= fact[A-1]*index;  //Decreasing B value
        FindPermutation(A-1,B,ref result);  //Decreasing A till only one is left
          
    }  
}
