//Given a string A and a dictionary of words B, determine if A can be segmented into a space-separated sequence of one or more dictionary words.
//Input 1:
//A = "myinterviewtrainer",B = ["trainer", "my", "interview"]   Output:1

//not an optimal soln
class Solution {
    public int wordBreak(string A, List<string> B) {
        
        int n = A.Length;
        
        HashSet<string> hash = new HashSet<string>();
        foreach(var item in B){
            hash.Add(item);
        }
         
        bool[,] dp = new bool[n,n];
        //length from 1 to n
        for(int l=1;l<=n;l++){ 
            for(int i=0;i<=n-l;i++){
                int j = i+l-1;
                string sub = A.Substring(i,l);//ex:substring of length 3 from 0th index => (0,3);  
                if(hash.Contains(sub)){
                    dp[i,j]= true;
                }
                else{
                    //find a k between i+1 to j such that T[i][k-1] && T[k][j] are both true 
                for(int k=i+1; k <= j; k++){
                    if(dp[i,k] != false && dp[k+1,j] != false){
                        dp[i,j] = true;
                        break;
                    }
                }   
                } 
            }   
        }  
       if(dp[0,n-1]){
           return 1;
       } 
       else{
           return 0;
       }
    }
}

//Another approach
class Solution {
    public int wordBreak(string A, List<string> B) {
        
        int n = A.Length;
        
        HashSet<string> hash = new HashSet<string>();
        foreach(var item in B){
            hash.Add(item);
        }
        
        int[] dp = new int[n]; //stores count of ways 
        
        for(int i=0;i<n;i++){
            for(int j=0;j<i;j++){ 
              string prefix = A.Substring(j,i-j+1);
              if(hash.Contains(prefix)){ 
                  if(j>0){
                      dp[i] = dp[j-1];
                  }
                  else{
                      dp[i]+=1;
                  }  
              } 
            } 
        } 
        
       if(dp[n-1]>0){
           return 1;
       } 
       else{
           return 0;
       }
    }
}
