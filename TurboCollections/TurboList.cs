using System;
using System.Collections;
using System.Collections.Generic;


namespace TurboCollections

{
    public class TurboList<T> : IEnumerable<T>
    {
        public int Count { get; private set; }
        private T[] items = Array.Empty<T>();
        
        public void Add(T item)
        {
            
            EnsureSize(Count + 1);
            items[Count++] = item;
            
        }
        
        /// <summary>
        /// this method ensures that the array is at least "size big
        /// </summary>
        /// <param name="size">the size that your array should have</param> 

        void EnsureSize(int size)
        {
            //if the array is lange enough, return!
            if (items.Length >= size)
                return;
            
            // double the array size, or set to given size if doubling is not enough
            int newSize = Math.Max(size, items.Length * 2);
            
            T[] newArray = new T[newSize];
            for (int i = 0; i < Count; i++)
            {
                //copy new array
                newArray[i] = items[i];
            }
            
            items = newArray;
        }

        public T Get(int index)
        {
            return items[index];
        }

        public void Set(int index, T item)
        {
            // if (index >= Count)
            // {
            //     EnsureSize(index+1);
            //     Count = index + 1;
            // }
            items[index] = item;

        }

        public void Cear()
        {
            for (int i = 0; i < Count; i++)
            {
                items[i] = default;
            }
            Count = 0;
        }

        public void RemoveAt(int index)
        {
            // for (int i = index; i < -1; i++)
            // {
            //     items[i] = items[i + 1];
            // }
            Count--;
        }

        public bool Contains(T item)
        {
            //return items.Any(_item => item.Equals(_item));
            //for (int i = 0; i < Count; i++)
            {
                //if (item.Equals(items[i]))
                    //return true;
                    return Index(item) != -1;
            }

            return false;
        }
        
        public int Index(T item)
        {
            
            for (int i = 0; i < Count; i++)
            {
                if (item.Equals(items[i]))
                    return i;
            }

            return -1;
        }
        
        public void Remove(T item)
        {
            var index = Index(item);
            if (index == -1)
                return;
            RemoveAt(index);
        }

        public void AddRange(IEnumerable<T> items)
        {
            foreach (var item in items)
            {
               Add(item); 
            }
        }

        public Enumerator GetEnumerator()
        {
            return new Enumerator(items, Count);
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return GetEnumerator();
        }
        
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public struct Enumerator : IEnumerator<T>
        {
            private readonly T[] _items;
            private readonly int _count;
            private int _index;

            public Enumerator(T[] items, int count)
            {
                _items = items;
                _count = count;
                _index = -1;
                
            }
            public bool MoveNext()
            {
                if (_index >= _count)
                    return false; //exception
                return ++_index < _count;
            }
            
            public void Reset()
            {
                _index = -1;
            }

            public T Current => _items[_index];

            object IEnumerator.Current => Current;

            public void Dispose()
            {
                Reset();
            }
        }


        // public IEnumerator<T> GetEnumerator()
        // {
        //     throw new NotImplementedException();
        // }
        //
        // IEnumerator IEnumerable.GetEnumerator()
        // {
        //     return GetEnumerator();
        // }
    }
}