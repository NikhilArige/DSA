/*
Design an algorithm that accepts a stream of characters and checks if a suffix of these characters is a string of a given array of strings words.
For example, if words = ["abc", "xyz"] and the stream added the four characters (one by one) 'a', 'x', 'y', and 'z', 
your algorithm should detect that the suffix "xyz" of the characters "axyz" matches "xyz" from words.
Implement the StreamChecker class:
StreamChecker(String[] words) Initializes the object with the strings array words.
boolean query(char letter) Accepts a new character from the stream and returns true if any non-empty suffix from the stream forms a word that is in words.
Example 1:
Input
["StreamChecker", "query", "query", "query", "query", "query", "query", "query", "query", "query", "query", "query", "query"]
[[["cd", "f", "kl"]], ["a"], ["b"], ["c"], ["d"], ["e"], ["f"], ["g"], ["h"], ["i"], ["j"], ["k"], ["l"]]
Output
[null, false, false, false, true, false, true, false, false, false, false, false, true]
Explanation
StreamChecker streamChecker = new StreamChecker(["cd", "f", "kl"]);
streamChecker.query("a"); // return False
streamChecker.query("b"); // return False
streamChecker.query("c"); // return False
streamChecker.query("d"); // return True, because 'cd' is in the wordlist
streamChecker.query("e"); // return False
streamChecker.query("f"); // return True, because 'f' is in the wordlist
streamChecker.query("g"); // return False
streamChecker.query("h"); // return False
streamChecker.query("i"); // return False
streamChecker.query("j"); // return False
streamChecker.query("k"); // return False
streamChecker.query("l"); // return True, because 'kl' is in the wordlist
Constraints:
1 <= words.length <= 2000
1 <= words[i].length <= 2000
words[i] consists of lowercase English letters.
letter is a lowercase English letter.
At most 4 * 104 calls will be made to query.
*/

public class StreamChecker {

    int maxLength;
    Trie trie;
    StringBuilder sb;
    public StreamChecker(string[] words) {
        
        trie = new Trie();
        maxLength= 0;
        sb = new StringBuilder();
        foreach(var item in words){
           maxLength = Math.Max(maxLength,item.Length); 
            trie.Insert(new string(item.Reverse().ToArray()));
        }
       
    }
    
    public bool Query(char letter) {
        
        sb.Insert(0,letter);
        
        if(sb.Length>maxLength){
            sb.Remove(sb.Length-1,1);
        }
        return trie.ContainsWord(sb.ToString());
    }
    
    public class Trie{
        
        public class TrieNode{
            
            public char val;
            public bool isEnd;
            public Dictionary<char,TrieNode> children;
            
            public TrieNode(){
                  
                this.children = new Dictionary<char,TrieNode>();
                
            }
            public TrieNode(char ch){
                
                this.val = ch;
                this.isEnd = false;
                this.children = new Dictionary<char,TrieNode>();
                
            }
            
        }
        
        TrieNode root = new TrieNode(); 
        
        public void Insert(string word){
            
            var cur = root;
            
            foreach(var item in word){
                
                if(!cur.children.ContainsKey(item)){
                    
                     var newnode = new TrieNode(item);
                    cur.children.Add(item,newnode);
                }
                 cur = cur.children[item];
                
            }
            cur.isEnd = true;
        }
        
        public bool ContainsWord(string word)
       {
            var current = root;
            foreach (var item in word)
            { 
               if(current.isEnd){
                   return true;                      //for prefix consider case 'f' in given example
               } 
               if (!current.children.ContainsKey((item)))
                {
                    return false;
                }
                    current = current.children[item];
                }
                return current.isEnd;
            }
        
    }
}

