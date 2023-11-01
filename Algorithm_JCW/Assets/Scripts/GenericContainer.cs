using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class GenericContainer<T>
{
    private T[] items;
    private int currrentIndex = 0;

    public GenericContainer(int capacity)
    {
        items = new T[capacity];
    }

    public void Add(T item)
    {
        if (currrentIndex < items.Length)
        {
            items[currrentIndex] = item;
            currrentIndex++;
        }    
    }

    public T[] GetItems()
    {
        return items;
    }
}
