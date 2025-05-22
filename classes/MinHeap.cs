public class MinHeap<T>
{
    private readonly List<T> _items = new List<T>();

    private readonly IComparer<T>? _comparer;

    public MinHeap() : this(Comparer<T>.Default) { }

    public MinHeap(IComparer<T> comparer)
    {
        _comparer = _comparer;
    }

    public void Insert(T item)
    {
        _items.Add(item);
        HeapifyUp(_items.Count - 1);
    }

    public T ExtractMin()
    {
        if (_items.Count == 0)
        {
            throw new InvalidOperationException("Heap is currently empty!");
        }

        T root = _items[0];
        _items[0] = _items[^1];
        _items.RemoveAt(_items.Count - 1);
        HeapifyDown(0);
        return root;
    }

    public T Peek()
    {
        if (_items.Count == 0)
        {
            throw new InvalidOperationException("Heap is currently empty!");
        }
        return _items[0];
    }

    public int Count => _items.Count;

    private void HeapifyUp(int count)
    {

    }

    private void HeapifyDown(int count)
    {

    }
}