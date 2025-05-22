public class CustomLinkedList<T>
{
    private class Node
    {
        public T? Value;
        public Node? Next;

        public Node(T value)
        {
            Value = value;
        }
    }

    private Node? _head;
    private Node? _tail;
    public int Count { get; private set; }

    public void AddLast(T value)
    {
        var newNode = new Node(value);
        if (_head == null)
        {
            _head = _tail = newNode;
        }
        else
        {
            _tail!.Next = newNode;
            _tail = newNode;
        }
        Count++;
    }


    public void AddFist(T value)
    {
        var newNode = new Node(value)
        {
            Next = _head
        };
        _head = newNode;

        if (_tail == null)
        {
            _tail = newNode;
        }
        Count++;
    }

    public bool Remove(T value)
    {
        Node? current = _head;
        Node? previous = null;

        while (current != null)
        {
            if (Equals(current.Value, value))
            {
                if (previous == null)
                {
                    _head = current.Next;
                    if (_head == null)
                    {
                        _tail = null;
                    }
                }
                else
                {
                    previous.Next = current.Next;
                    if (current.Next == null)
                    {
                        _tail = previous;
                    }
                }
                Count--;

                return true;
            }

            previous = current;
            current = current.Next;
        }

        return false;
    }

    public IEnumerable<T> AsEnumerable()
    {
        Node? current = _head;
        while (current != null)
        {
            yield return current.Value;
            current = current.Next;
        }
    }

    public bool Contains(T value)
    {
        return AsEnumerable().Contains(value);
    }

    public void Clear()
    {
        _head = _tail = null;
        Count = 0;
    }
}