/* Given an array A of integers, find the index of values that satisfy A + B = C + D, where A,B,C & D are integers values in the array
Note:
1) Return the indices `A1 B1 C1 D1`, so that 
  A[A1] + A[B1] = A[C1] + A[D1]
  A1 < B1, C1 < D1
  A1 < C1, B1 != D1, B1 != C1 
2) If there are more than one solutions, 
   then return the tuple of values which are lexicographical smallest. 
Assume we have two solutions
S1 : A1 B1 C1 D1 ( these are values of indices int the array )  
S2 : A2 B2 C2 D2
S1 is lexicographically smaller than S2 iff
  A1 < A2 OR
  A1 = A2 AND B1 < B2 OR
  A1 = A2 AND B1 = B2 AND C1 < C2 OR 
  A1 = A2 AND B1 = B2 AND C1 = C2 AND D1 < D2
Example:
Input: [3, 4, 7, 1, 2, 9, 8]
Output: [0, 2, 3, 5] (O index) */


class Solution {
    public class pair{
        
        public int a;
        public int b;
        public pair(int a,int b){
            this.a = a;
            this.b = b;
        }  
    }
    public List<int> equal(List<int> A) {
        
        Dictionary<int,pair> dic = new Dictionary<int,pair>();
        List<int> res = new List<int>();
        for(int i=0;i<A.Count;i++){
            
            for(int j=i+1;j<A.Count;j++){ 
                int sum = A[i]+A[j]; 
                if(!dic.ContainsKey(sum)){ 
                    dic.Add(sum,new pair(i,j));
                }
        
                else{ 
                    int a = dic[sum].a;
                    int b = dic[sum].b;
                    
                    //   Return the indices `A1 B1 C1 D1`, so that 
                    //   A[A1] + A[B1] = A[C1] + A[D1]
                    //   A1 < B1, C1 < D1
                    //   A1 < C1, B1 != D1, B1 != C1 

                    if(a<b && i<j && a<i && b!=j && b!=i){
                        //From Ques
                        // Assume we have two solutions
                        // S1 : A1 B1 C1 D1 ( these are values of indices int the array )  
                        // S2 : A2 B2 C2 D2
                        // S1 is lexicographically smaller than S2 iff
                        //   A1 < A2 OR
                        //   A1 = A2 AND B1 < B2 OR
                        //   A1 = A2 AND B1 = B2 AND C1 < C2 OR 
                        //   A1 = A2 AND B1 = B2 AND C1 = C2 AND D1 < D2
                        
                        if((res.Count==0) || (a<res[0]) ||  (a==res[0] && b<res[1])) 
                        //No need to compare for c1 and d1 as they will surely be in order/
                        {
                            res.Clear();
                            res.Add(a);
                            res.Add(b);
                            res.Add(i);
                            res.Add(j);
                        }
                    }
                } 
            }
        }
        return res;
     }
}
