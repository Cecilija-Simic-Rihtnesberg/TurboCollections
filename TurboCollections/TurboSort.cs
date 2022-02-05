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
                        list.Swap(i, i+1);
                        swapped = true;
                    }
                }

                endIndex--;

            } while(swapped);
        }

        public static void QuickSort(TurboList<int> list, int? left = null, int? right = null)
        {
            int _left = left ?? 0;
            int _right = right ?? list.Count - 1;
            //int right = right == null ? list.Count - 1: right;
            if(_right-left <= 0)
                return;

            int pivot = list.Get(_right);
            int partition = Partition(list, _left, _right, pivot);
            QuickSort(list, left, right:partition-1);
            QuickSort(list, left:partition+1, _right);
            
            //(Instead of Create "Partition" Method Marc did a Local function)
            //private static int Partition(TurboList<int> list, int? left, int? right, int pivot)
            int Partition(TurboList<int> list, int left, int right, int pivot)
            {
                int leftPointer = left;
                int rightPointer = right - 1;

                while (true)
                {
                    while (list.Get(leftPointer++) < pivot);
                    while (rightPointer > 0 && list.Get(rightPointer--) > pivot);
                    
                    if (leftPointer >= rightPointer)
                        break;
                    
                    list.Swap(leftPointer, rightPointer);
                    // int b = list.Get(rightPointer);
                    // list.Set(rightPointer, list.Get(leftPointer));
                    // list.Set(leftPointer, b);
                }
                
                list.Swap(leftPointer, right);
                return leftPointer;
            } 
        }
    }
}