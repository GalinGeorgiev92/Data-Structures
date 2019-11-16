using System;

public class CircularQueue<T>
{
    private const int DefaultCapacity = 4;

    private T[] elements;
    private int startIndex;
    private int endIndex;

    public int Count { get; private set; }

    public CircularQueue(int capacity = DefaultCapacity)
    {
        this.elements = new T[capacity];
    }

    public void Enqueue(T element)
    {
        if (this.Count >= this.elements.Length)
        {
            this.Resize();
        }

        this.elements[this.endIndex] = element;
        this.endIndex = (this.endIndex + 1) % this.elements.Length;
        this.Count++;
    }

    private void Resize()
    {
        T[] newArray = new T[this.elements.Length * 2];

        this.CopyAllElements(newArray);

        this.elements = newArray;
        this.startIndex = 0;
        this.endIndex = this.Count;
    }

    private void CopyAllElements(T[] newArray)
    {
        int currentIndex = 0;
        int currentHead = this.startIndex;

        while (currentIndex < this.Count)
        {
            newArray[currentIndex++] = this.elements[currentHead];
            currentHead = (currentHead + 1) % this.elements.Length;
        }
    }

    public T Dequeue()
    {
        if (this.Count == 0)
        {
            throw new InvalidOperationException();
        }

        T result = this.elements[this.startIndex];
        this.startIndex = (this.startIndex + 1) % this.elements.Length;
        this.Count--;

        return result;
    }

    public T[] ToArray()
    {
        var array = new T[this.Count];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = elements[i];
        }

        return array;
    }
}
