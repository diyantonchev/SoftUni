using System;
using System.Linq;

public class CustomList<T> where T : IComparable<T>
{
    private const int DefaultCapacity = 16;

    private T[] elements;
    private int currentIndex;

    public CustomList(int capacity = DefaultCapacity)
    {
        this.elements = new T[capacity];
        this.currentIndex = 0;
    }

    public int Count { get { return this.currentIndex; } }

    public bool isEmpty { get { return this.currentIndex == 0; } }

    public void Add(T element)
    {
        if (this.currentIndex >= this.elements.Length)
        {
            this.Resize();
        }

        this.elements[this.currentIndex] = element;
        this.currentIndex++;
    }

    public void Remove(T element)
    {
        bool isContains = false;
        for (int i = 0; i < this.currentIndex; i++)
        {
            T currentElement = this.elements[i];
            if (currentElement.Equals(element))
            {
                if (currentIndex > 1)
                {
                    for (int j = i; j < currentIndex - 1; j++)
                    {
                        T temp = this.elements[j];
                        this.elements[j] = this.elements[j + 1];
                        this.elements[j + 1] = temp;
                    }
                    this.elements[currentIndex] = default(T);
                    currentIndex--;
                    isContains = true;
                }
                else
                {
                    this.elements[i] = default(T);
                    isContains = true;
                    currentIndex--;
                }           
            }
        }

        if (!isContains)
        {
            throw new InvalidOperationException("List does not contains this element");
        }
    }

    public void RemoveAt(int index)
    {
        if (index > this.currentIndex || index < 0)
        {
            throw new ArgumentOutOfRangeException("Index was outside the bounds of the List.");
        }

        if (currentIndex > 1)
        {
            this.elements[index] = this.elements[index + 1];
            this.elements[index + 1] = default(T);
        }
        else
        {
            this.elements[index] = default(T);
        }

        this.currentIndex--;
    }

    public int IndexOf(T element)
    {
        for (int i = 0; i < this.currentIndex; i++)
        {
            T currentElement = this.elements[i];
            if (currentElement.Equals(element))
            {
                return i;
            }
        }
        return -1;
    }

    public T ElementOf(int index)
    {
        if (index > this.currentIndex || index < 0)
        {
            throw new ArgumentOutOfRangeException("Index was outside the bounds of the List.");
        }
        return this.elements[index];
    }

    public T this [int index]
    {
        get
        {
            if (index > this.currentIndex || index < 0)
            {
                throw new ArgumentOutOfRangeException(string.Format("{0} Index was outside the bounds of the List.", index));
            }

            return this.elements[index];
        }
    }

    public T Min()
    {
        if (this.currentIndex == 0)
        {
            throw new InvalidOperationException("List is empty");
        }

        T min = this.elements[0];
        for (int i = 1; i < this.currentIndex; i++)
        {
            T currentElement = this.elements[i];
            if (currentElement.CompareTo(min) < 0)
            {
                min = currentElement;
            }
        }
        return min;
    }

    public T Max()
    {
        if (this.currentIndex == 0)
        {
            throw new InvalidOperationException("List is empty");
        }

        T max = this.elements[0];
        for (int i = 1; i < this.currentIndex; i++)
        {
            T currentElement = this.elements[i];
            if (currentElement.CompareTo(max) > 0)
            {
                max = currentElement;
            }
        }

        return max;
    }

    public bool Contais(T element)
    {
        for (int i = 0; i < currentIndex; i++)
        {
            T currentElement = this.elements[i];
            if (currentElement.Equals(element))
            {
                return true;
            }
        }
        return false;
    }

    public void Clear()
    {
        for (int i = 0; i < currentIndex; i++)
        {
            this.elements[i] = default(T);
        }

        this.currentIndex = 0;
    }

    public override string ToString()
    {
        var result = elements.Take(this.currentIndex);

        return string.Join(", ", result);
    }

    private void Resize()
    {
        T[] newElements = new T[this.elements.Length * 2];

        for (int i = 0; i < this.elements.Length; i++)
        {
            newElements[i] = this.elements[i];
        }

        this.elements = newElements;
    }
}