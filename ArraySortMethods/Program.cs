using System;

namespace ArraySortMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] oneDimRandomArr = new int[20]; //one dimensional array
            int[,] twoDimRandomArr = new int[4, 6]; //two dimensional array
            int[][] teethyArray = new int[3][];
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

            void fillTDArrayRandom()
            {
                for (int i = 0; i < twoDimArrHeight; i++)
                {
                    for (int j = 0; j < twoDimArrLength; j++)
                    {
                        twoDimRandomArr[i, j] = rnd.Next(10, 100);
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

            fillTDArrayRandom();
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

            fillTDArrayRandom();
            Console.WriteLine("\n[Random]:");
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

            fillTDArrayRandom();
            Console.WriteLine("\n[Random]:");
            showTDArray();

            for (int i = 0; i < twoDimArrHeight; i++) //modified bubble sort by rows
            {
                for (int j = 0; j < twoDimArrLength - 1; j++)
                {
                    if (twoDimRandomArr[i, j] > twoDimRandomArr[i, j + 1])
                    {
                        temp = twoDimRandomArr[i, j + 1];
                        twoDimRandomArr[i, j + 1] = twoDimRandomArr[i, j];
                        twoDimRandomArr[i, j] = temp;
                        j = -1;
                    }
                }
            }

            Console.WriteLine("\n[Sorted by rows with modified bubble sort]:");
            showTDArray();

            fillTDArrayRandom();
            Console.WriteLine("\n[Random]:");
            showTDArray();

            for (int j = 0; j < twoDimArrLength; j++) //modified bubble sort by columns
            {
                for (int i = 0; i < twoDimArrHeight - 1; i++)
                {
                    if (twoDimRandomArr[i, j] > twoDimRandomArr[i + 1, j])
                    {
                        temp = twoDimRandomArr[i + 1, j];
                        twoDimRandomArr[i + 1, j] = twoDimRandomArr[i, j];
                        twoDimRandomArr[i, j] = temp;
                        i = -1;
                    }
                }
            }

            Console.WriteLine("\n[Sorted by columns with modified bubble sort]:");
            showTDArray();

            // arrays-in-array (multi-dimensional) code below
            Console.WriteLine("\n---------------------------------------------------------------\n");
            // arrays-in-array (multi-dimensional) code below
            Console.WriteLine("[Teethy array]:");
            teethyArray[0] = new int[3] { 1, 2, 3 };
            teethyArray[1] = new int[5] { 1, 2, 3, 4, 5 };
            teethyArray[2] = new int[4] { 1, 2, 3, 4 };

            for (int row = 0; row < teethyArray.Length; row++)
            {
                Console.Write("[");
                for (int column = 0; column < teethyArray[row].Length; column++)
                {
                    if (column == teethyArray[row].Length - 1)
                    {
                        Console.Write($"{teethyArray[row][column]}");
                    } else
                    {
                        Console.Write($"{teethyArray[row][column]}, ");
                    }
                }
                Console.WriteLine("]");
            }
        }
    }
}
