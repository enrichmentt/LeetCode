namespace Easy;

public class P206
{
    public static ListNode ReverseList(ListNode head)
    {
        ListNode prev = null;
        var curr = head;

        while (curr != null)
        {
            var nxt = curr.next;
            curr.next = prev;
            prev = curr;
            curr = nxt;
        }
        
        return prev;
    }
}

public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int val=0, ListNode next=null) 
    {
          this.val = val;
          this.next = next;
      }
}