//Given a collection of integers that might CONTAIN DUPLICATES, S, return all possible subsets.
//Note:
//Elements in a subset must be in non-descending order.
//The solution set must not contain duplicate subsets.
//The subsets must be sorted lexicographically.

class Solution {
    public List<List<int>> subsetsWithDup(List<int> A) {
        A.Sort();
        
        List<List<int>> result = new List<List<int>>();
        
        List<int> res = new List<int>();
        
        GetSubSets(A,result,res,0);
        
        return result;
         
    }
    
    public void GetSubSets(List<int> A,List<List<int>> result,List<int> res,int start){
        
        result.Add(new List<int>(res));
        
        for(int i= start;i< A.Count;i++){
            
            if(i > start && A[i] == A[i-1]){      //CHECK FOR DUPLICATES
                continue;                         //SKIPPING ith LOOP IF ITS A DUPLICATE
            }
            
            res.Add(A[i]);
            GetSubSets(A,result,res,i+1);
            res.RemoveAt(res.Count - 1);
        }
      
    }
}
