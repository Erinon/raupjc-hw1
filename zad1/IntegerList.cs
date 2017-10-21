using System;

public class IntegerList : IIntegerList
{
    private int[] _internalStorage;
    private int _count;

    public IntegerList()
    {
        _internalStorage = new int[4];
        _count = 0;
    }

    public IntegerList(int initialSize)
    {
        if (initialSize >= 0)
        {
            _internalStorage = new int[initialSize];
            _count = 0;
        }
        else
        {
            throw new ArgumentOutOfRangeException();
        }
    }

    public void Add(int X)
    {
        if (_count == _internalStorage.Length)
        {
            int[] temp = new int[_internalStorage.Length * 2];

            for (int i = 0; i < _count; i++)
            {
                temp[i] = _internalStorage[i];
            }

            _internalStorage = temp;
        }

        _internalStorage[_count++] = X;
    }

    public bool RemoveAt(int index)
    {
        if (index < 0 || index >= _count)
        {
            throw new IndexOutOfRangeException();
        }

        for (int i = index; i < _count - 1; i++)
        {
            _internalStorage[i] = _internalStorage[i + 1];
        }

        _count--;

        return true;
    }

    public bool Remove(int item)
    {
        for (int i = 0; i < _count; i++)
        {
            if (item == _internalStorage[i])
            {
                return RemoveAt(i);
            }
        }

        return false;
    }

    public int GetElement(int index)
    {
        if (index < 0 || index >= _count)
        {
            throw new IndexOutOfRangeException();
        }
        else
        {
            return _internalStorage[index];
        }
    }

    public int IndexOf(int item)
    {
        for (int i = 0; i < _count; i++)
        {
            if (_internalStorage[i] == item)
            {
                return i;
            }
        }

        return -1;
    }

    public int Count
    {
        get
        {
            return _count;
        }
    }

    public void Clear()
    {
        _internalStorage = new int[_internalStorage.Length];
        _count = 0;
    }

    public bool Contains(int item)
    {
        for (int i = 0; i < _count; i++)
        {
            if (_internalStorage[i] == item)
            {
                return true;
            }
        }

        return false;
    }

}