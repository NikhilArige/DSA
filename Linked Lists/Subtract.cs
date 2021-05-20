/*Given a singly linked list, modify the value of first half nodes such that :
1st node’s new value = the last node’s value - first node’s current value
2nd node’s new value = the second last node’s value - 2nd node’s current value,
and so on …
 NOTE :
If the length L of linked list is odd, then the first half implies at first floor(L/2) nodes. So, if L = 5, the first half refers to first 2 nodes.
If the length L of linked list is even, then the first half implies at first L/2 nodes. So, if L = 4, the first half refers to first 2 nodes.
Example :
Given linked list 1 -> 2 -> 3 -> 4 -> 5,
You should return 4 -> 2 -> 3 -> 4 -> 5
as
for first node, 5 - 1 = 4
for second node, 4 - 2 = 2
Try to solve the problem using constant extra space. */


/**
 * Definition for singly-linked list.
 * class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {this.val = x; this.next = null;}
 * }
 */
class Solution {
    public ListNode subtract(ListNode A) {
        
        int n = 0;
        ListNode count = A;
        while(count!=null){
            n++;
            count = count.next;
        } 
        ListNode slow = A;
        ListNode fast = A;
        ListNode check = new ListNode();
        while(fast!=null && fast.next!=null){
            check = slow;
            slow = slow.next;
            fast = fast.next.next; 
        }
        
        ListNode front = new ListNode();
        ListNode back = new ListNode();
        front = A;
        if(n%2==0){
            back = check.next;
            check.next = null;
        }
        else{
            back = slow.next;
            slow.next = null; 
        }
       
        back = Reverse(back);
        ListNode tempback = back;  
        while(tempback!=null){ 
            front.val = tempback.val-front.val;
            front = front.next;
            tempback = tempback.next;
        }  
        back = Reverse(back); 
        if(front !=null){
           front.next = back;
           return A;
        }
        else{
            var temp = A;
            while(temp.next!=null){
                temp = temp.next;
            }
            temp.next = back;
            return A;
        } 
    }
    
    private ListNode Reverse(ListNode A){
        
        ListNode prev = null;
        ListNode cur = A;
        ListNode next = new ListNode();
        
        while(cur!=null){
            
            next = cur.next;
            cur.next = prev;
            prev = cur;
            cur = next; 
        } 
        return prev; 
    }
}
