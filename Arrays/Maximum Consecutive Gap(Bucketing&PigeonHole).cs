Given an unsorted array, find the maximum difference between the successive elements in its sorted form.
Try to solve it in linear time/space.
Example :
Input : [1, 10, 5]
Output : 5 


class Solution {
    public int maximumGap(List<int> A) {
        int min = int.MaxValue;
        int max = int.MinValue;
        foreach(var item in A){
            min = Math.Min(item,min);
            max = Math.Max(item,max);
        }
        int n = A.Count;  
        //buckets to store elements in range
        int[] minBucket = new int[n-1]; //n-1 buckets
        int[] maxBucket = new int[n-1];
        for(int i=0;i<n-1;i++){
            minBucket[i] = int.MaxValue;
            maxBucket[i] = int.MinValue;
        } 
        float delta = ((float)(max-min)/(float)(n-1));
        
        for(int i=0;i<n;i++){
            
            if(A[i]==min || A[i]==max){
                continue;
            } 
            int index= (int)(((A[i]-min)/delta)); //getting the bucket to which element belongs to
            minBucket[index]= Math.Min(A[i],minBucket[index]);
            maxBucket[index]= Math.Max(A[i],maxBucket[index]);
        }
        
        int result = 0;
        int prev = min;
        for(int i = 0;i<n-1;i++){
            
            if(minBucket[i]== int.MaxValue){
                continue;
            } 
            result = Math.Max(result,minBucket[i]-prev);
            prev = maxBucket[i];
        }
        //for last element
        result = Math.Max(result,max-prev);
        return result;
    }
}
