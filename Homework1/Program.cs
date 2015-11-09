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

            foreach (int i in sortArray)
            {
                Console.WriteLine(i);
            }

            int leftElem = sortArray.First();
            int rightElem = sortArray.Last();
            int midElem = (leftElem + rightElem) / 2;
            int tempElem = 0;

            Console.WriteLine("\n");
            Console.WriteLine(leftElem);
            Console.WriteLine(rightElem);
            Console.WriteLine(midElem);
            Console.WriteLine("\n");

             while (leftElem <= rightElem)
              {
                while (leftElem < midElem)
                {
                    leftElem++;
                }
                while (rightElem > midElem)
                {
                    rightElem--;
                }
                if (leftElem < rightElem)
                {
                    tempElem = leftElem;
                    leftElem = rightElem;
                    rightElem = tempElem;
                }

                leftElem++;
                rightElem--;

                Console.WriteLine(leftElem);
                Console.WriteLine(rightElem);
                Console.WriteLine(tempElem);

            }



            //Sort(int leftElem, int rightElem);

        }

        //Повторяем рекурсивно, пока не дойдём до массива из 1 элемента

        //public void Sort(int b, int e)
        //{
        //    int l = b, r = e;
        //    int piv = arr[(l + r) / 2]; // Опорным элементом для примера возьмём средний
        //    while (l <= r)
        //    {
        //        while (arr[l] < piv)
        //            l++;
        //        while (arr[r] > piv)
        //            r--;
        //        if (l <= r)
        //            swap(arr[l++], arr[r--]);
        //    }
        //    if (b < r)
        //        qsort(b, r);
        //    if (e > l)
        //        qsort(l, e);
        //}   
        /* ----- end of function qsort ----- */




    }
}
