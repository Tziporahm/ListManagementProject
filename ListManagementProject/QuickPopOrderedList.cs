using System;


namespace ListManagementProject
{
    public class QuickPopOrderedList<T> : OrderedList<T> where T : IComparable
    {

        public new Node<T> Pop()
        {
            if (head == null)
                return null;

            head = head.next;

            return head;
        }
    }
}
