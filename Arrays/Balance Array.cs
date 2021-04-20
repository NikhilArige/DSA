/*Given an integer array A of size N. You need to count the number of special elements in the given array.
A element is special if removal of that element make the array balanced.
Array will be balanced if sum of even index element equal to sum of odd index element.
A = [2, 1, 6, 4]
Input 2:
A = [5, 5, 2, 5, 8]
Example Output
Output 1:1
Output 2:2
Example Explanation
Explanation 1:
 After deleting 1 from array : {2,6,4}
    (2+4) = (6)
 Hence 1 is the only special element, so count is 1
Explanation 2:
 If we delete A[0] or A[1] , array will be balanced
    (5+5) = (2+8)
 So A[0] and A[1] are special elements, so count is 2. */
 
 class Solution {
    public int solve(List<int> A) {
        
        int evensum=0,oddsum=0,count=0;

        if(A.Count==1) { 
         return 1;}
         
        if(A.Count==2) {
          return 0;}
          
        for(int i=0;i<A.Count;i++){
            if(i%2==0){
              evensum+=A[i]; } //sum of elements at even index
             
            else {
             oddsum+=A[i]; }  //sum of elements at odd index
             }
            //If we remove the 0th element which results in the change in size of array 
            //and thus the elements in even indexes come in odd indexes and vice versa
            int temp=evensum;             
            evensum=oddsum;
            oddsum=temp-A[0];
            if(evensum==oddsum){
                count++; }
            for(int i=1;i<A.Count;i++){ 
            if((i-1)%2==0)
            {
                evensum=evensum+A[i-1]-A[i];   
            } 
            else
             { oddsum=oddsum+A[i-1]-A[i]; }
              
             if(evensum==oddsum)
               { count++; }
             
                  }
          return count;
}}
