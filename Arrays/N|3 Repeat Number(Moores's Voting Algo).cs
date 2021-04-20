/*You’re given a read only array of n integers. Find out if any integer occurs more than n/3 times in the array in linear time and constant additional space.
If so, return the integer. If not, return -1.
If there are multiple solutions, return any one.
Input : [1 2 3 1 1]
Output : 1 
1 occurs 3 times which is more than 5/3 times.*/

public class Solution {
	// DO NOT MODIFY THE LIST
	public int repeatedNumber(List<int> arr) {
	    
	    int n = A.Count;
	    int count1 = 0, count2 = 0;
 
        int first =  int.MaxValue;  //taking int.max and assuming it wont be there in array
        int second = int.MaxValue;
     
        for (int i = 0; i < n; i++) {
      
            if (first == arr[i]){
                      count1++;
                }
            // if this element is previously
            // seen, increment count2.
            else if (second ==  arr[i]){
                count2++;
                }
            else if (count1 == 0) {
                count1++;
                first =  arr[i];
            }
     
            else if (count2 == 0) {
                count2++;
                second =  arr[i];
            }
     
            // if current element is different
            else {
                count1--;
                count2--;
            }
        }
     
        count1 = 0;
        count2 = 0;
     
        //verifying 
        for (int i = 0; i < n; i++) {
            if ( arr[i] == first)
                count1++;
     
            else if ( arr[i] == second)
                count2++;
        }
     
        if (count1 > n / 3){
            return first;}
     
        if (count2 > n / 3){
            return second;}
     
        return -1;
	}
}



