namespace Leetcode.Solutions
{
    internal class Leetcode_MergeTwoSortedLists
    {
        /// <summary>
        /// 21. Merge Two Sorted Lists
        /// Problem: https://leetcode.com/problems/merge-two-sorted-lists
        /// Submission: https://leetcode.com/submissions/detail/2101306188/
        /// </summary>
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {

            ListNode dummy = new ListNode(-1);
            ListNode current = dummy;

            while (list1 != null && list2 != null)
            {
                if (list1.val <= list2.val)
                {
                    current.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    current.next = list2;
                    list2 = list2.next;
                }

                current = current.next;
            }


            if (list1 != null)
            {
                current.next = list1;
            }
            else
            {
                current.next = list2;
            }


            return dummy.next;
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
}
