
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
                Console.WriteLine(" >>>>>>>>>>MAIN MENU<<<<<<<<<<");
                Console.WriteLine(" _____________________________");
                Console.WriteLine("|1:INTEGERS                   |");
                Console.WriteLine("|2:STRINGS                    |");
                Console.WriteLine("|3:QUIT                       |");
                Console.WriteLine(" ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
                string choice = Console.ReadLine();
                switch (choice.ToLower())
                {
                    case "1":
                        INTEGERS();
                        break;
                    case "2":
                        STRINGS();
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
                int choice = -2;
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
                        switch{
                            case 1:
                                Console.WriteLine("Case 1");
                                break;
                            case 2:
                                Console.WriteLine("Case 2");
                                break;
                            case 3:
                                Console.WriteLine("Case 3");
                                break;
                            case 4:
                                Console.WriteLine("Case 4");
                                break;
                            case 5:
                                Console.WriteLine("Case 5");
                                break;
                            case 6:
                                Console.WriteLine("Case 6");
                                break;
                            case 7:
                                Console.WriteLine("Case 7");
                                break;
                            case 8:
                                Console.WriteLine("Case 8");
                                break;
                            case 9:
                                Console.WriteLine("Case 9");
                                break;
                        }
                    }
                    else
                    {
                        Console.Writeline("Invalid Input");
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