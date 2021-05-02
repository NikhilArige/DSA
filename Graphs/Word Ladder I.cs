/* Given two words A and B, and a dictionary, C, find the length of shortest transformation sequence from A to B, such that:
You must change exactly one character in every transformation.
Each intermediate word must exist in the dictionary.
Note:
Return 0 if there is no such transformation sequence.
All words have the same length.
All words contain only lowercase alphabetic characters.
Input Format:
The first argument of input contains a string, A.
The second argument of input contains a string, B.
The third argument of input contains an array of strings, C.
Output Format:
Return an integer representing the minimum number of steps required to change string A to string B.
Input 1:
    A = "hit"
    B = "cog"
    C = ["hot", "dot", "dog", "lot", "log"]
Output 1:
    5
Explanation 1:
    "hit" -> "hot" -> "dot" -> "dog" -> "cog" */
    
 class Solution {
    public int solve(string A, string B, List<string> list) {
        
        HashSet<string> C = new HashSet<string>();
        
        foreach(var item in list){
            C.Add(item);             //storing in HashSet because of TLE with List
        }
        
        if(A==B){
            return 0;
        } 
        int level = 0,n = A.Length;
        
        Queue<string> q = new Queue<string>();
        
        q.Enqueue(A);
        
        while(q.Count!=0){
            
            level++;
            
            int size = q.Count;
            
              for (int i = 0; i < size;i++)  { 
                     string str = q.Dequeue();
                     char[] word = str.ToCharArray();
                      for (int pos = 0; pos < n;pos++){  
                            char orig_char = word[pos];
                                for(char c = 'a';c<='z';c++){ 
                                    word[pos] = c;
                                    string s = new string(word);
                                    if(s == B){
                                        return level + 1;
                                    }
                                    if(!C.Contains(s)){
                                        continue;
                                    }
                                    else{
                                        q.Enqueue(s);
                                        C.Remove(s);
                                    } 
                                } 
                        // restoring the current position
                        word[pos] = orig_char;
                    }  
              }     
        }
        return 0;
    }
}


