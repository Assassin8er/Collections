namespace Part4NumGen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Random number gen
            int max, min, dice1, dice2, randint1, randint2, randint3;
            double randouble1, randouble2, randouble3;
            Console.WriteLine("Random Number Genarater");
            Console.WriteLine("Enter a minimum Value");
            min = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a max value");
            max = int.Parse(Console.ReadLine());
            Random random = new Random();
            Console.WriteLine("\nThe 5 Random numbers between {0} and {1} are:", min, max);
            for (int i = 0; i < 5; i++)
            {
                int
            RandomNumberInRange = random.Next(min, max);
                Console.WriteLine(" {0}, ", RandomNumberInRange);
            }
            Console.WriteLine("");//------------------------------------------
            Random myRandom = new Random();
            //Generates Random Number
            //Between 1 and 6\
            dice1 = myRandom.Next(1, 6);
            dice2 = myRandom.Next(1, 6);
            //Results
            Console.WriteLine($"You rolled {dice1} and {dice2}");
            Console.WriteLine(""); //-----------------------------------------
            
        }   
    }
}