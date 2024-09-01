using System.Collections;
using System.ComponentModel;
using System.Net.NetworkInformation;

namespace GenericDoublyLinkedList
{
    public class DoublyLinkedList<T> : IEnumerable
    {
        public Node<T> Head { get; set; }
        public Node<T> Tail { get; set; }

        public void AddToHead(T data)
        {
            var newNode = new Node<T>(data);
            if (Head == null || Tail == null)
            {
                Head = Tail = newNode;
            }
            else
            {
                newNode.Next = Head;
                Head.Previous = newNode;
                Head = newNode;
            }

            newNode = null;
        }
        public void AddToTail(T data)
        {
            var newNode = new Node<T>(data);
            if (Head == null || Tail == null)
            {
                Head = Tail = newNode;
            }
            else
            {
                Tail.Next = newNode;
                newNode.Previous = Tail;
                Tail = newNode;
            }

            newNode = null;
        }

        public void RemoveFromHead()
        {
            if (Head == null || Tail == null)
            {
                throw new InvalidOperationException("List is empty.");
            }
            else if (Head == Tail)
            {
                Head = Tail = null;
            }
            else
            {
                var temp = Head;
                Head = Head.Next;
                temp.Next = null;
                temp = null;
                Head.Previous = null;
            }
        }

        public void RemoveFromTail(bool useMethodB)
        {
            if (Head == null || Tail == null)
            {
                throw new InvalidOperationException("List is empty.");
            }
            else if (Head == Tail)
            {
                Head = Tail = null;
            }
            else
            {
                if (!useMethodB)
                {
                    //METHOD A
                    Tail = Tail.Previous;
                    (Tail.Next).Previous = null;
                    Tail.Next = null;
                }

                else
                {
                    //METHOD B
                    var temp = Tail;
                    Tail = temp.Previous;
                    temp.Previous = null;
                    Tail.Next = null;
                    temp = null;
                }


            }
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }

}