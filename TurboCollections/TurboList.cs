using System;

namespace TurboCollections

{
    public class TurboList<T>
    {
        public int Count { get; private set; }
        private T[] items = Array.Empty<T>();
        
        public TurboList()
        {
            Console.WriteLine(("Hello, Turbo!"));
        }

        public void Add(T item)
        {
            
            EnsureSize(Count + 1);
            items[Count++] = item;
            
            // //Resize teh Array
            // T[] newArray = new T[Count + 1];
            // for (int i = 0; i < Count; i++)
            // {
            //     newArray[i] = items[i];
            // }
            // items = newArray;
            //
            // //Assing the new element
            // newArray[Count] = item;
            //
            // Count++;

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
            
            T[] newArray = new T[Count + 1];
            for (int i = 0; i < Count; i++)
            {
                //copy new array
                newArray[i] = items[i];
            }
            
            // //Resize teh Array
            items = newArray;
        }

        public T Get(int index)
        {
            return items[index];
        }

        public void Set(int index, T item)
        {
            //throw new NotImplementedException();
            
        }
    }
    

}