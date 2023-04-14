
namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice1 = 0, choice2 = 0;
            bool done = false; bool done1 = false; bool done2 = false; bool done3 = false;

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
        }
        static void INTEGERS()
        {
            Console.WriteLine();
            Console.WriteLine(" >>>>>>>>>>>>>>>>>INTEGERS<<<<<<<<<<<<<<<<<");
            Console.WriteLine(" __________________________________________");
            Console.WriteLine("|1:Sort list                               |");
            Console.WriteLine("|2:Make new list                           |");
            Console.WriteLine("|3:Remove a number (by value)              |");
            Console.WriteLine("|4:Add a value to the list                 |");
            Console.WriteLine("|5:Count occurrences of a specified number |");
            Console.WriteLine("|6:Print the largest value                 |");
            Console.WriteLine("|7:Print the smallest value                |");
            Console.WriteLine("|8:Print the sum and average of # in list  |");
            Console.WriteLine("|9:most frequently occurring value(s)      |");
            Console.WriteLine("|10:QUIT                                   |");
            Console.WriteLine(" ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^ ");
            Console.WriteLine();
        }
        static void STRINGS()
        {

            Console.WriteLine();
            Console.WriteLine(" >>>>>>>>>>>STRINGS<<<<<<<<<<<");
            Console.WriteLine(" _____________________________");
            Console.WriteLine("|1:INTEGERS                   |");
            Console.WriteLine("|2:STRINGS                    |");
            Console.WriteLine("|3:QUIT                       |");
            Console.WriteLine("|4:|");
            Console.WriteLine("|5:|");
            Console.WriteLine("|6:|");
            Console.WriteLine(" ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
            Console.WriteLine();
        }
    }
}
        