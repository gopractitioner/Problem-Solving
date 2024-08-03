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
public class Solution
{
    public ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        ListNode r = new ListNode();
        ListNode l = new ListNode();
        r = head; l.next = head; // 添加一个头节点
        for (int i = 1; i < n; i++)
        {
            r = r.next;
        }
        while (r.next != null)
        {
            r = r.next;
            l = l.next;
        }
        //return l;
        if (l.next == head) return head.next;
        l.next = l.next.next;
        return head;
    }
}