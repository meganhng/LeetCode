public class Solution {
    public ListNode MergeTwoLists(ListNode l1, ListNode l2) {
        if (l1 == null){
            return l2;
        }
        else if (l2 == null){
            return l1;
        }
        
         ListNode head = l1;
        
        ListNode prev = null;
        
        while (l1 != null && l2!= null){
            if (l1.val > l2.val){
                if (prev == null){
                    prev = l2;
                    head = prev;
                }
                else{
                    prev.next = l2;
                    prev = prev.next;
                }
                l2 = l2.next;
            }
            else{
                if (prev == null){
                    prev = l1;
                    head = prev;
                }
                else{
                    prev.next = l1;
                    prev = prev.next;
                }
                l1 = l1.next;
            }
        }
        
        if (l1 == null && l2 != null){
            prev.next = l2;
        }
        else if (l1 != null && l2 == null){
            prev.next = l1;
        }
        
        return head;
    }
}