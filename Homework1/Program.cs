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
            int[] sortArray = new int[8] { 2, 56, 33, 12, 48, 15, 70, 3 };


            foreach (int i in sortArray)
            {
                Console.WriteLine(i);
            }

            Sort();

        }


        //Выбираем опорный элемент
        //Разбиваем массив на 3 части
        //Создаём переменные l и r — индексы соответственно начала и конца рассматриваемого подмассива
        //Увеличиваем l, пока l-й элемент меньше опорного
        //Уменьшаем r, пока r-й элемент больше опорного
        //Если l всё ещё меньше r, то меняем l-й и r-й элементы местами, инкрементируем l и декрементируем r
        //Если l вдруг становится больше r, то прерываем цикл
        //Повторяем рекурсивно, пока не дойдём до массива из 1 элемента

        public void Sort(int b, int e)
        {
            int l = b, r = e;
            int piv = arr[(l + r) / 2]; // Опорным элементом для примера возьмём средний
            while (l <= r)
            {
                while (arr[l] < piv)
                    l++;
                while (arr[r] > piv)
                    r--;
                if (l <= r)
                    swap(arr[l++], arr[r--]);
            }
            if (b < r)
                qsort(b, r);
            if (e > l)
                qsort(l, e);
        }    /* ----- end of function qsort ----- */




    }
}
