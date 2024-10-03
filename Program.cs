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
            double[] arr= new double[size];
            //string arr_el = Console.ReadLine();
            for (int i = 0; i < size; ++i)
            {
                //Console.Write($"Введите {i + 1} элемент: ");
                arr[i] = Convert.ToDouble(Console.Read());
            }
            return arr;
        }
        static void shift_to_right(double [] arr, int size)
        {
            double tmp = arr[size - 1];
            for (int i = size - 1; i > 0; --i)
            {
                arr[i] = arr[i - 1];
            }
            arr[0] = tmp;

        }

        static void print_array (double[] arr)
        {
            for (int i = 0; i < arr.Length; ++i)
                Console.Write(arr[i] +" ");
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            double[] arr = create_array();
            Console.WriteLine("Исходный массив:");
            print_array(arr);

            shift_to_right(arr, arr.Length);
            Console.WriteLine("Новый массив:");
            print_array(arr);

        }
    }
}
