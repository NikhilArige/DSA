/*Given an array A , representing seats in each row of a stadium. You need to sell tickets to B people.
Each seat costs equal to the number of vacant seats in the row it belongs to. The task is to maximize the profit by selling the tickets to B people.
Input 1:
A = [2, 3]
B = 3
Input 2:
A = [1, 4]
B = 2
Example Output
Output 1:
7
Output 2:
7
A is an array that contains available seats in that row. The ticket price is the number of empty seats in a row.
So looking at the examples.
A = [2, 3] B = 3
There are 2 row with tickets available. The first row has 2 tickets and the second row has 3 tickets. To maximize profit, you want to sell the $3 ticket first. That leaves 2 tickets available in both rows. Since we need to sell 3 tickets.
We’d sell the $3 and $2 ticket from the second row and the $2 ticket from row one. This leaves A[1,1].
A = [1, 4] B = 2
In this case, we take 2 from the second row. The $4 and $3 ticket. This will leave A[1,2] */


class Solution {
    public int solve(List<int> A, int B) {
        
        int n = A.Count;
        int sum = 0;
        // else we need to implement max heap for lesser complexity
        while(B>0){
           A.Sort();
           A.Reverse();
           sum = sum + A[0];
           A[0] = A[0] - 1; 
           B--;
        } 
        return sum;
    }
}
