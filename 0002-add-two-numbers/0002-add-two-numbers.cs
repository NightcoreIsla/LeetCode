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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        string l1Str = string.Empty;
        while (l1 != null)
        {
            l1Str += l1.val.ToString();
            l1 = l1.next;
        }
        string l2Str = string.Empty;
        while (l2 != null)
        {
            l2Str += l2.val.ToString();
            l2 = l2.next;
        }
        while (l1Str.Length < l2Str.Length)
        {
            l1Str = l1Str + "0";
        }
        while (l2Str.Length < l1Str.Length)
        {
            l2Str = l2Str + "0";
        }
        l1Str = new string(l1Str.Reverse().ToArray());
        l2Str = new string(l2Str.Reverse().ToArray());

        var l1Int = l1Str.Select(x => UInt16.Parse(x.ToString())).ToArray();
        var l2Int = l2Str.Select(x => UInt16.Parse(x.ToString())).ToArray();
        var resultInt = new List<Int32>();
        bool nextPlus = false;
        for (int i = l1Int.Length - 1; i >= 0 || nextPlus; i--)
        {
            var val = l1Int.ElementAtOrDefault(i) + l2Int.ElementAtOrDefault(i) + (nextPlus ? 1 : 0);
            resultInt.Add(val % 10);
            nextPlus = val >= 10;
        }
        resultInt.Reverse();

        ListNode result = null;
        foreach (var i in resultInt)
        {
            result = new ListNode(i, result);
        }
        return result;
    }
}