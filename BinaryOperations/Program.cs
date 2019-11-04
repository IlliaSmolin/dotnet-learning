using System;

namespace BinaryOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, result, aBinLength, bBinLength, resBinLength, equalLength;
            string zeroStr = "", aBin, bBin, resBin;

            void multiplication()
            {
                showInstruction("multiplication");
                input();
                result = a & b;
                binsToSameLength();
                showResult();
                repeat();
            }

            void addition()
            {
                showInstruction("addition");
                input();
                result = a | b;
                binsToSameLength();
                showResult();
                repeat();
            }

            void XOR()
            {
                showInstruction("XOR");
                input();
                result = a ^ b;
                binsToSameLength();
                showResult();
                repeat();
            }

            void leftShift()
            {
                showInstruction("leftShift");
                input();
                result = a << b;
                binsToSameLength();
                showResult();
                repeat();
            }

            void rightShift()
            {
                showInstruction("rightShift");
                input();
                result = a >> b;
                binsToSameLength();
                showResult();
                repeat();
            }

            void inversion()
            {
                showInstruction("inversion");
                Console.Write("Enter the first integer number (a): ");
                a = Convert.ToInt32(Console.ReadLine());
                result = ~a;
                Console.WriteLine("\na: {0}", Convert.ToString(a, 2));
                Console.WriteLine("r: {0}", Convert.ToString(result, 2));
                Console.WriteLine("\nDecimal result is: {0}", result);
                repeat();
            }

            void showResult()
            {
                Console.WriteLine($"\na: {aBin}");
                Console.WriteLine($"b: {bBin}");
                Console.WriteLine("r: {0}", resBin);
                Console.WriteLine("\nDecimal result is: {0}", result);
            }

            void input()
            {
                Console.Write("Enter the first integer number (a): ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the second integer number (b): ");
                b = Convert.ToInt32(Console.ReadLine());
                aBin = Convert.ToString(a, 2);
                bBin = Convert.ToString(b, 2);
            }

            void binsToSameLength()
            {
                resBin = Convert.ToString(result, 2);
                aBinLength = aBin.Length;
                bBinLength = bBin.Length;
                equalLength = Math.Max(aBinLength, bBinLength);
                resBinLength = resBin.Length;

                if (aBinLength < equalLength)
                {
                    zeroStr = "";
                    int diff = equalLength - aBinLength;
                    for (int i = 0; i < diff; i++)
                    {
                        zeroStr += "0";
                    }
                    aBin = zeroStr + aBin;
                }
                if (bBinLength < equalLength)
                {
                    zeroStr = "";
                    int diff = equalLength - bBinLength;
                    for (int i = 0; i < diff; i++)
                    {
                        zeroStr += "0";
                    }
                    bBin = zeroStr + bBin;
                }
                if (resBinLength < equalLength)
                {
                    zeroStr = "";
                    int diff = equalLength - resBinLength;
                    for (int i = 0; i < diff; i++)
                    {
                        zeroStr += "0";
                    }
                    resBin = zeroStr + resBin;
                }
            }

            void repeat()
            {
                Console.Write("\nDo you want to continue (y/n)?: ");
                if (Console.ReadLine() == "y")
                {
                    Console.Clear();
                    menu();
                }
                else
                {
                    Environment.Exit(0);
                }
            }

            void menu()
            {
                byte listCounter = 0;
                Console.WriteLine("What do you want to choose?");
                Console.WriteLine($"{++listCounter}) Logical multiplication");
                Console.WriteLine($"{++listCounter}) Logical addition");
                Console.WriteLine($"{++listCounter}) Logical XOR");
                Console.WriteLine($"{++listCounter}) Logical inversion");
                Console.WriteLine($"{++listCounter}) Logical left shift");
                Console.WriteLine($"{++listCounter}) Logical right shift");
                Console.WriteLine($"{++listCounter}) Logical exit");
                Console.Write("\nYour choice: ");
                string answer = Console.ReadLine();
                Console.Clear();

                switch (answer)
                {
                    case "1":
                        multiplication();
                        break;
                    case "2":
                        addition();
                        break;
                    case "3":
                        XOR();
                        break;
                    case "4":
                        inversion();
                        break;
                    case "5":
                        leftShift();
                        break;
                    case "6":
                        rightShift();
                        break;
                    case "7":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("You did the unexsisting choice.");
                        repeat();
                        break;
                }
            }

            void showInstruction(string operation)
            {
                switch (operation)
                {
                    case "multiplication":
                        Console.WriteLine("Logical multiplication transfers two numbers into binary code and compares two digits with the same column");
                        Console.WriteLine("If two digits are equal to 1, result will have the 1 in this column");
                        Console.WriteLine("If at least one of the digits isn't equal to 1, result will have the 0 in this column\n");
                        break;
                    case "addition":
                        Console.WriteLine("Logical addition transfers two numbers into binary code and compares two digits with the same column");
                        Console.WriteLine("If at least one of the digits is equal to 1, result will have the 1 in this column");
                        Console.WriteLine("If both of the digits are equal to 0, result will have the 0 in this column\n");
                        break;
                    case "XOR":
                        Console.WriteLine("Logical eXclusive OR (XOR) transfers two numbers into binary code and compares two digits with the same column");
                        Console.WriteLine("Only if one of the digits is equal to 1, result will have the 1 in this column");
                        Console.WriteLine("If both of the digits are equal to 0, result will have the 0 in this column");
                        Console.WriteLine("If both of the digits are equal to 1, result will have the 0 in this column\n");
                        break;
                    case "inversion":
                        Console.WriteLine("Logical inversion transfers the number into binary code and changes each digit's state");
                        Console.WriteLine("0 becomes 1, and 1 becomes 0\n");
                        break;
                    case "leftShift":
                        Console.WriteLine("Logical left shift transfers the first number into binary code and moves the code left on specified number of moves (b)\n");
                        break;
                    case "rightShift":
                        Console.WriteLine("Logical right shift transfers the first number into binary code and moves the code right on specified number of moves (b)\n");
                        break;
                    default:
                        Console.WriteLine("%UNEXISTING_INSTRUCTION%");
                        break;
                }
            }

            Console.WriteLine("Welcome to the \"Binary Operations!\" program!\n");
            menu();
        }
    }
}
