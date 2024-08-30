using GenericDoublyLinkedList;
using GenericSingly;

namespace GenericStack
{

    public class GenericStackUsingDoubly<T> : IStack<T>
    {

        private DoublyLinkedList<T> _list;

        public GenericStackUsingDoubly()
        {
            _list = new DoublyLinkedList<T>();
        }
        public bool _isEmpty { get; set; }
        public bool IsEmpty => _isEmpty;
        public void Clear()
        {
            _list = new DoublyLinkedList<T>();
        }

        public void Push(T element)
        {
            _list.AddToHead(element);
            
        }

        public T Pop()
        {
            var element = _list.Head.Data;
            _list.RemoveFromHead();
            return element;
        }

        public T Peek()
        {
            if (_list.Head == null) throw new InvalidOperationException("Stack is Empty");
            return _list.Head.Data;
        }



    }
    public class GenericStackUsingSingly<T>: IStack<T>
    {
        private SinglyLinkedList<T> _list;

        public GenericStackUsingSingly()
        {
            _list = new SinglyLinkedList<T>();
        }
        public bool _isEmpty { get; set; }
        public bool IsEmpty => _isEmpty;
        public void Clear()
        {
            _list = new SinglyLinkedList<T>();
        }

        public void Push(T element)
        {
            _list.AddToHead(element);
            _isEmpty = false;
        }

        public T Pop()
        {
            if (_list.Head == null) throw new InvalidOperationException("Empty");

            var element = _list.Head.Data;
            _list.RemoveFromHead();

            if (_list.Head == null) _isEmpty = true;

            return element;
        }

        public T Peek()
        {
            if (_list.Head == null) throw new InvalidOperationException("Stack is Empty");
            return _list.Head.Data;
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var element in _list)
            {
                yield return element.Data;
            }

        }
    }
}
