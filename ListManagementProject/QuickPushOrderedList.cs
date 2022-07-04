using System;


namespace ListManagementProject
{
    public class QuickPushOrderedList<T> : OrderedList<T> where T : IComparable
    {
		public new void Push(T new_data)
		{
			Node<T> new_node = new Node<T>(new_data);
			new_node.next = head;
			head = new_node;
		}
	}
}
