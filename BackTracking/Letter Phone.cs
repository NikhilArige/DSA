//Given a digit string, return all possible letter combinations that the number could represent.
//A mapping of digit to letters (just like on the telephone buttons) is given below.
//The digit 0 maps to 0 itself.
//The digit 1 maps to 1 itself.
//Input: Digit string "23"
//Output: ["ad", "ae", "af", "bd", "be", "bf", "cd", "ce", "cf"].
//Make sure the returned strings are lexicographically sorted.



class Solution {
    string[] num = new string[]{"0","1","abc",
            "def","ghi","jkl","mno","pqrs","tuv","wxyz"};          //since 0 and 1 maps to itself
    public List<string> letterCombinations(string A) {
         
         int n =A.Length;
         List<string> result = new List<string>();
         GetCombinations(result,"",A,0,n);
         return result;
    }
    public void GetCombinations(List<string> result,string cur,string A,int start,int length){
        
        if(start == length){
            result.Add(cur);
            return;
        }
        string first = num[(A[start]-'0')];            //Use -'0' , Convert.Int32 doesnt work here
        for(int i = 0;i<first.Length;i++){
             
            cur+=first[i]; 
            GetCombinations(result,cur,A,start+1,length);
            if(cur.Length == 1){
                cur = "";
            }
            else{  
            cur = cur.Remove(cur.Length-1); 
            }
        }
        
    }
      
}
