using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sortArray = new int[9] { 2, 56, 33, 12, 48, 15, 70, 3, 54 };

            int lastElem = sortArray.Length - 1;

            Sort(sortArray, 0, lastElem);


            foreach (int i in sortArray)
            {
                Console.WriteLine(i);
            }
        }



        static void Sort(int[] arr, int first, int last)
        {
            int midElem = arr[(last - first) / 2 + first];
            int temp;
            int left = first;
            int right = last;

            while (left <= right)
            {
                while (arr[left] < midElem && left <= last)
                {
                    left++;
                }
                while (arr[right] > midElem && right >= first)
                {
                    right--;
                }
                if (left <= right)
                {
                    temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;
                    left++;
                    right--;
                }
            }

            //рекурсивный вызов
            if (right > first)
            {
                Sort(arr, first, right);
            }
            if (left < last)
            {
                Sort(arr, left, last);
            }

        }
    }
}
