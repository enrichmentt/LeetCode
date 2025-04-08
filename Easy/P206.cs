using Easy.Common;

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