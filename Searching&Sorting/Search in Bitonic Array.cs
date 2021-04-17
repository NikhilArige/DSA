/*Given a bitonic sequence A of N distinct elements, write a program to find a given element B in the bitonic sequence in O(logN) time.
NOTE:A Bitonic Sequence is a sequence of numbers which is first strictly increasing then after a point strictly decreasing.
A = [3, 9, 10, 20, 17, 5, 1]
B = 20
Input 2:
A = [5, 6, 7, 8, 9, 10, 3, 2, 1]
B = 30
Example Output
Output 1:3
Output 2:-1*/


class Solution {
    public int solve(List<int> arr, int B) { 
        int n, l, r;
        n = arr.Count;
        l = 0;
        r = n - 1;
        int index;
        index = findBitonicPoint(arr, n, l, r);
        return searchBitonic(arr, n, B, index); 
    }
    
    private int searchBitonic(List<int> arr, int n, int key, int index)
    {
        if (key > arr[index])
        {
            return -1;
        }
        else if (key == arr[index])
        {
            return index;
        }
        else {
            int temp = ascendingBinarySearch(arr, 0, index - 1, key);
            if (temp != -1) {
                return temp;
            } 
            return descendingBinarySearch(arr, index + 1,
                                          n - 1, key);
        }
    }
    
    private int findBitonicPoint(List<int> arr, int n, int l, int r)
    {
    int mid;
    int bitonicPoint = 0;
    mid = (r + l) / 2;
    if (arr[mid] > arr[mid - 1] && arr[mid] > arr[mid + 1])
    {
        return mid;
    }
 
    else if (arr[mid] > arr[mid - 1]
             && arr[mid] < arr[mid + 1])
    {
        bitonicPoint =  findBitonicPoint(arr, n, mid, r);
    }
 
    else if (arr[mid] < arr[mid - 1]
             && arr[mid] > arr[mid + 1])
    {
        bitonicPoint = findBitonicPoint(arr, n, l, mid);
    }
    return bitonicPoint;
}

private int ascendingBinarySearch(List<int> arr, int low,
                          int high, int key)
{
    while (low <= high)
    {
        int mid = low + (high - low)/2;
        if (arr[mid] == key){
            return mid;}
        if (arr[mid] > key){
            high = mid - 1;}
        else{
            low = mid + 1;}
    }
    return -1;
}
  
private int descendingBinarySearch(List<int> arr, int low,
                           int high, int key)
{
    while (low <= high)
    {
        int mid = low + (high - low) / 2;
        if (arr[mid] == key){
            return mid;}
        if (arr[mid] < key){
            high = mid - 1;}
        else{
            low = mid + 1;}
    }
    return -1;
}
}
