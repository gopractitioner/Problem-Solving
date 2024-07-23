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
    public int[] AddTwoArrays(int[] x, int[] y, int length1, int length2, int length, int minLength)
    {
        if (length1 == 0 && length2 == 0 && x[0] + y[0] == 0)
        {
            return new int[] { 0 };
        }
        int[] results = new int[length + 1];
        for (int i = 0; i < minLength; i++)
        {
            results[i] = (x[i] + y[i] + results[i]) % 10;
            results[i + 1] = (results[i + 1] + (x[i] + y[i] + results[i]) / 10) % 10;
        }
        if (minLength != length)
        {
            if (length1 == length)
            {
                for (int i = minLength; i < length; i++)
                {
                    results[i] = (x[i] + results[i]) % 10;
                    results[i + 1] = (results[i + 1] + (x[i] + results[i]) / 10) % 10;
                }
            }
            else
            {
                for (int i = minLength; i < length; i++)
                {
                    results[i] = (y[i] + results[i]) % 10;
                    results[i + 1] = (results[i + 1] + (y[i] + results[i]) / 10) % 10;
                }
            }
        }
        int digitsLength = 101;
        for (int i = length; i >= 0; i--)
        {
            if (results[i] != 0)
            {
                digitsLength = i;
                break;
            }
        }
        int[] digits = new int[digitsLength + 1];
        int cnt = 0;

        for (int i = digitsLength; i >= 0; i--)
        {
            digits[cnt++] = results[i];
        }
        return digits;
    }
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        int[] digits1 = new int[100];
        int[] digits2 = new int[100];
        int length1 = 0, length2 = 0;
        while (l1 != null)
        {
            digits1[length1++] = l1.val;
            l1 = l1.next;
        }
        while (l2 != null)
        {
            digits2[length2++] = l2.val;
            l2 = l2.next;
        }
        int GetMax(int x, int y) => x > y ? x : y;
        int GetMin(int x, int y) => x < y ? x : y;
        int length = GetMax(length1, length2);

        int minLength = GetMin(length1, length2);
        // ListNode a = new ListNode();
        // ListNode t=a;
        // a.val=length; a.next=new ListNode(); a=a.next;
        // a.val=minLength;// a.next=new ListNode();
        // return t;
        int[] nodes = AddTwoArrays(digits1, digits2, length1, length2, length, minLength);
        ListNode sum = new ListNode();
        ListNode currentNode = sum;
        for (int i = 0; i < nodes.Length - 1; i++)
        {
            currentNode.val = nodes[i];
            currentNode.next = new ListNode();
            currentNode = currentNode.next;
        }
        currentNode.val = nodes[nodes.Length - 1];
        return sum;
    }
}