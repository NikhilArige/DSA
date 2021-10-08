/*
Design a data structure that supports adding new words and finding if a string matches any previously added string.
Implement the WordDictionary class:
WordDictionary() Initializes the object.
void addWord(word) Adds word to the data structure, it can be matched later.
bool search(word) Returns true if there is any string in the data structure that matches word or false otherwise. 
word may contain dots '.' where dots can be matched with any letter.
Example:
Input
["WordDictionary","addWord","addWord","addWord","search","search","search","search"]
[[],["bad"],["dad"],["mad"],["pad"],["bad"],[".ad"],["b.."]]
Output
[null,null,null,null,false,true,true,true]
Explanation
WordDictionary wordDictionary = new WordDictionary();
wordDictionary.addWord("bad");
wordDictionary.addWord("dad");
wordDictionary.addWord("mad");
wordDictionary.search("pad"); // return False
wordDictionary.search("bad"); // return True
wordDictionary.search(".ad"); // return True
wordDictionary.search("b.."); // return True
*/

public class WordDictionary {

    public class Trie{
        public bool isEnd ;
        public char Val;
        public Dictionary<char,Trie> Children;
        
        public Trie(){
            this.isEnd = true;
            this.Val = '#';
            this.Children = new Dictionary<char,Trie>();
        }
        public Trie(char ch)
        {
            this.Val = ch;
            this.isEnd = false;
            this.Children = new Dictionary<char, Trie>();
        }
    }
    
    public Trie root;
    public WordDictionary() {
        
        root = new Trie();
    }
    
    public void AddWord(string word) {
        
        var cur = root;
        foreach(var item in word){
            if(!cur.Children.ContainsKey(item)){
                var newtrie = new Trie(item);
                cur.Children.Add(item,newtrie);
            }
            cur = cur.Children[item];
        }
        cur.isEnd = true;
        
    }
    
    public bool Search(string word, Trie temp = null, int i = -1) {
        if(temp==null) temp = root;
        while(++i < word.Length)
        {
            var ch = word[i];
            if(ch!='.')
            {
                if(!temp.Children.ContainsKey(ch)) return false;
                temp = temp.Children[ch];
            }
            else
            {
                foreach(var possibleChild in temp.Children.Values)
                    if(Search(word,possibleChild,i)) return true;
                return false;
            }
        }
        return temp.isEnd;
    }
}

/**
 * Your WordDictionary object will be instantiated and called as such:
 * WordDictionary obj = new WordDictionary();
 * obj.AddWord(word);
 * bool param_2 = obj.Search(word);
 */
