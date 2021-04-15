//Given a linked list A of length N and an integer B.
//You need to find the value of the Bth node from the middle towards the beginning of the Linked List A.
//If no such element exists, then return -1.
//NOTE:Position of middle node is: (N/2)+1, where N is the total number of nodes in the list.
//A = 3 -> 4 -> 7 -> 5 -> 6 -> 1 6 -> 15 -> 61 -> 16   B = 3
//Explanation : 
//The Middle of the linked list is the node with value 6.
//The 1st node from the middle of the linked list is the node with value 5.
//The 2nd node from the middle of the linked list is the node with value 7.
//The 3rd node from the middle of the linked list is the node with value 4.
//So we will output 4.



/**
 * Definition for singly-linked list.
 * class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {this.val = x; this.next = null;}
 * }
 */
class Solution {
    public int solve(ListNode A, int B) { 
        int n = getCount(A); 
        int reqNode = (n /2)+1 - B; 
        if(reqNode <= 0)
            return -1;
        else
        {
            ListNode current = A;
            int count = 1,ans = 0;
            while (current != null) 
            { 
                if (count == reqNode) 
                {
                    ans = current.val;
                    break; 
                }
                count++; 
                current = current.next; 
            }
            return ans;
        } 
    }
     
     public int getCount(ListNode start)
    {
        ListNode temp = start;
        int cnt = 0;
        while(temp != null)
        {
            temp = temp.next;
            cnt++;
        }
        return cnt;
    }
}
