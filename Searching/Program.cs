using System.Security.AccessControl;

using System;

namespace Searching
{
    class Program
    {
        
        static int SequentialSearch(int[] array, int value)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == value)
                    return i;
            }
            return -1;
        }

        
        static int BinarySearch(int[] array, int value)
        {
            int low = 0;
            int high = array.Length - 1;

            while (low <= high)
            {
                int mid = (low + high) / 2;

                if (array[mid] == value)
                    return mid;
                else if (array[mid] < value)
                    low = mid + 1;
                else
                    high = mid - 1;
            }

            return -1;
        }

        
        static int BinarySearch(int[] array, int value, int low, int high)
        {
            if (low > high)
                return -1;

            int mid = (low + high) / 2;

            if (array[mid] == value)
                return mid;
            else if (array[mid] < value)
                return BinarySearch(array, value, mid + 1, high);
            else
                return BinarySearch(array, value, low, mid - 1);
        }

        
        static void Main(string[] args)
        {
           
            int[] array = { 1, 2, 3, 4, 5, 6, 7 };

            
            int index = SequentialSearch(array, 6);
            Console.WriteLine("SequentialSearch result for 6: " + index);

            
            index = BinarySearch(array, 6);
            Console.WriteLine("BinarySearch (iterative) result for 6: " + index);

            
            index = BinarySearch(array, 6, 0, 6);
            Console.WriteLine("BinarySearch (recursive) result for 6: " + index);
        }
    }
}
