namespace GenericStack;

interface IStack<T>
{
    bool IsEmpty { get; }
    void Clear();
    void Push(T element);
    T Pop();
    T Peek();

    IEnumerator<T> GetEnumerator();
}