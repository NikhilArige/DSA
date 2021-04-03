//Given a set of distinct integers, S, return all possible subsets.  (No duplicates in input)
//Note:
//Elements in a subset must be in non-descending order.
//The solution set must not contain duplicate subsets.
//Also, the subsets should be sorted in ascending ( lexicographic ) order.
//The list is not necessarily sorted.

class Solution {
    public List<List<int>> subsets(List<int> A) {
        
        A.Sort();
        
        List<List<int>> result = new List<List<int>>();
        
        List<int> res = new List<int>();
        
        GetSubSets(A,result,res,0);
        
        return result;
         
    }
    
    public void GetSubSets(List<int> A,List<List<int>> result,List<int> res,int start){
        
        result.Add(new List<int>(res)); //adding new list of elements in temp list
        
        for(int i= start;i< A.Count;i++){
            
            res.Add(A[i]);
            GetSubSets(A,result,res,i+1);
            res.RemoveAt(res.Count - 1); //removing the item added;A[0] will be removed by the end of first loop and so on
        }
        
         
    }
}
