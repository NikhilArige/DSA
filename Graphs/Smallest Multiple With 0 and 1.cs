/*You are given an integer N. You have to find smallest multiple of N which consists of digits 0 and 1 only. Since this multiple could be large, return it in form of a string.
Note:
Returned string should not contain leading zeroes.
For example,
For N = 55, 110 is smallest multiple consisting of digits 0 and 1.
For N = 2, 10 is the answer. */
//getting TLE with this
using System.Text;
class Solution {
    public class numb{
        public string num;
        public int rem;
        public numb(string num,int rem){
            this.num = num;
            this.rem = rem;
        }
    }
    public string multiple(int A) {
        
        Queue<numb> q = new Queue<numb>();
        HashSet<int> visited = new HashSet<int>(); 
        int remfor1 = 1;
        if(A==1){
            remfor1=0;
        }
        numb n = new numb("1",remfor1); 
        StringBuilder currNum1 = new StringBuilder();
        StringBuilder currNum2 = new StringBuilder();
        q.Enqueue(n);
        visited.Add(1);
        while(q.Count!=0){ 
            numb str = q.Dequeue();
            int currRemain = str.rem;  
            currNum1.Append(str.num);
            currNum2.Append(str.num);
            if(currRemain == 0){
               return currNum1.ToString(); 
            }
            if(!visited.Contains((currRemain*10)%A)){
                currNum1.Append("0");
                numb next = new numb(currNum1.ToString(), (currRemain*10)%A );
                q.Enqueue(next);
                visited.Add((currRemain*10)%A);
            }   
            if( !visited.Contains((currRemain*10 +1) % A)){
                currNum2.Append("1");
                numb next = new numb(currNum2.ToString(), (currRemain*10+1)%A ); 
                q.Enqueue(next);
                visited.Add((currRemain*10+1)%A);
            }
            currNum1.Length = 0;
            currNum2.Length = 0; 
        }
        
        return "-1";
    }
   
}

//getting TLE with this too
class Solution {
    Dictionary<string,int> remin = new Dictionary<string,int>(); 
    public string multiple(int A) {
        
        Queue<String> q = new Queue<String>();
        HashSet<int> visited = new HashSet<int>(); 
        string t = "1";
        
        q.Enqueue(t);
        while(q.Count!=0){ 
            string str = q.Dequeue();
            int rem = mod(str,A);
            if(rem == 0){
                return str;
            }
            //if reminder doesnt exist in map 
            else if(!visited.Contains(rem))
            {
              visited.Add(rem);
              q.Enqueue(str + "0");
              q.Enqueue(str + "1");
            }
                    
        }
        
        return "-1";
    }
    
    private int mod(string t,int N)
    {
      int r = 0;
      string sub =t.Substring(0,t.Length-1);  
      if(remin.ContainsKey(sub)){ 
         r = remin[sub]* 10 + (t[t.Length-1] - '0');
         r %= N;
      } 
      else{
         for(int i=0;i< t.Length; i++)
          {
            r = r * 10 + (t[i] - '0');
            r %= N;
          }  
      }
      remin.Add(t,r);
      return r;
    }
}
