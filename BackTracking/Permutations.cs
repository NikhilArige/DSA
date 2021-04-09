//Given a collection of numbers, return all possible permutations.
//[1,2,3] will have the following permutations:
//[1,2,3]
//[1,3,2]
//[2,1,3] 
//[2,3,1] 
//[3,1,2] 
//[3,2,1]




class Solution {
    public List<List<int>> permute(List<int> A) {
        
        List<List<int>> result = new List<List<int>>(); 
        Getpermutations(result,A,0,A.Count-1);
        return result; 
    }
    
    public void Getpermutations(List<List<int>> result,List<int> A,int start,int end){
        if(start==end){
            result.Add(new List<int>(A));
        } 
        for(int i=start;i<=end;i++){
            swap(A,start,i);
            Getpermutations(result,A,start+1,end);
            swap(A,start,i);         //swapping it back
        } 
    } 
    public void swap(List<int> A,int i,int j){
        int temp = A[i];
        A[i] = A[j];
        A[j] = temp;
    } 
}


