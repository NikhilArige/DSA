/* Find the largest continuous sequence in a array which sums to zero.
Example:
Input:  {1 ,2 ,-2 ,4 ,-4}
Output: {2 ,-2 ,4 ,-4}
 NOTE : If there are multiple correct answers, return the sequence which occurs first in the array. */


class Solution {
    public List<int> lszero(List<int> A) {
        
        int start = -1;
        int i = -1;
        int end = -1;
        int maxlength = 0;
        Dictionary<int,int> dic = new Dictionary<int,int>();
        int sum = 0;
        dic.Add(sum,i);
        while(i<A.Count-1){
            i++;
            sum+=A[i];
            if(!dic.ContainsKey(sum)){
                dic.Add(sum,i);
            }
            else{
                int len = i-dic[sum];
                if(len>maxlength){
                    maxlength = len;
                    start = dic[sum]+1;
                    end = i;
                }
            } 
        }  
        List<int> res = new List<int>();
            
            if(start==-1 && end==-1){ //when nothing is found
                return res;
            }
            
            else{
                 for(int j=start;j<=end;j++){
                 res.Add(A[j]);
                 }
            } 
        return res;
    }
}

//count of sub arrays with sum 0
       int sum=0;
        int count = 0;
        var set =  new Dictionary<int,int>();
        set.Add(0,1);
        for(int i=0;i<A.Length;i++){
            sum+=A[i];
            if(set.ContainsKey(sum)){
               count+=set[sum]; 
               set[sum]++;
            } 
            else{
                set.Add(sum,1);
            } 
        }
        return count; 

 
