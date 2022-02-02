using System;

namespace TurboCollections
{
    public static class TurboSort
    {
        public static void BubbleSort(TurboList<int> list)
        {
            bool swapped;
            int endIndex = list.Count - 1;
            do
            {
                swapped = false;

                for (int i = 0; i < endIndex; i++)
                {
                    if (list.Get(i) > list.Get(i + 1))
                    {
                        int b = list.Get(i + 1);
                        list.Set( i + 1, list.Get(i));
                        list.Set(i, b);
                        swapped = true;
                    }
                }

                endIndex--;

            } while(swapped);
        }
    }
}