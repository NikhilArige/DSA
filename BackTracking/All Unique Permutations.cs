/* Given a collection of numbers that might contain duplicates, return all possible unique permutations.
Example :
[1,1,2] have the following unique permutations:
[1,1,2]
[1,2,1]
[2,1,1]
 NOTE : No 2 entries in the permutation sequence should be the same. */
 
 
class Solution {
    public List<List<int>> permute(List<int> A) {
        
       var result = new List<List<int>>();
       GetPermutations(result,A,0,A.Count-1);
       return result; 
    }
    
    private void GetPermutations(List<List<int>> result,List<int> A,int start,int size){
        
        if(start == size){
            result.Add(new List<int>(A));
            return;
        }
          for(int i=start;i<=size;i++){ 
            if(canswap(A,start,i)){   //not swapping if both are sa
                swap(A,start,i);
                GetPermutations(result,A,start+1,size);
                swap(A,start,i); 
            }           
        } 
    }
    
    private void swap(List<int> A,int a,int b){ 
        var temp = A[a];
        A[a] = A[b];
        A[b] = temp;
    }
    
    private bool canswap(List<int> A,int a,int b){ 
        
        for(int i =a;i<b;i++){
            if(A[i]==A[b]){
                return false;
            }
        }
        return true;
    }
}
