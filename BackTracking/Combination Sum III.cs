/*
Find all valid combinations of k numbers that sum up to n such that the following conditions are true:
Only numbers 1 through 9 are used.
Each number is used at most once.
Return a list of all possible valid combinations. The list must not contain the same combination twice, and the combinations may be returned in any order.
Example 1:
Input: k = 3, n = 7
Output: [[1,2,4]]
Explanation:
1 + 2 + 4 = 7
There are no other valid combinations.
Example 2:
Input: k = 3, n = 9
Output: [[1,2,6],[1,3,5],[2,3,4]]
Explanation:
1 + 2 + 6 = 9
1 + 3 + 5 = 9
2 + 3 + 4 = 9
There are no other valid combinations.
Example 3:
Input: k = 4, n = 1
Output: []
Explanation: There are no valid combinations.
Using 4 different numbers in the range [1,9], the smallest sum we can get is 1+2+3+4 = 10 and since 10 > 1, there are no valid combination.
*/

public class Solution {
    List<IList<int>> res;
    public IList<IList<int>> CombinationSum3(int k, int n) {
         res = new List<IList<int>>();
         UpdateList(k,n,1,new List<int>());
        return res;
    }
    
    void UpdateList(int k,int n,int start,List<int> cur){
        if(n<0){
            return;
        }
        if(n==0 && cur.Count == k){
            res.Add(new List<int>(cur));
            return;
        }
        if(cur.Count>k){
            return;
        }
        for(int i=start;i<=9;i++){
            if(cur.Count<k){
                cur.Add(i);
                UpdateList(k,n-i,i+1,cur);
                cur.RemoveAt(cur.Count-1); 
            }
        }
    }
}
