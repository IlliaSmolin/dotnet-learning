using System;

namespace BinaryOperations
{
    class Program
    {
        delegate int CorrectLength(int a, int b); 
        static void Main(string[] args)
        {
            void multiplication() {
                Console.Write("Enter the first integer number: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the second integer number: ");
                int b = Convert.ToInt32(Console.ReadLine());
                string aBin = Convert.ToString(a, 2);
                string bBin = Convert.ToString(b, 2);
                string zeroStr = "";

                if (aBin.Length < bBin.Length) { //try to transform this into a CorrectLength function
                    byte diff = Convert.ToByte(bBin.Length - aBin.Length);
                    for (byte i = 0; i < diff; i++) {
                        zeroStr += "0";
                    }
                    aBin = zeroStr + aBin;
                } else if (aBin.Length > bBin.Length) {
                    byte diff = Convert.ToByte(aBin.Length - bBin.Length);
                    for (byte i = 0; i < diff; i++)
                    {
                        zeroStr += "0";
                    }
                    bBin = zeroStr + bBin;
                }

                Console.WriteLine($"\na: {aBin}");
                Console.WriteLine($"b: {bBin}");
                int result = a & b;
                Console.WriteLine("r: {0}", Convert.ToString(result, 2));
                Console.WriteLine("\nLogical multiplication is: {0}", result);
                repeat();
            }

            void repeat()
            {
                Console.Write("\nDo you want to continue (y/n)?: ");
                if (Console.ReadLine() == "y")
                {
                    Console.Clear();
                    multiplication();
                }
                else
                {
                    Environment.Exit(0);
                }
            }

            Console.WriteLine("Welcome to the \"Binary Operations!\" program!\n");
            multiplication();
        }
    }
}
