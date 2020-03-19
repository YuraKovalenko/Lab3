using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba3.OOP
{
    class Program
    {
        class Array
        {
            private const int size = 3;
            private int[,] Arr = new int[size, size] { { 1, 5, 7 }, { 2, 4, 8 }, { 3, 6, 9 } };//
            //private int product = Arr[0, index];
            private int averege =45/9;
            public int this [int index]
            {
                get
                {
                    int product = Arr[0, index];
                    for (int i = 1; i < size; i++)
                    {
                        // int j = index;
                        product *= Arr[i, index];
                    }
                    return product;
                }
            }
            private void Average()
            {
                int[,] arr = new int[size, size] { { 1, 5, 7 }, { 2, 4, 8 }, { 3, 6, 9 } };
                int Sum = 0, Counter = 0;
                for (int i = 0; i < size; i++) 
                {
                    for (int j = 0; j < size; j++) 
                    {
                        Sum += arr[i, j];
                        Counter++;
                    }
                }
            }

            public int Foo 
            {
                get
                {
                    return averege;
                }
            }

        }

        static void Main(string[] args)
        {
            Array value = new Array();
            Array a = new Array();
            Console.WriteLine("Kovealenko Yura IS-92\n");
            Console.WriteLine("Enter an array index ");
            int index = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Product is {0}", value[index]);
            Console.WriteLine("Average is :");
            Console.WriteLine(a.Foo);
            Console.ReadKey();
        }
    }
}
