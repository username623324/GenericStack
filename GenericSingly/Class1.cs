using System.Globalization;

namespace GenericSingly
{

    public class Node<T>
    {

        public T Data { get; set; }
        public Node<T> Next { get; set; }

        public Node(T data)
        {
            Data = data;
        }
    }
    public class SinglyLinkedList<T>
    {
        public Node<T> Head { get; set; }
        public Node<T> Tail { get; set; }


        public IEnumerator<Node<T>> GetEnumerator()
        {
            var temp = Head;
            while (temp != null)
            {
                yield return temp;
                temp = temp.Next;
            }
        }

        public void AddToHead(T data)
        {
            var newNode = new Node<T>(data);

            if (Head == null && Tail == null)
            {
                Head = newNode;
                Tail = newNode;
            }
            else
            {
                newNode.Next = Head;
                Head = newNode;

            }
            newNode = null;
        }

        public void AddToTail(T data)
        {
            var newNode = new Node<T>(data);
            if (Head == null && Tail == null)
            {

                Head = newNode;
                Tail = newNode;

            }
            else
            {
                Tail.Next = newNode;
                Tail = newNode;
            }
            newNode = null;
        }


        public void RemoveFromHead()
        {
            if (Head == null || Tail == null)
            {
                throw new InvalidOperationException("Linked List Does not have any nodes");
            }
            else if (Head == Tail)
            {
                Head = null;
                Tail = null;
            }
            else
            {
                var temp = Head;
                Head = Head.Next;
                temp.Next = null;
                temp = null;
            }
        }
        public void RemoveFromTail()
        {
            if (Head == null || Tail == null)
            {
                throw new InvalidOperationException("Linked List Does Not Have Any Nodes");
            }
            else if (Head == Tail)
            {
                Head = null;
                Tail = null;
            }
            else
            {
                var temp = Head;
                while (temp.Next != Tail)
                    temp = temp.Next;

                temp.Next = null;
                Tail = temp;

                temp = null;
            }
        }
    }
}
