using System;

namespace TurboCollections

{
    public class TurboList<T>
    {
        public int Count => items.Length;
        private T[] items = Array.Empty<T>();
        
        public TurboList()
        {
            Console.WriteLine(("Hello, Turbo!"));
        }

        public void Add(T item)
        {
            //Resize teh Array
            T[] newArray = new T[Count + 1];
            for (int i = 0; i < Count; i++)
            {
                newArray[i] = items[i];
            }
            
            //Assing the new element
            newArray[Count] = item;
            
            // Assign the result to our field
            items = newArray;

            object inputBufferSizeInByte = null;
            Console.WriteLine("input buffer size:  \t" + inputBufferSizeInByte + " \t in Byte");
            object amountTotalWeReadInByte = null;
            Console.WriteLine("total amount read   \t" + amountTotalWeReadInByte + " \t in Byte");
            object outPutMemoryStream = null;
            Console.WriteLine("output stream size: \t" + outPutMemoryStream + " \t in Byte");
            object callWriteCounter = null;
            Console.WriteLine("called strean write \t" + callWriteCounter + "\t\t times");
            
        }

        public T Get(int index)
        {
            return items[index];
        }
    }
    

}