using System;
using System.Collections.Generic;

namespace Projeto2_LP1
{
    public class State<T>
    {

        private T[] items;


        public State()
        {
            items = new T[0];
        }

        public T GetItem(int index)
        {
            return items[index];
        }


        public void Add(T newItem)
        {

            T[] newItems = new T[items.Length + 1];

            for (int index = 0; index < items.Length; index++)
            {
                newItems[index] = items[index];
            }

            newItems[newItems.Length - 1] = newItem;


            items = newItems;
        }

        public int Size
        {
            get
            {
                return items.Length;
            }
        }
    }
}

