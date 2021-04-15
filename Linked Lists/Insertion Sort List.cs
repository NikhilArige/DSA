//Sort a linked list using insertion sort.

/**
 * Definition for singly-linked list.
 * class ListNode {
 *     public int val;
 *     public ListNode next;
 *     ListNode(int x) { val = x; next = null; }
 * }
 */
public class Solution {
      ListNode sorted = null;
      public ListNode insertionSortList(ListNode A) {
       if(A.next ==null){
           return A;
       } 
      ListNode cur = A;
      while(cur!=null){
          ListNode next = cur.next;
          sort(cur);
          cur= next;
      } 
      return sorted;  
    } 
    public void sort(ListNode newnode){
        
        if(sorted == null || newnode.val < sorted.val){
            newnode.next = sorted;
            sorted = newnode;
        } 
        else{
            ListNode cur = sorted;
            while(cur.next!=null && cur.next.val < newnode.val){
                cur=cur.next;  
            }
            newnode.next = cur.next;
            cur.next=newnode; 
        }
         
    }
}
