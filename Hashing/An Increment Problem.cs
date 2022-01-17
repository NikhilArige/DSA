/*
Given a stream of numbers A. On arrival of each number, you need to increase its first occurence by 1 and include this in the stream.
Return the final stream of numbers.
Problem Constraints
1 <= |A| <= 100000
1 <= A[i] <= 10000
Input Format
First and only argument is the array A.
Output Format
Return an array, the final stream of numbers.
Example Input
Input 1:
A = [1, 1]
Input 2:
A = [1, 2]
Example Output
Output 1:
[2, 1]
Output 2:
[1, 2]
*/

class Solution {
    public List<int> solve(List<int> A) {
        
        var list = new List<int>();
        var map = new Dictionary<int,int>();
        for(int i=0;i<A.Count;i++){
            var cur = A[i];
            if(map.ContainsKey(cur)){
                var val = list[map[cur]];
                var newval = val+1;
                list[map[cur]] = newval;
                if(!map.ContainsKey(newval)){
                    map.Add(newval,map[cur]);
                } 
                else{
                    if(map[newval>map[cur]){
                        map[newval] = map[cur];
                    } 
                }
                map[cur] = i;
            }
            else{
                map.Add(cur,i);
            } 
            list.Add(cur);
        }
        return list;
    }
}
