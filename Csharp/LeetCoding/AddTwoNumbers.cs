using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public partial class LeetCodeLibrary
    {
        #region AddTwoumbers
        //Definition for singly-linked list.
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
            public void PrintNodes()
            {
                ListNode node = this;
                do
                {
                    Console.WriteLine(node.val);
                    node = node.next;
                }
                while (node != null);
            }
        }
        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode head = new ListNode();
            ListNode current = head;
            int carry = 0;
            int l1v, l2v, sum;
            bool l1b = (l1 != null), l2b = (l2 != null);
            while (l1b || l2b)
            {
                l1v = l1b ? l1.val : 0;
                l2v = l2b ? l2.val : 0;
                sum = l1v + l2v + carry;
                carry = sum / 10;
                current.next = new ListNode(sum % 10);
                if (l1 != null)
                    l1 = l1.next;
                if (l2 != null)
                    l2 = l2.next;
                l1b = (l1 != null);
                l2b = (l2 != null);
                current = current.next;
            }
            if (carry > 0)
                current.next = new ListNode(1);
            return head.next;
        }
        #endregion
        #region AddTwoNumbers Testing
        public static void AddTwoNumbersTest()
        {

            ListNode head1 = new ListNode(2);
            ListNode it1 = head1.next = new ListNode(4);
            it1.next = new ListNode(3);
            ListNode head2 = new ListNode(5);
            ListNode it2 = head2.next = new ListNode(6);
            it2.next = new ListNode(4);
            head1.PrintNodes();
            head2.PrintNodes();
            ListNode result = AddTwoNumbers(head1, head2);
            result.PrintNodes();
        }
            #endregion
    }

}
