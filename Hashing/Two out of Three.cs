/* Given are Three arrays A, B and C.
Return the sorted list of numbers that are present in atleast 2 out of the 3 arrays.
A = [1, 1, 2]
B = [2, 3]
C = [3]
Ans: [2, 3]
Explanation: 1 is only present in A. 2 is present in A and B. 3 is present in B and C. */


class Solution {
    public List<int> solve(List<int> A, List<int> B, List<int> C) {
        
        Dictionary<int,int> dic = new Dictionary<int,int>();
        
        foreach(var item in A){
            if(!dic.ContainsKey(item)){
               dic.Add(item,-1);
            }
        }
        foreach(var item in B){
            if(!dic.ContainsKey(item)){
               dic.Add(item,-2);
            }
            else{
                if(dic[item]==-1){
                    dic[item]= 1;
                }
            }
        }
        foreach(var item in C){
            if(!dic.ContainsKey(item)){
               dic.Add(item,-3);
            }
            else{
                if((dic[item]==-1) || (dic[item]==-2) || (dic[item] == 1)){
                    dic[item]= 2;
                }
            }
        } 
        List<int> result = new List<int>();
        foreach(var item in dic){
            if(dic[item.Key]>0){
                result.Add(item.Key);
            } 
        }
        result.Sort();
        return result; 
    }
}


