//N light bulbs are connected by a wire.
//Each bulb has a switch associated with it, however due to faulty wiring, a switch also changes the state of all the bulbs to the right of current bulb.
//Given an initial state of all bulbs, find the minimum number of switches you have to press to turn on all the bulbs.
//You can press the same switch multiple times.
//Note : 0 represents the bulb is off and 1 represents the bulb is on.

//Input : A = [0 1 0 1] Output : 4
//Explanation:
	//press switch 0 : [1 0 1 0]
	//press switch 1 : [1 1 0 1]
	//press switch 2 : [1 1 1 0]
	//press switch 3 : [1 1 1 1]



class Solution {
    public int bulbs(List<int> A) {
        int n = A.Count;
        int cnt = 0;
        for(int i=0;i<n;i++){
        if((cnt == 0 || cnt%2 ==0) && A[i] ==0 ){
            cnt++;
        }
        if((cnt%2 !=0) && A[i] == 1 ){
            cnt++;
        }  
        }
        return cnt;
    }
}

class Solution {
    public int bulbs(List<int> A) { 
        int n = A.Count;
        bool flipped = false;
        int res = 0;
        for(int i=0;i<A.Count;i++){ 
            if((A[i]==0 && !flipped)||(A[i]==1 && flipped)){
                res++;
                flipped = !flipped;
            } 
        }
        return res;
    }
}
