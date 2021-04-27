/*Given a set of digits (A) in sorted order, find how many numbers of length B are possible whose value is less than number C.
NOTE: All numbers can only have digits from the given set. 
Examples:
	Input:
	  0 1 5  
	  1  
	  2  
	Output:  
	  2 (0 and 1 are possible)  

	Input:
	  0 1 2 5  
	  2  
	  21  
	Output:
	  5 (10, 11, 12, 15, 20 are possible)*/


class Solution {
    public int solve(List<int> A, int B, int C) {
        
        int n = A.Count; 
        int numofdigitsinC = 0; 
        int temp=C,count=0,ans=0;
            while(temp>0){
                count++;
                temp/=10;
            }     
        numofdigitsinC = count;
        //case 1
        if((numofdigitsinC < B) ||( n==0 )){
            return 0;
        }
        
        //case 2
        if(numofdigitsinC > B){
            
            if(A[0]==0){
                ans = (n-1)*(int)(Math.Pow(n,B-1));
                //n-1 as first digit can not have 0 and so B-1 is done
            }
             
            else{
                ans = (int)(Math.Pow(n,B)); //we can choose n number of elements in B positions
            } 
            
            if(B==1 && A[0]==0){
                ans++; //if B is 1, 0 can also be included
            } 
            
        }
         
        ///case 3 where B=numofdigitsinC 
        else{
            
            int[] digitsofC = new int[B]; //as B=numofdigitsinC
            for(int i=B-1;i>=0;i--){
               digitsofC[i]=C%10;
               C=C/10;
            }

           count=0; 
           for(int i=0;i<n;i++){
               if(A[i]==0){
                   continue; 
               }
                if(A[i]>digitsofC[0]){
                    break;
                }
                count++;
           } 
           //here, count is the number of digits <= the first digit of C
           //for ex: A={0,1,2,3,4}
           //B = 2
           //C = 23  // count will be 2 ie., 1 and 2 , ignoring 0 as this is for first digit
           // now ans will be combinations sum with 2
           ans+=(count)*(int)(Math.Pow(n,B-1));
           //this may contain extra values also , say 23,24, but we need < 23 only    
            
           int flag = 0,j=0;
           for(int i=0;i<n;i++){
               if(A[i]==digitsofC[j]){
                   flag=1;
                   //checking if 2 is present in A[i],as if 2 is not there means 
                   //count would reduce and values will be till 19 and we can directly return the ans
               }
           }
           j++;  // for digits count
            
           while(flag==1 && j<=B-1){
               flag=0;
               int countx=0;
               for(int i=0;i<n;i++){
                   if(A[i]>digitsofC[j]){
                   countx++;
                   } 
                   if(A[i]==digitsofC[j]){
                       flag=1;               //flag for remaining digits
                   } 
               }
               ans-=((countx)*(int)((Math.Pow(n,B-j-1)))); //removing the extra added values
             j++;
           }  
           
           if(j==B && flag==1){
               ans--;          //we would have removed 24 and all but not 23(the exact C), this is for that
           }
           if(B==1 && A[0]==0){
                ans++; //if B is 1, 0 can also be included
            } 
        }
        return ans;
    }
}

