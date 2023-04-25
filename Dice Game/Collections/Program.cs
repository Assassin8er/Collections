
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
                bool done1 = false;
                bool done2 = false;
                int choice = 0, min, max, Number,Sum;
                double Avg = 0;
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
                while (!done1)
                {
                    done2 = false;
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
                                Console.WriteLine();
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
                                Thread.Sleep(800);
                                integers.Clear();
                                Console.WriteLine();
                                for (int i = 0; i < 25; i++)
                                {
                                    integers.Add(Generator.Next(1, 25));
                                    Console.Write(integers[i]);
                                    if (i < 24)
                                    {
                                        Console.Write(", ");
                                    }
                                }
                                Console.WriteLine();
                                break;
                            case 3:
                                while (!done2)
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("Enter a number you would like to remove");
                                    Console.Write("Number:");
                                    if (!int.TryParse(Console.ReadLine(), out Number))
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine("INVALID INPUT!");
                                        Console.WriteLine();
                                    }
                                    else if (!integers.Contains(Number))
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine("INVALID INPUT!");
                                        Console.WriteLine();
                                    }
                                    else
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine("Removing...");Thread.Sleep(500);
                                        integers.RemoveAll(item => item == Number);
                                        for (int i = 0; i < integers.Count; i++)
                                        {
                                            Console.Write(integers[i]);
                                            if (i < integers.Count - 1)
                                                Console.Write(", ");
                                        }
                                        Console.WriteLine();
                                        done2 = true;
                                    }
                                }
                                break;
                            case 4:
                                while (!done2)
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("Enter a number you would like to add(min:1, max:1000)");
                                    Console.Write("Number:");
                                    if (int.TryParse(Console.ReadLine(), out Number)&& Number >= 1 && Number <= 1000)
                                    {
                                        integers.Add(Number);
                                        Console.WriteLine("Adding...");
                                        Thread.Sleep(500);
                                        for (int i = 0; i < integers.Count; i++)
                                        {
                                            Console.Write(integers[i]);
                                            if (i < integers.Count - 1)
                                                Console.Write(", ");
                                        }
                                        Console.WriteLine();
                                        done2 = true;
                                        
                                    }
                                    else
                                    {
                                        Console.WriteLine("Invalid Input");
                                        Console.WriteLine("Please try again");
                                    }
                                }
                                break;
                            case 5:
                                while (!done2)
                                {
                                    Console.WriteLine("Please select a number:");
                                    Console.Write("Number:");
                                    if (!int.TryParse(Console.ReadLine(), out Number))
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine("INVALID INPUT!");
                                        Console.WriteLine();
                                    }
                                    else if (!integers.Contains(Number))
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine("INVALID INPUT!");
                                        Console.WriteLine();
                                    }
                                    else
                                    {
                                        List<int> Found = integers.FindAll(item => item == Number);
                                        Console.WriteLine();
                                        Console.WriteLine("Finding...");
                                        Thread.Sleep(800);
                                        Console.WriteLine($"The number {Number} occurred {Found.Count} times in the list. ");
                                        done2 = true;
                                    }
                                }
                                break;
                            case 6:
                                Console.WriteLine();
                                Console.WriteLine("Searching...");Thread.Sleep(500);

                                Console.WriteLine();

                                max = integers.Max();
                                Console.WriteLine($"The largest value is {max}. ");

                                Console.WriteLine();
                                break;
                            case 7:
                                Console.WriteLine();
                                Console.WriteLine("Searching...");Thread.Sleep(500);

                                Console.WriteLine();

                                min = integers.Min();
                                Console.WriteLine($"The smallest value is {min}. ");

                                Console.WriteLine();
                                break;
                            case 8:
                                Console.WriteLine("Here is a new list for this function");
                                for (int i = 0; i < integers.Count; i++)
                                {
                                    Console.Write(integers[i]);
                                    if (i < integers.Count - 1)
                                        Console.Write(", ");
                                }
                                Console.WriteLine();
                                Console.WriteLine("Finding...");
                                Thread.Sleep(400);
                                Console.WriteLine();
                                Sum = integers.Sum();
                                Avg = integers.Average();
                                Avg = Math.Round(Avg, 2);
                                Console.WriteLine($"Your Sum is {Sum} and your Average is {Avg}.");
                                Console.WriteLine();
                                break;
                            case 9:
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.WriteLine("QUITING...");
                                Thread.Sleep(789);
                                done1 = true;
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
                int choice = -1, index;
                List <String> strings = new List <String>();
                Random Generator = new Random();
                Console.WriteLine("Here is your list...");
                List<string>vegetables = new List<string> {"CARROT, CELERY, BEET, RADISH, CABBAGE"};
                for(int i = 0; i < vegetables.Count; i++)
                {
                    Console.WriteLine($"{i + 1} - {vegetables[i]}");
                }
                while (!done)
                {
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
                    Console.Write("What would you like to do?(Type the number): ");
                    if (int.TryParse(Console.ReadLine(), out choice) && choice >= 1 && choice <= 6)
                    {
                        switch(choice)
                        {
                            case 1:
                                Console.Write("Type the index of the item you want to remove(Starts at 0):");

                                break;
                            case 2:
                                break;
                            case 3:
                                break;
                            case 4:
                                Console.WriteLine("Enter a vegetable you would like to add.");
                                Console.Write("Vegetable: ");
                                string Vege = Console.ReadLine().ToUpper();
                                vegetables.Add(Vege);
                                Console.WriteLine();
                                Console.WriteLine("Adding...");
                                Console.WriteLine();
                                Thread.Sleep(500);
                                for (int i = 0; i < vegetables.Count; i++)
                                {
                                    Console.Write(vegetables[i]);
                                    if (i < vegetables.Count - 1)
                                        Console.Write(", ");
                                }
                                Console.WriteLine();

                                break;
                            case 5:
                                Console.WriteLine();
                                Console.WriteLine("Sorting... ");
                                Thread.Sleep(1000);
                                vegetables.Sort();
                                for (int i = 0; i < vegetables.Count; i++)
                                {
                                    Console.Write(vegetables[i]);
                                    if (i < vegetables.Count - 1)
                                    {
                                        Console.Write(", ");
                                    }
                                }
                                Console.WriteLine(); Console.WriteLine(); Console.WriteLine();
                                break;
                            case 6:
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.WriteLine("QUITING...");
                                Thread.Sleep(789);
                                done = true;
                                break;

                        }
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Invalid Input!");
                        Console.WriteLine("Try Again.");
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}