
namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> Numbs = new List<int>();
            bool done = false;bool done1 = false;
            Console.WriteLine("WELCOME USER! THIS IS COLLLECTIONS.");
            while (!done)
            {
                Console.WriteLine("eNTER AN OPTION BELOW!!!!!!!!!!!!!!!!!");
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
                done = true;
            }
        }
    }
}