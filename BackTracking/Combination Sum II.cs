/*Given a collection of candidate numbers (C) and a target number (T), find all unique combinations in C where the candidate numbers sums to T.
Each number in C may only be used once in the combination.
 Note:
All numbers (including target) will be positive integers.
Elements in a combination (a1, a2, … , ak) must be in non-descending order. (ie, a1 ≤ a2 ≤ … ≤ ak).
The solution set must not contain duplicate combinations.
Example :
Given candidate set 10,1,2,7,6,1,5 and target 8,
A solution set is:
[1, 7]
[1, 2, 5]
[2, 6]
[1, 1, 6] */

using System.Collections.Generic;
using System.Linq;
class Solution {
    public List<List<int>> combinationSum(List<int> A, int B) {
        A.Sort();
        List<int> unique = A.Distinct().ToList();
        List<List<int>> result = new List<List<int>>(); 
        List<int> res = new List<int>(); 
        GetSubSets(A,result,res,0,B); 
        return result;
         
    }
    
    public void GetSubSets(List<int> A,List<List<int>> result,List<int> res,int start,int B){
        
        if(B<0){
            return;
        } 
        if(B==0){
        result.Add(new List<int>(res));
        }
        for(int i=start;i< A.Count;i++){ 
            if(i==start || A[i]!=A[i-1]) {
               res.Add(A[i]); 
              GetSubSets(A,result,res,i+1,B-A[i]); 
              res.RemoveAt(res.Count - 1); 
            } 
        } 
    }
}
