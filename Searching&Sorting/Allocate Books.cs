Given an array of integers A of size N and an integer B.
College library has N bags,the ith book has A[i] number of pages.
You have to allocate books to B number of students so that maximum number of pages alloted to a student is minimum.
A book will be allocated to exactly one student.
Each student has to be allocated at least one book.
Allotment should be in contiguous order, for example: A student cannot be allocated book 1 and book 3, skipping book 2.
Calculate and return that minimum possible number.
NOTE: Return -1 if a valid assignment is not possible.
Input Format
The first argument given is the integer array A.
The second argument given is the integer B.
Output Format
Return that minimum possible number
Constraints
1 <= N <= 10^5
1 <= A[i] <= 10^5
For Example
Input 1:
    A = [12, 34, 67, 90]
    B = 2
Output 1:
    113
Explanation 1:
    There are 2 number of students. Books can be distributed in following fashion : 
        1) [12] and [34, 67, 90]
        Max number of pages is allocated to student 2 with 34 + 67 + 90 = 191 pages
        2) [12, 34] and [67, 90]
        Max number of pages is allocated to student 2 with 67 + 90 = 157 pages 
        3) [12, 34, 67] and [90]
        Max number of pages is allocated to student 1 with 12 + 34 + 67 = 113 pages
        Of the 3 cases, Option 3 has the minimum pages = 113.
Input 2:
    A = [5, 17, 100, 11]
    B = 4
Output 2:
    100
    
    
    
class Solution {
    public int books(List<int> A, int B) { 
        return getmin(A,B);
    }
    
    private int getmin(List<int> A,int B){
        
        int n = A.Count;
        //if more students are there than the number of books
        if(n<B){
            return -1;
        }
        long sum = 0;
        
        foreach(var item in A){
            sum+=item;
        }
        int result = int.MaxValue;
        
        int start = 0,end = (int)sum;
        
        while(start<=end){
            
            int mid = (start+end)/2;
            
            if (isPossible(A, n, B, mid))
            {
                result = Math.Min(result, mid);
      
                // going left to find possible min less than current min
                end = mid - 1;
            } 
            else
                // if not possible means pages should be increased   
                start = mid + 1;
            } 
            return result; 
    }
    
     private bool isPossible(List<int> A,int n, int B,int mid){
         
          int studentsrequired = 1; //A book will be allocated to exactly one student.
          int currentsum = 0;
          
          for(int i=0;i<n;i++){
              
              if(A[i]>mid){
                  return false;
              } 
              
            if (currentsum + A[i] > mid)
            {
                // incrementing student count
                studentsrequired++;
      
                // update curr_sum
                currentsum = A[i];
      
                // if students required becomes 
                // greater than given no. of 
                // students, return false
                if (studentsrequired > B)
                    return false;
            } 
            else{
                 currentsum += A[i]; 
            } 
         } 
         return true;
     } 
}
       
    
      
    
