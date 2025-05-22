using System.Collections.Generic;

public class CustomStack<T>
{
    private readonly List<T> _items = new List<T>();

    public void Push(T item) => _items.Add(item);

    public T Pop()
    {
        if (_items.Count() == 0)
        {
            throw new InvalidOperationException("The stack is currently empty!");
        }

        var item = _items[^1];
        _items.RemoveAt(_items.Count - 1);

        return item;
    }

    public T Peek()
    {
        if (_items.Count == 0)
        {
            throw new InvalidOperationException("Stack is currently empty!");
        }

        return _items[^1];
    }

    public int CountItems => _items.Count();

    public bool IsEmpty => _items.Count == 0;

}