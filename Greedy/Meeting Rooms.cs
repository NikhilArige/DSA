//Given an 2D integer array A of size N x 2 denoting time intervals of different meetings.
//Where:
//A[i][0] = start time of the ith meeting.
//A[i][1] = end time of the ith meeting.
//Find the minimum number of conference rooms required so that all meetings can be done

//A =  [     [1, 18]        Output = 4  
//           [18, 23]
//            [15, 29]
//            [4, 15]
//            [2, 11]
//            [5, 13]
//      ]

 //Meeting one can be done in conference room 1 from 1 - 18.
 //Meeting five can be done in conference room 2 from 2 - 11.
 //Meeting four can be done in conference room 3 from 4 - 15.
 //Meeting six can be done in conference room 4 from 5 - 13.
 //Meeting three can be done in conference room 2 from 15 - 29 as it is free in this interval.
 //Meeting two can be done in conference room 4 from 18 - 23 as it is free in this interval.
 
 
 class Solution {
    public int solve(List<List<int>> A) {
        int n = A.Count;
        List<int>a = new List<int>();
        List<int>b = new List<int>();
        foreach(var item in A){
            a.Add(item[0]);
            b.Add(item[1]);
        }
        a.Sort();
        b.Sort();
        int c = a.Count;
        int cnt = 1;
        int result = 1;
        int i = 1;int j=0;
        while(i<c && j<c){
            if(a[i]<b[j]){
                cnt++;
                i++;
            }
            else if(a[i] >=b[j]){                                //incresing count when overlapped and vice versa
                cnt--;
                j++;
            } 
            result = Math.Max(cnt,result);
        }
        return result;
    }
}

