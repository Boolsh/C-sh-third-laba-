using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace шарпы_3_лаба
{
    internal class Program
    {
        static double[] create_array()
        {
            Console.Write("Введите размер массива: ");
            int size = Convert.ToInt32(Console.ReadLine());
            double[] arr = new double[size];
            Console.WriteLine("Введите элементы массива через пробел:");
            string[] arr_el = Console.ReadLine().Split(' ');
            for (int i = 0; i < size; ++i)
                arr[i] = int.Parse(arr_el[i]);
            return arr;
        }
        static void shift_to_right(double[] arr, int first, int second)
        {
            double tmp = arr[second - 1];
            for (int i = second - 1; i > first; --i)
            {
                arr[i] = arr[i - 1];
            }
            arr[first] = tmp;

        }

        static void task(double[] arr)
        {
            int size = arr.Length, ind_last_negative = 0;
            double curr;
            for (int i = 0; i < size; ++i)
            {
                curr = arr[i];
                if (curr < 0) 
                { 
                    shift_to_right(arr, ind_last_negative, i+1);
                    ind_last_negative++;
                }
            }
        }


        static void print_array(double[] arr)
        {
            for (int i = 0; i < arr.Length; ++i)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            double[] arr = create_array();
            Console.WriteLine("Исходный массив:");
            print_array(arr);

            task(arr);

            Console.WriteLine("Новый массив:");
            print_array(arr);

        }
    }
}
