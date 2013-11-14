using System;
using System.Text;

namespace MethodOfBubble
{
    class Program {
        static void Main() {
            Console.WriteLine("Введите количество элементов массива");
            int size = Int32.Parse(Console.ReadLine());
            int[] Array = new int[size];

            for (int i = 0; i < Array.Length; i++) {
                Console.WriteLine("Введите  " + i + "  элемент массива");
                Array[i] = Int32.Parse(Console.ReadLine());
            }

            for (int i = 0; i < Array.Length; i++) {
                for (int j = 0; j < (Array.Length - 1) ; j++) {
                    if (Array[j] > Array[j + 1]) {
                        int a = Array[j];
                        Array[j] = Array[j + 1];
                        Array[j + 1] = a;
                    }
                }
            }

            for (int i = 0; i < Array.Length; i++) {
                Console.Write(Array[i] + " ");
            }

            Console.ReadKey();
        }
    }
}
