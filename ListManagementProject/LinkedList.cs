using System;

namespace ListManagementProject
{
    public class LinkedList<T> where T : IComparable
    {

        public Node<T>  head; // head of list

        public void PrintList()
        {
            Node<T> tnode = head;
            while (tnode != null)
            {
                Console.Write(tnode.data + " ");
                tnode = tnode.next;
            }
        }
        public void Push(T item)
        {
            // case1: if empty list
            if (head == null)
            {
                // list is empty, so add to beginning of list
                // make new node and assign to head of list
                head = new Node<T>(item, null);
            }
            // if not empty list
            else
            {
                // case2: add to beginning of list
                if (item.CompareTo(head.data) <= 0)
                {
                    // add new node to list
                    head = new Node<T>(item, head);
                }
                // case3: add to middle or end of list
                else
                {
                    // start at 2nd node in list
                    Node<T> previous = head;
                    Node<T> current = head.next;
                    // while not at end of list and item is greater than current
                    while (current != null && item.CompareTo(current.data) > 0)
                    {
                        // advance to current node
                        previous = current;
                        // advance to next node
                        current = current.next;
                    }
                    // add new node to list
                    // make new node that points to next node
                    Node<T> node = new Node<T>(item, current);
                    // point previous node to new node
                    previous.next=node;
                }
            }

        }
        
      
      
    }
}

