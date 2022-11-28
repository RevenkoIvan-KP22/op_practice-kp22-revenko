using System;

namespace arrays
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("ARRAY 1\n");
            double[,] array1 = new double[4, 6];
            double d = 0;
            double sum = 0, product = 1;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    d = (i * i - 5.0) / (i + j + 3.0);
                    array1[i, j] = Math.Round(d, 2);
                    Console.Write(array1[i, j] + "   ");
                    if (d > 0)
                    {
                        sum += d;
                    }
                    else if (d < 0)
                    {
                        product *= d;
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Sum of positive elements: {Math.Round(sum, 3)}\nProduct of negative elements: {product}");

            Console.WriteLine();

            /*=============================================*/

            Console.WriteLine("ARRAY 2\n");
            double[,] array2 = new double[4, 8];
            int counter_n = 0, counter_p = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    d = (3 * j * j - 35.0) / (i + 1.2 * j + 2.0);
                    array2[i, j] = Math.Round(d, 2);
                    Console.Write(array2[i, j] + "   ");
                    if (d < 0)
                    {
                        counter_n++;
                    }
                    else if (d > 0)
                    {
                        counter_p++;
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine($"The number of positive elements: {counter_p}\nThe number of negative elements: {counter_n}");

            Console.WriteLine();

            /*=============================================*/

            Console.WriteLine("ARRAY 3\n");
            double[,] array3 = new double[5, 6];
            int null_counter = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    d = (i - j) / (2.5 * i * i + j + 1.0);
                    if (d == 0)
                    {
                        null_counter++;
                        d = 10;
                    }
                    array3[i, j] = Math.Round(d, 2);
                    Console.Write(array3[i, j] + "   ");

                }
                Console.WriteLine();
            }
            Console.WriteLine($"The number of elements, which were equal to 0: {null_counter}");

            Console.WriteLine();

            /*=============================================*/

            Console.WriteLine("ARRAY 4\n");
            double[,] array4 = new double[8, 4];
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    d = Math.Pow(i, 3) - 5 * j * j - 1.8;
                    array4[i, j] = Math.Round(d, 2);
                    Console.Write(array4[i, j] + "   ");
                }
                Console.WriteLine();
                getRowSum(i);
            }

            void getRowSum(int i)
            {
                double rowSum = 0;
                for (int j = 0; j < 4; j++)
                {
                    rowSum += array4[i, j];
                }
                Console.WriteLine($"Sum of the elements in the {i + 1} row: {Math.Round(rowSum, 1)} ");
                return;
            }
            // Console.WriteLine($"Sum of the elements in the 1st row: ");

            Console.WriteLine();

            /*=============================================*/

            Console.WriteLine("ARRAY 5\n");
            double[,] array5 = new double[7, 5];
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    d = Math.Pow(2, i) + j * j - 15;
                    array5[i, j] = Math.Round(d, 2);
                    Console.Write(array5[i, j] + "   ");
                }
                Console.WriteLine();
                getRowProduct(i);
            }

            void getRowProduct(int i)
            {
                double rowProduct = 1;
                for (int j = 0; j < 5; j++)
                {
                    rowProduct *= array5[i, j];
                }
                Console.WriteLine($"Sum of the elements in the {i + 1} row: {rowProduct} ");
                return;
            }

            Console.WriteLine();

            /*=============================================*/

            Console.WriteLine("ARRAY 6\n");
            double[,] array6 = new double[10, 5];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    d = j * j - 8 * i + 35;
                    array6[i, j] = Math.Round(d, 2);
                    Console.Write(array6[i, j] + "   ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Array 6 transponed");

            double[,] array6_added = new double[5, 10];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    array6_added[i, j] = array6[j, i];
                    Console.Write(array6_added[i, j] + "   ");
                }
                getRowSum(i);
                Console.WriteLine();
            }

            Console.WriteLine();

            /*=============================================*/

            Console.WriteLine("ARRAY 7\n");
            double[,] array7 = new double[9, 6];
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    d = 9 * i * i + j * j - 50;
                    array7[i, j] = Math.Round(d, 2);
                    Console.Write(array7[i, j] + "   ");
                }

                Console.WriteLine();
            }

            double[,] array7_added = new double[6, 9];
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    array7_added[i, j] = array7[j, i];
                    Console.Write(array7_added[i, j] + "   ");
                }
                getRowProduct(i);
                Console.WriteLine();
            }
        }
    }
}