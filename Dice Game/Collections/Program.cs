
using System.Reflection.Emit;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool done = false;

            Console.WriteLine("WELCOME USER! THIS IS COLLLECTIONS.");
            while (!done)
            {
                Console.WriteLine(" Enter number of choice below.");
                Console.WriteLine(" >>>>>>>>>>MAIN MENU<<<<<<<<<<");
                Console.WriteLine(" _____________________________");
                Console.WriteLine("|1:INTEGERS                   |");
                Console.WriteLine("|2:STRINGS                    |");
                Console.WriteLine("|3:QUIT                       |");
                Console.WriteLine(" ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
                Console.Write("Choice: ");
                string choice = Console.ReadLine();
                switch (choice.ToLower())
                {
                    case "1":
                        Console.WriteLine(); Console.WriteLine(); Console.WriteLine();
                        INTEGERS();
                        Console.WriteLine(); Console.WriteLine(); Console.WriteLine();
                        break;
                    case "2":
                        Console.WriteLine(); Console.WriteLine(); Console.WriteLine();
                        STRINGS();
                        Console.WriteLine(); Console.WriteLine(); Console.WriteLine();
                        break;
                    case "3":
                        Console.WriteLine();
                        Console.WriteLine("Shutting down...");
                        Thread.Sleep(1000);
                        done = true;
                        break;
                    default:
                        Console.WriteLine("What?");
                        break;
                }


            }
        
            static void INTEGERS()
            {
                bool done = false;
                bool done2 = false;
                bool done3 = false;
                int choice = 0, min, max;
                string choice2 = "";
                List <int> integers = new List <int>();
                Random Generator = new Random();
                Console.WriteLine("Here is your starting list...");
                for (int i = 0; i < 25; i++)
                {
                    integers.Add(Generator.Next(1, 25));
                    Console.Write(integers[i]);
                    if (i < 24)
                    {
                        Console.Write(", ");
                    }
                }
                while (!done)
                {
                    Console.WriteLine();
                    Console.WriteLine(" >>>>>>>>>>>>>>>>>INTEGERS<<<<<<<<<<<<<<<<< ");
                    Console.WriteLine(" __________________________________________ ");
                    Console.WriteLine("|1:Sort list                               |");
                    Console.WriteLine("|2:Make new list                           |");
                    Console.WriteLine("|3:Remove a number (by value)              |");
                    Console.WriteLine("|4:Add a value to the list                 |");
                    Console.WriteLine("|5:Count occurrences of a specified number |");
                    Console.WriteLine("|6:Print the largest value                 |");
                    Console.WriteLine("|7:Print the smallest value                |");
                    Console.WriteLine("|8:Print the sum and average of # in list  |");
                    Console.WriteLine("|9:QUIT                                    |");
                    Console.WriteLine(" ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^ ");
                    Console.WriteLine();
                    Console.Write("What would you like to do?(Type the number): ");
                    if (int.TryParse(Console.ReadLine(), out choice) && choice >= 1 && choice <= 9)
                    {
                        switch (choice) 
                        { 
                            case 1:
                                Console.WriteLine("Sorting... ");
                                Thread.Sleep(1000);
                                integers.Sort();
                                for (int i = 0; i < integers.Count; i++)
                                {
                                    Console.Write(integers[i]);
                                    if (i < integers.Count - 1)
                                    {
                                        Console.Write(", ");
                                    }
                                }
                                Console.WriteLine(); Console.WriteLine(); Console.WriteLine();
                                break;
                            case 2:
                                Console.WriteLine("Making List...");
                                Thread.Sleep(500);
                                integers.Clear();
                                for (int i = 0; i < 25; i++)
                                {
                                    integers.Add(Generator.Next(1, 25));
                                    Console.Write(integers[i]);
                                    if (i < 24)
                                    {
                                        Console.Write(", ");
                                    }
                                }
                                break;
                            case 3:
                                
                                break;
                            case 4:
                                Console.WriteLine("Case 4");
                                break;
                            case 5:
                                Console.WriteLine("Case 5");
                                break;
                            case 6:
                                Console.WriteLine("Searching...");Thread.Sleep(500);

                                Console.WriteLine();

                                max = integers.Max();
                                Console.WriteLine($"The largest value is {max}. ");

                                Console.WriteLine();
                                break;
                            case 7:
                                Console.WriteLine("Searching...");Thread.Sleep(500);

                                Console.WriteLine();

                                min = integers.Min();
                                Console.WriteLine($"The smallest value is {min}. ");

                                Console.WriteLine();
                                break;
                            case 8:
                                Console.WriteLine("Case 8");
                                break;
                            case 9:
                                Console.WriteLine("QUITING...");
                                Thread.Sleep(789);
                                done = true;
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input");
                    }

                }
            }
            static void STRINGS()
            {
                bool done = false;
                int choice = -1;
                List <String> strings = new List <String>();
                Random Generator = new Random();
                Console.WriteLine();
                Console.WriteLine(" >>>>>>>>>>>>>STRINGS<<<<<<<<<<<<< ");
                Console.WriteLine(" _________________________________ ");
                Console.WriteLine("|1:Remove vegetable(by Index)     |");
                Console.WriteLine("|2:Remove vegetable(by value/name)|");
                Console.WriteLine("|3:Search for vegetable(By name)  |");
                Console.WriteLine("|4:Add a vegetable                |");
                Console.WriteLine("|5:Sort the list                  |");
                Console.WriteLine("|6:QUIT                           |");
                Console.WriteLine(" ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^" );
                Console.WriteLine();

            }
        }
    }
}