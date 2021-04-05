//Given a list of non negative integers, arrange them such that they form the largest number.
//Given [3, 30, 34, 5, 9], the largest formed number is 9534330.
//Note: The result may be very large, so you need to return a string instead of an integer.


class Solution {
    public string largestNumber(List<int> A) {
     if(A.Count == 1){
         return Convert.ToString(A[0]);
     } 
      bool allZero = true;
     foreach(var item in A){
         if(item > 0){
             allZero = false;
             break;
         }
     } 
     if(allZero){return "0";}
     List<string> str = A.ConvertAll<string>(delegate(int i) { return i.ToString(); });  //coverting list of int to list of string
     str.Sort(compare);                                               //comparision sort
     string result ="";
     for(int i =str.Count-1; i>=0;i--){ 
         result+=str[i];
     }
     return result;
    }
    
    public int compare(string a, string b){ 
        string ab =a+b;
        string ba =b+a;
        return ab.CompareTo(ba); 
    }
}

