
namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Lchoice = 0;
            bool done = false;bool done1 = false;
            Console.WriteLine("WELCOME USER! THIS IS COLLLECTIONS.");
            while (!done)
            {
                Console.WriteLine("Enter an option below.");
                Console.WriteLine(" ______________________________________");
                Console.WriteLine("|1:Sort the list                       |");
                Console.WriteLine("|2:Make a new list of random numbers   |");
                Console.WriteLine("|3:Remove a number (by value)          |");
                Console.WriteLine("|4:Add a value to the list             |________________");
                Console.WriteLine("|5:Count the number of occurrences of a specified number|");
                Console.WriteLine("|6:Print the largest value                              |");
                Console.WriteLine("|7:Print the smallest value                             |");
                Console.WriteLine("|8:Print the sum and average of the numbers in the list |");
                Console.WriteLine("|9:Determine the most frequently occurring value(s)     |______________");
                Console.WriteLine("|10:specify a value and the number of occurrences of that # in the list|");
                Console.WriteLine("|11:Quit                                                               |");
                Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
                if (int.TryParse(Console.ReadLine(), out Lchoice) && Lchoice >= 1 && Lchoice <= 11)
                {
                    if (Lchoice == 1)
                    {

                    }
                    else if (Lchoice == 2)
                    {

                    }
                    else if (Lchoice == 3)
                    {

                    }
                    else if (Lchoice == 4)
                    {

                    }
                    else if (Lchoice == 5)
                    {

                    }
                    else if (Lchoice == 6)
                    {

                    }
                    else if (Lchoice == 7)
                    {

                    }
                    else if (Lchoice == 8)
                    {

                    }
                    else if (Lchoice == 9)
                    {

                    }
                    else if (Lchoice == 10)
                    {

                    }
                    else if (Lchoice == 11)
                    {
                        Console.WriteLine("GoodBye!");
                        done = true;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Input!!!");
                }
            }
        }
    }
}