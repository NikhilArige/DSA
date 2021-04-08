//Given a set of candidate numbers (C) and a target number (T), find all unique combinations in C where the candidate numbers sums to T.
//The same repeated number may be chosen from C unlimited number of times.
//Note:
//All numbers (including target) will be positive integers.
//Elements in a combination (a1, a2, … , ak) must be in non-descending order. (ie, a1 ≤ a2 ≤ … ≤ ak).
//The combinations themselves must be sorted in ascending order.
//CombinationA > CombinationB iff (a1 > b1) OR (a1 = b1 AND a2 > b2) OR … (a1 = b1 AND a2 = b2 AND … ai = bi AND ai+1 > bi+1)
//The solution set must not contain duplicate combinations.



class Solution {
    public List<List<int>> combinationSum(List<int> A, int B) {
        A.Sort();
        List<int> unique = A.Distinct().ToList();   //removing duplicates
        List<List<int>> result = new List<List<int>>();   
        List<int> res = new List<int>(); 
        GetSubSets(unique,result,res,0,B); 
        return result;
         
    }
    
    public void GetSubSets(List<int> A,List<List<int>> result,List<int> res,int start,int B){
        
        if(B<0){                  //base condition
            return;
        } 
        if(B==0){
        result.Add(new List<int>(res));
        }
        for(int i= start;i< A.Count;i++){ 
            res.Add(A[i]); 
            GetSubSets(A,result,res,i,B-A[i]); 
            res.RemoveAt(res.Count - 1); 
        } 
    }
}
