//Implementation of Trie 
using System;
using System.Collections.Generic;
public class Trie
{
   public class TrieNode
    { 
        public char Val;
        public bool IsEnd;
        public Dictionary<char, TrieNode> Children;
        public TrieNode()
        {
            this.Val = '#';
            this.IsEnd = true;
            this.Children = new Dictionary<char, TrieNode>();
        }
        public TrieNode(char ch)
        {
            this.Val = ch;
            this.IsEnd = false;
            this.Children = new Dictionary<char, TrieNode>();
        }
    }
    TrieNode root = new TrieNode();
    //Inserts word 
    public void Insert(String word)
    {
            var current = root;
            foreach (var item in word)
            {
                if (!current.Children.ContainsKey(item))
                {
                    var newnode = new TrieNode(item);
                    current.Children.Add(item,newnode);
                }
                current = current.Children[item];
            }
            current.IsEnd = true;
    }
    
    // Search word
    public bool ContainsWord(string word)
   {
        var current = root;
        foreach (var item in word)
        {
           if (!current.Children.ContainsKey((item)))
            {
                return false;
            }
                current = current.Children[item];
            }
            return current.IsEnd;
        }

    //Search Prefix
    public bool ContainsPrefix(string word)
    {
        var current = root;
        foreach (var item in word)
        {
            if (!current.Children.ContainsKey((item)))
             {
                return false;
             }
             current = current.Children[item];
        }
            return true;
        }
	
    //Recursive method to get words
	public void GeneratewordswithPrefix(List<string> str,TrieNode t,string x){
		if(t.IsEnd){
		str.Add(x);
		return;
		}
		foreach(var item in t.Children){
		    GeneratewordswithPrefix(str,item.Value,x+item.Key);
		}
	}
	
    //Gets Trie ending with given prefix
    public TrieNode GetTrie(string word)
    {
        var current = root;
        foreach (var item in word)
        {
            if (!current.Children.ContainsKey((item)))
                {
                    return null;
                }
                current = current.Children[item];
        }
        return current;
    }
       
	//Gets List of words with given prefix
    public List<string> GetListofWords(string word)
    {
        TrieNode triewithprefix= GetTrie(word);
		List<string> result = new List<string>();
		if(triewithprefix != null){
		   GeneratewordswithPrefix(result,triewithprefix,word);
		}
        return result;
    }
	
	public static void Main()
	{ 
        Trie trie = new Trie();
		//Inserting
		trie.Insert("Nick"); 
		trie.Insert("Nikhil");
		trie.Insert("Arige");
		//Searching
		var Find = trie.ContainsWord("Nikhil");
		//Searching Prefix
		var FindPre = trie.ContainsPrefix("Ni");
		Console.WriteLine(Find);
		Console.WriteLine(FindPre);
		List<string> list = new List<string>();
		list = trie.GetListofWords("Ni");
		if(list.Count == 0){
		Console.WriteLine("No words are present with given prefix!");
		}
		else{
			Console.WriteLine("List of words with given prefix are:");
		foreach(var item in list){
		Console.WriteLine(item);
		}
		}
	} 
}
