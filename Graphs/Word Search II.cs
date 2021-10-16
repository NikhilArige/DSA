/*
Given an m x n board of characters and a list of strings words, return all words on the board.
Each word must be constructed from letters of sequentially adjacent cells, where adjacent cells are horizontally or vertically neighboring. 
The same letter cell may not be used more than once in a word.
Example 1:
Input: board = [["o","a","a","n"],["e","t","a","e"],["i","h","k","r"],["i","f","l","v"]], words = ["oath","pea","eat","rain"]
Output: ["eat","oath"]
Example 2:
Input: board = [["a","b"],["c","d"]], words = ["abcb"]
Output: []
*/

public class Solution {
    public IList<string> FindWords(char[][] board, string[] words) {
        
        var res = new List<string>();

		foreach(var word in words)
		{
			var found = false;
			for (var i = 0; i < board.Length; i++)
			{
				for (var j = 0; j < board[i].Length; j++)
				{
				   if ( board[i][j] == word[0] && Dfs(i,j,word, 0,board))
				   {
						res.Add(word);
						found = true;
						break;
					}
				}
				if (found == true) break;
			}
		}
		return res;
    }
    
    
        bool Dfs(int i, int j, string word, int start,char[][] board){
                if (start == word.Length){
                  return true;  
                } 

                 if (i < 0 || i >= board.Length || j < 0 || j >= board[i].Length 
                     || board[i][j] != word[start])
                    return false;

                board[i][j] = '#';
                var result = Dfs(i - 1, j, word, start + 1,board)
                            || Dfs(i + 1, j, word, start + 1,board)
                            || Dfs(i, j + 1, word, start + 1,board)
                            || Dfs(i, j - 1, word, start + 1,board);
                board[i][j] = word[start];
                return result;
		}
}

//getting TLE for this
public class Solution {
    public IList<string> FindWords(char[][] board, string[] words) {
        
        var res = new HashSet<string>();
        if(board.Length == 0 || board == null || words.Length ==0){
            return res.ToList();
        }
        var trie = new Trie();
        foreach(var item in words){
            trie.Add(item);
        }
        var temp = new List<char>();
        foreach(var item in words){
           for(int i=0;i<board.Length;i++){
            for(int j=0;j<board[0].Length;j++){
                if(board[i][j] == item[0]){
                   DFS(board,res,temp,i,j,trie); 
                }
            }
         } 
        }
        
        return res.ToList();
    }
    
    void DFS(char[][] board,HashSet<string> res,List<char> temp,int i,int j,Trie trie){
        
        if(i<0 || i>= board.Length || j<0 || j>= board[0].Length || !trie.PrefixExists(temp)){
            return;   
        }
        
        var orig = board[i][j];
        temp.Add(orig);
        
        if(trie.WordExists(temp)){
            res.Add(new string(temp.ToArray()));
        }
         
        board[i][j] = '#';
        
         DFS(board,res,temp,i+1,j,trie);
         DFS(board,res,temp,i,j+1,trie);
         DFS(board,res,temp,i-1,j,trie);
         DFS(board,res,temp,i,j-1,trie);
  
        board[i][j] = orig;
        temp.RemoveAt(temp.Count - 1);
        
    }
    
    
    
    public class Trie{
        
        public class Node{
            public char val;
            public Dictionary<char,Node> children;
            public bool isEnd;
            public Node(char c){
                this.val = c;
                this.isEnd = false;
                this.children = new Dictionary<char, Node>();
            }
        }
        
       public  Node root = new Node('.');
        
        public void Add(string word){
         
            var cur = root;
            foreach(var ch in word){
                if(!cur.children.ContainsKey(ch)){
                    cur.children.Add(ch,new Node(ch));
                }
                cur=cur.children[ch];
            }
            cur.isEnd = true;
        }
        
        public bool PrefixExists(List<char> word){
            
            var cur = root;
            foreach(var ch in word){
                if(!cur.children.ContainsKey(ch)){
                    return false;
                }
                cur = cur.children[ch];
            }
            return true;
        }
        
         public bool WordExists(List<char> word){
            var cur = root;
            foreach(var ch in word){
                if(!cur.children.ContainsKey(ch)){
                    return false;
                }
                cur = cur.children[ch];
            }
            return cur.isEnd;
        }
        
    }
}
