/*Given an array of strings, return all groups of strings that are anagrams. Represent a group by a list of integers representing the index in the original list. Look at the sample case for clarification.
Anagram : a word, phrase, or name formed by rearranging the letters of another, such as 'spar', formed from 'rasp' 
Note: All inputs will be in lower-case. 
Example :
Input : cat dog god tca
Output : [[1, 4], [2, 3]]
cat and tca are anagrams which correspond to index 1 and 4.
dog and god are another set of anagrams which correspond to index 2 and 3.
The indices are 1 based ( the first element has index 1 instead of index 0).*/


using System.Linq;
using System.Collections.Generic;
class Solution {
    public List<List<int>> anagrams(List<string> A) {
          
         List<List<int>> result = new List<List<int>>();
         
         Dictionary<string,List<int>> dict = new Dictionary<string,List<int>>();
         
         for(int i=0;i<A.Count;i++){
            //sorting elements in string or we can change string to chararray and sort
            //string val = String.Concat(A[i].OrderBy(c => c)); 
            //Here the above one
            
            was not working, so used char[] instead
            char[] ch = A[i].ToCharArray();
            Array.Sort(ch);
            string val = new string(ch);
            if(!dict.ContainsKey(val)){
                dict.Add(val,new List<int>{i+1});
            }
            else{
                dict[val].Add(i+1);
            } 
         } 
         
         foreach(var item in dict){
             result.Add(dict[item.Key]);
         } 
         return result;
          
    }
}
