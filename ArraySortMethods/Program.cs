using System;

namespace ArraySortMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] oneDimRandomArr = new int[20];
            int[,] twoDimRandomArr = new int[5, 10];
            Random rnd = new Random();
            int arrLen = oneDimRandomArr.Length;
            int twoDimArrHeight = twoDimRandomArr.GetLength(0);
            int twoDimArrLength = twoDimRandomArr.GetLength(1);

            void showODArray()
            {
                Console.Write("Your one dimensional array is: [");
                for (int i = 0; i < arrLen; i++)
                {
                    if (i == arrLen - 1)
                    {
                        Console.WriteLine("{0}]", oneDimRandomArr[i]);
                    } else
                    {
                        Console.Write("{0}, ", oneDimRandomArr[i]);
                    }
                }
            }

            void showTDArray()
            {
                for (int i = 0; i < twoDimArrHeight; i++)
                {
                    Console.Write("[");
                    for (int j = 0; j < twoDimArrLength; j++)
                    {
                        if (j == twoDimArrLength - 1)
                        {
                            Console.Write("{0}", twoDimRandomArr[i, j]);
                        } else
                        {
                            Console.Write("{0}, ", twoDimRandomArr[i, j]);
                        }
                    }
                    if (i == twoDimArrHeight - 1)
                    {
                        Console.WriteLine("]");
                    } else
                    {
                        Console.WriteLine("],");
                    }
                }
            }
            

            for (int i = 0; i < arrLen; i++)
            {
                oneDimRandomArr[i] = rnd.Next(50);
            }

            Console.Write("!One-dimensional arrays tab!\n\n[Random]:   ");
            showODArray();
            Array.Sort(oneDimRandomArr);
            Console.Write("[Sorted]:   ");
            showODArray();
            Array.Reverse(oneDimRandomArr);
            Console.Write("[Reversed]: ");
            showODArray();

            // two-dimensional arrays below
            Console.WriteLine("\n---------------------------------------------------------------\n");
            // two-dimensional arrays below


            for (int i = 0; i < twoDimArrHeight; i++)
            {
                for (int j = 0; j < twoDimArrLength; j++)
                {
                    twoDimRandomArr[i, j] = rnd.Next(100);
                }
            }

            Console.WriteLine("!Two-dimensional arrays tab!\n\n[Random]:");
            showTDArray();

            int temp;

            for (int i = 0; i < twoDimArrHeight; i++) //buble sort by rows
            {
                for (int sort = 0; sort < twoDimArrLength; sort++)
                {
                    for (int j = 0; j < twoDimArrLength - 1; j++) 
                    {
                        if (twoDimRandomArr[i, j] > twoDimRandomArr[i, j + 1])
                        {
                            temp = twoDimRandomArr[i, j + 1];
                            twoDimRandomArr[i, j + 1] = twoDimRandomArr[i, j];
                            twoDimRandomArr[i, j] = temp;
                        }
                    } 

                }
            }

            Console.WriteLine("\n[Sorted by rows with bubble sort]:");
            showTDArray();

            for (int sort = 0; sort < twoDimArrHeight; sort++) //buble sort by columns
            {
                for (int i = 0; i < twoDimArrHeight - 1; i++)
                {
                    for (int j = 0; j < twoDimArrLength; j++)
                    {
                        if (twoDimRandomArr[i, j] > twoDimRandomArr[i + 1, j])
                        {
                            temp = twoDimRandomArr[i + 1, j];
                            twoDimRandomArr[i + 1, j] = twoDimRandomArr[i, j];
                            twoDimRandomArr[i, j] = temp;
                        }
                    }

                }
            }

            Console.WriteLine("\n[Sorted by columns with bubble sort]:");
            showTDArray();


            //modified bubble sort here (j=-1 as I did on the CS course project)
            Console.WriteLine("\n[Sorted by rows with modified bubble sort]:\n%placeholder%");
            //showTDArray();
            Console.WriteLine("\n[Sorted by columns with modified bubble sort]:\n%placeholder%");
            //showTDArray();

            //quick sort code here
            Console.WriteLine("\n[Sorted by rows with quick sort]:\n%placeholder%");
            //showTDArray();
            Console.WriteLine("\n[Sorted by columns with quick sort]:\n%placeholder%");
            //showTDArray();

            //benchmark of quick sort/modified bubble sort/pure bubble sort

            // arrays-in-array (multi-dimensional) code below
            Console.WriteLine("\n---------------------------------------------------------------\n");
            // arrays-in-array (multi-dimensional) code below


        }
    }
}
