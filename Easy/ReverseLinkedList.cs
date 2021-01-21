public class Solution {
    public ListNode ReverseList(ListNode head) {
        ListNode prev = null;
        
        while (head!= null){
            ListNode temp = head.next;
            head.next = prev;
            prev = head;
            head = temp;
        }
        
        return prev;

    }
}