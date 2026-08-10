using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Solutions
{
    internal class Leetcode_ConvertDoublyLinkedListToArrayI
    {
        /// <summary>
        /// 3263. Convert Doubly Linked List to Array I
        /// Problem: https://leetcode.com/problems/convert-doubly-linked-list-to-array-i
        /// Submission: https://leetcode.com/submissions/detail/2101347923/
        /// </summary>
        public int[] ToArray(Node head)
        {
            int arraySize = 0;

            while (head.next != null)
            {
                arraySize++;
                head = head.next;
            }

            arraySize++;
            int[] returnArray = new int[arraySize];

            for (int i = arraySize - 1; i >= 0; i--)
            {
                returnArray[i] = head.val;
                head = head.prev;
            }

            return returnArray;
        }
    }


    public class Node
    {
        public int val;
        public Node prev;
        public Node next;
    }
}
