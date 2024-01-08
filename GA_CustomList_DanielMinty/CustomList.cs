using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_CustomList_DanielMinty
{
    internal class CustomList<T>
    {
        //Attributes
        private T[] items;
        private int count;
        public int Count => count;

        //Constructors
        public CustomList() : this(10) { }

        public CustomList(int initialSize)
        {
            items = new T[initialSize];
        }

        //Methods
        public void Add(T item)
        {//Add the item to the end of the list and increment count.
            CheckIntegrity();
            items[count++] = item;
        }

        public void AddAtIndex(T item, int index)
        {
            CheckIntegrity();
            for (int i = count - 1; i >= index; i--)
            {//from the bottom up, move each item down until the desired index is reached
                items[i + 1] = items[i];
            }
            //insert the item at the desired index
            items[index] = item;
            //increment count
            count++;
        }
        
        public bool Remove(T item)
        {//Remove the first occurance of specified item.
            for (int i = 0; i < count; i++)
            {//For each item in the list,
                if (items[i].Equals(item))
                {//check if the current item is the desired item.
                    //if the item matches,
                    for (i++; i < count; i++)
                    {//move each item below it one space toward the beginning overriding the previous positions.
                        items[i - 1] = items[i];
                    }
                    //one less item means decrement count
                    count--;
                    //job done, return true.
                    return true;
                }
                //if the item doesn't match, keep searching.
            }
            //if the item isn't found, return false.
            return false;
        }

        private void CheckIntegrity()
        {//If the list is 80% full, double it's maximum capacity.
            if (count >= 0.8 * items.Length)
            {
                T[] largerArray = new T[items.Length * 2];
                Array.Copy(items, largerArray, count);
                items = largerArray;
            }
        }

        public T GetItem(int index)
        {
            if (index < 0 || index >= count)
            {//If the index is out of bounds, throw exeption.
                throw new ArgumentOutOfRangeException(nameof(index));
            }
            //in bounds, return value at index
            return items[index];
        }

        public T this[int index]
        {//check if index is out of bounds, then get or set if valid
            get
            {
                if (index < 0 || index >= count)
                {
                    throw new ArgumentOutOfRangeException(nameof(index));
                }
                return items[index];
            }
            set
            {
                if (index < 0 || index >= count)
                {
                    throw new ArgumentOutOfRangeException(nameof(index));
                }
                items[index] = value;
            }
        }

        public T[] ToArray()
        {//Return an array that contains only the counted values
            T[] result = new T[count];
            for (int i = 0; i < count; i++)
            {
                result[i] = items[i];
            }
            return result;
        }

    }//End of CustomList
}//End of Namespace
