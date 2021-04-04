//Given an array of size n, find the majority element. The majority element is the element that appears more than floor(n/2) times.
//You may assume that the array is non-empty and the majority element always exist in the array.
//Input : [2, 1, 2] Return  : 2 which occurs 2 times which is greater than 3/2. 


//using Dictionary
class Solution {
    public int majorityElement(List<int> A) {
        int n = A.Count;
        int l = n/2;
        if(n==1){return A[0];}
        Dictionary<int,int> dic = new Dictionary<int,int>(); 
        for(int i=0;i<n;i++){
            if(dic.ContainsKey(A[i])){
                int cnt = dic[A[i]]+1;
                if(cnt > l){
                    return A[i];
                }
                dic[A[i]]=cnt;
            }
            else{
                dic.Add(A[i],1);
            }
        }
        return 0;
    }
}

//using Moore`s voting Algo
class Solution {
    public int majorityElement(List<int> A) {
        int n = A.Count; 
        int num =findNum(A,n);
        if(checknum(A,num)){
            return num;
        }
        else{
            return 0;
        }
    } 
    public int findNum(List<int> A,int n){
        int maj = 0;
        int cnt = 1;
        for(int i=0;i<n;i++){
            if(A[maj]==A[i]){
                cnt++;
            }
            else{
                cnt--;
            } 
            if(cnt==0){
               maj = i;      //updating maj when count becomes 0
               cnt = 1;
            }
        }
        return A[maj];
    } 
    public bool checknum(List<int> A,int num){
         
         int cnt = 0;
         for(int i=0;i<A.Count;i++){
             if(A[i]==num){
                 cnt++;                         
             }
         } 
         if(cnt>A.Count/2){return true;} //checking if the num is correct or not
         else{return false;} 
     } 
}



