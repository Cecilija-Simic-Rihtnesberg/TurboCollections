using System;

namespace TurboCollections

{
    public class TurboList<T>
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
            if (index >= Count)
            {
                EnsureSize(index+1);
                Count = index + 1;
            }
            items[index] = item;

        }
    }
    

}