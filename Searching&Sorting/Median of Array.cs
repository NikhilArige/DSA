/*There are two sorted arrays A and B of size m and n respectively.
Find the median of the two sorted arrays ( The median of the array formed by merging both the arrays ).
The overall run time complexity should be O(log (m+n)).
Sample Input:
A : [1 4 5]
B : [2 3]
Sample Output : 3
NOTE: IF the number of elements in the merged array is even, then the median is the average of n / 2 th and n/2 + 1th element.
For example, if the array is [1 2 3 4], the median is (2 + 3) / 2.0 = 2.5 */

public class Solution { 
	public double findMedianSortedArrays(List<int> A,List<int> B) {
	    
	    int x= A.Count;
	    int y= B.Count;
	    if(x>y){
	        return findMedianSortedArrays(B,A);
	    }
	    
	    int low = 0;
	    int high = x;
	    
	   while (low <= high) {
            int partitionX = (low + high)/2;
            int partitionY = (x + y + 1)/2 - partitionX;
            double maxLeftX = (partitionX == 0) ? int.MinValue : A[partitionX - 1];
            double minRightX = (partitionX == x) ? int.MaxValue : A[partitionX];
            double maxLeftY = (partitionY == 0) ? int.MinValue : B[partitionY - 1];
            double minRightY = (partitionY == y) ? int.MaxValue: B[partitionY];
            
            if (maxLeftX <= minRightY && maxLeftY <= minRightX) {
                
                if ((x + y) % 2 == 0) {
                    return ((double)Math.Max(maxLeftX, maxLeftY) + Math.Min(minRightX, minRightY))/2;
                }
                else {
                    return (double)Math.Max(maxLeftX, maxLeftY);
                }
            } 
            else if (maxLeftX > minRightY) { //need to move to left side.
                high = partitionX - 1;
            } 
            else { //need to move to right side.
                low = partitionX + 1;
            } 
	   } 
	}
}



