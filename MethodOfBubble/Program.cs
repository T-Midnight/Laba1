using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MethodOfBubble
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество элементов массива");
            int size = Int32.Parse(Console.ReadLine());
            int[] m1 = new int[size];

            int i, j;

            for (i = 0; i < m1.Length; i++) {
                Console.WriteLine("Введите  " + i + "  элемент массива");
                m1[i] = Int32.Parse(Console.ReadLine());
            }

            for (i = 0; i < m1.Length; i++) {
                for (j = 0; j < (m1.Length - 1) ; j++) {
                    if (m1[j] > m1[j + 1]) {
                        int a = m1[j];
                        m1[j] = m1[j + 1];
                        m1[j + 1] = a;
                    }
                }
            }

            for (i = 0; i < m1.Length; i++) {
                Console.Write(m1[i] + " ");
            }

                Console.ReadKey();
        }
    }
}
