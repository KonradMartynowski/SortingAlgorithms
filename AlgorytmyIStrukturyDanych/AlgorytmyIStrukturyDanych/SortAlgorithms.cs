using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorytmyIStrukturyDanych
{
    public class SortAlgorithms
    {
        public static int Tn { get; set; }

        public static void TnRest()
        {
            Tn = 0;
        }

        public static void TnInc()
        {
            Tn++;
        }

        public static void HeapSort(int[] array)
        {
            int n = array.Length;
            TnRest();

            for (int i = n / 2 + 1; i >= 0; i--)
            {
                ValidateMaxHeap(array, n, i);
                TnInc();
            }

            for (int i = n - 1; i > 0; i--)
            {
                Swap(array, 0, i);
                ValidateMaxHeap(array, --n, 0);
                TnInc();
            }
        }

        private static void ValidateMaxHeap(int[] arr, int heapSize, int parentIndex)
        {
            int maxIndex = parentIndex;
            int leftChild = parentIndex * 2 + 1;
            int rightChild = parentIndex * 2 + 2;

            if (leftChild < heapSize && arr[leftChild] > arr[maxIndex])
            {
                maxIndex = leftChild;
            }

            if (rightChild < heapSize && arr[rightChild] > arr[maxIndex])
            {
                maxIndex = rightChild;
            }

            if (maxIndex != parentIndex)
            {
                Swap(arr, maxIndex, parentIndex);
                ValidateMaxHeap(arr, heapSize, maxIndex);
            }
        }

        public static void BubbleSort(int[] array)
        {
            int n = array.Length;
            int it = 0;
            bool swaped = true;
            TnRest();

            while (it < n -1 && swaped)
            {
                swaped = false;
                for (int i = 0; i < n - 1 - it; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        Swap(array, i, i + 1);
                        swaped = true;
                    }
                    TnInc();
                }
                it++;
            }
        }

        private static void Swap(int[] arr, int index1, int index2)
        {
            int temp = arr[index1];
            arr[index1] = arr[index2];
            arr[index2] = temp;
        }

    }
}
