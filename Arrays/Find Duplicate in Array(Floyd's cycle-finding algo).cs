//Given a read only array of n + 1 integers between 1 and n, find one number that repeats in linear time using less than O(n) space and traversing the stream sequentially O(1) times

class Solution {
    public int repeatedNumber(List<int> A) { 
        int slow = A[0];
        int fast = A[A[0]];
        while(slow!=fast){
            slow = A[slow];
            fast = A[A[fast]];
        }
        slow = 0;
         while(slow!=fast) 
        { 
        slow = A[slow]; 
        fast = A[fast]; 
        } 
       return slow;
    }
}
