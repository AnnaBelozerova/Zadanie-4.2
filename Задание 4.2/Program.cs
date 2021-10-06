using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_4._2
{
    class Program
    {   //Каких чисел больше, положительных или отрицательных
        static void Main(string[] args)
        {
            int N;
            int positive=0;
            int negative = 0;
            Console.WriteLine("Введите последовательность положительных и отрицательных чисел:");
            do
            {
                N = Convert.ToInt32(Console.ReadLine());
                if (N>0)
                   positive++;
                if (N < 0)
                    negative++;
            } while (N!=0);
            if (positive>negative)
                Console.WriteLine("Количество положительных чисел больше");
            
            if (positive == negative)
                Console.WriteLine("Количество положительных и отрицательных чисел равно");

            if (positive < negative)
                Console.WriteLine("Количество отрицательных чисел больше");
            
            Console.ReadKey();
        }
    }
}
