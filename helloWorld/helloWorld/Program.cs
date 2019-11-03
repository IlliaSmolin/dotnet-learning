using System;

namespace helloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Oleg";
            byte age = 25;
            uint salary = 108000;
            float height = 1.92f;
            float cashInPockets = 72.42f;
            char averageMark = 'B';
            bool working = true;
            byte i = 0;

            void showInfo() {
                Console.Clear();
                Console.WriteLine($"Name: {name}");
                Console.WriteLine($"Age: {age}");
                Console.WriteLine($"Salary (USD/year): {salary}");
                Console.WriteLine($"Height (m): {height}");
                Console.WriteLine($"Cash in pockets (UAH): {cashInPockets}");
                Console.WriteLine($"Average school mark: {averageMark}");
                Console.WriteLine($"Is employed: {working}");
                Console.WriteLine("{0} is {1} y.o. and had \"{2}\" grade in the scool back then", name, age, averageMark);
                Console.Write("\nType any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }

            void menu() {
                if (i == 0) {
                    Console.WriteLine("Welcome to my first console program!\n");
                    Console.WriteLine("In this console program you have a basic person and you're allowed to change any info about them.");
                    Console.WriteLine("Just follow the instructions below and change your character as much as you want!\n");
                } else
                {
                    Console.Clear();
                }

                i++;
                byte listCount = 0;
                Console.WriteLine("What would you prefer to do?");
                Console.WriteLine("{0}) Show the basic character's info", ++listCount);
                Console.WriteLine("{0}) Change the character's info", ++listCount);
                Console.WriteLine("{0}) Clear the console", ++listCount);
                Console.WriteLine("{0}) Exit the program", ++listCount);
                Console.Write("\nYour choice: ");

                switch (Console.ReadLine()) {
                    case "1":
                        showInfo();
                        break;
                    case "2":
                        changeInfo();
                        break;
                    case "3":
                        break;
                    case "4":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("You did the unexisting choice, please try again!");
                        Console.Write("\nType any key to continue...");
                        Console.ReadKey();
                        break;
                }
                Console.Clear();
                menu();
            }

            void changeInfo() {
                Console.Clear();
                byte listCount = 0;
                Console.WriteLine("Choose what do you want to change:");
                Console.WriteLine($"{++listCount}) Name");
                Console.WriteLine($"{++listCount}) Age");
                Console.WriteLine($"{++listCount}) Salary");
                Console.WriteLine($"{++listCount}) Height");
                Console.WriteLine($"{++listCount}) Cash In Pockets");
                Console.WriteLine($"{++listCount}) Average School Mark");
                Console.WriteLine($"{++listCount}) \"Is Employed\" Status");
                Console.WriteLine($"{++listCount}) Go back to menu");
                Console.Write("\nYour choice: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        Console.WriteLine($"Current name = \"{name}\"");
                        Console.Write("Enter new name: ");
                        name = Console.ReadLine();
                        break;
                    case "2":
                        Console.WriteLine($"Current age = \"{age}\"");
                        Console.Write("Enter new age: ");
                        age = Convert.ToByte(Console.ReadLine());
                        break;
                    case "3":
                        Console.WriteLine($"Current salary = \"{salary}\"");
                        Console.Write("Enter new salary: ");
                        salary = Convert.ToUInt32(Console.ReadLine());
                        break;
                    case "4":
                        Console.WriteLine($"Current height = \"{height}\"");
                        Console.Write("Enter new height: ");
                        height = Convert.ToSingle(Console.ReadLine());
                        break;
                    case "5":
                        Console.WriteLine($"Current cash in pockets = \"{cashInPockets}\"");
                        Console.Write("Enter new cash in pockets: ");
                        cashInPockets = Convert.ToSingle(Console.ReadLine());
                        break;
                    case "6":
                        Console.WriteLine($"Current average school mark = \"{averageMark}\"");
                        Console.Write("Enter new average school mark: ");
                        averageMark = Convert.ToChar(Console.ReadLine());
                        break;
                    case "7":
                        Console.WriteLine($"Current \"Is Employed\" status = \"{working}\"");
                        Console.Write("Enter new \"Is Employed\" status: ");
                        working = Convert.ToBoolean(Console.ReadLine());
                        break;
                    case "8":
                        Console.Clear();
                        menu();
                        break;
                    default:
                        Console.WriteLine("You did the unexisting choice, please try again!");
                        Console.Write("\nType any key to continue...");
                        Console.ReadKey();
                        break;
                }
                Console.Clear();
                changeInfo();
            }
            menu();
        }
    }
}
