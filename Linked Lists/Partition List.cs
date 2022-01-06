/*Given a linked list and a value x, partition it such that all nodes less than x come before nodes greater than or equal to x.
You should preserve the original relative order of the nodes in each of the two partitions.
For example,
Given 1->4->3->2->5->2 and x = 3,
return 1->2->2->4->3->5.*/

/**
 * Definition for singly-linked list.
 * class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {this.val = x; this.next = null;}
 * }
 */
class Solution {
    public ListNode partition(ListNode head, int B) {
        
        ListNode smallhead = new ListNode();
        ListNode bighead = new ListNode();
        ListNode smalltemp = new ListNode();
        ListNode bigtemp = new ListNode(); 
        bool smallheadfound = false;
        bool bigheadfound = false;
        while(head!=null){
            
            if(head.val < B){
               if(!smallheadfound){
                   
                   smallhead = head;
                   smalltemp = head;
                   smallheadfound = true;
               } 
               else{
                   smalltemp.next=head;
                   smalltemp =smalltemp.next;
               } 
            }
            else{
                
                if(!bigheadfound){ 
                   bighead = head;
                   bigtemp = head;
                   bigheadfound = true;
               } 
               else{
                   bigtemp.next=head;
                   bigtemp = bigtemp.next;
               } 
            } 
           head=head.next; 
        }
        //when only one type of elements are there i.e., either lesser than x or vice versa
        if(!bigheadfound){return smallhead;}
        if(!smallheadfound){return bighead;}
        
        smalltemp.next = bighead;
        bigtemp.next= null;
        return smallhead; 
    }
}

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode Partition(ListNode head, int x) {
        
        var smallHead = new ListNode();
        var bigHead = new ListNode();
        var small = smallHead;
        var big = bigHead;
        while(head!=null){
            
            if(head.val < x){
                small.next = head;
                small = small.next;
            }
            else{
                big.next = head;
                big = big.next;
            }
            head = head.next;
        }
        big.next = null;
        small.next = bigHead.next;
        return smallHead.next;
    }
}

//or take two emmpty nodes , keep on adding smaller and greater elements, merge them and return
