
namespace ListManagementProject
{
    public class Node<T> 
    {
        public T data;
        public Node<T> next;
        public Node(T d) { data = d; next = null; }
        public Node(T d, Node<T> prev_node) { data = d; next = prev_node; }
        public Node() { }
    }
}
