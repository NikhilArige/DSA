//Given two integers n and k, return all possible combinations of k numbers out of 1 2 3 ... n.
//Make sure the combinations are sorted.
//To elaborate,Within every entry, elements should be sorted. [1, 4] is a valid entry while [4, 1] is not.Entries should be sorted within themselves.
//Example :
//If n = 4 and k = 2, a solution is:
//[
//[1,2],
//[1,3],
//[1,4],
//[2,3],
//[2,4],
//[3,4],
//]


class Solution {
    public List<List<int>> combine(int A, int B) {
        
        List<List<int>> result = new List<List<int>>(); 
        if(A<B){
            return result;
        }  
        List<int> res = new List<int>(); 
        GetSubSets(A,result,res,1,B); 
        return result;
         
    }
    
    public void GetSubSets(int A,List<List<int>> result,List<int> res,int start,int B){
         
        if(B==0){
        result.Add(new List<int>(res));
        return;
        } 
        for(int i= start;i<=A;i++){ 
            res.Add(i); 
            GetSubSets(A,result,res,i+1,B-1);
            res.RemoveAt(res.Count - 1); 
        } 
    }
}
