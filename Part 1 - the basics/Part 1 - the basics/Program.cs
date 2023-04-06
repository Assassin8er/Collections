namespace Part_1___the_basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstname = "Cash";
            string favMovie = "TheMatrix";
            favMovie = favMovie.ToLower();
            Console.WriteLine(firstname + favMovie);
            favMovie = favMovie.ToUpper();
            Console.WriteLine(favMovie);
            Console.WriteLine(favMovie.Contains("THE"));
            favMovie = favMovie.Replace("A","@").Replace("E", "3");
            Console.WriteLine(favMovie);
            string moviequote = ("May the Force be with you");
            Console.WriteLine(moviequote);
            moviequote = moviequote.Replace("e", "").Replace("a", "").Replace("o", "").Replace("i", "").Replace("u", "");
            Console.WriteLine(moviequote);

            Console.WriteLine("          .  .                    _,     _   _     ,_");
            Console.WriteLine("          |\\_|\\              .o888P      Y8o8Y      Y888o.");
            Console.WriteLine("          | $_$\\             d88888      88888      88888b");
            Console.WriteLine("          | | \"]            d888888b_  _d88888b_  _d888888b");
            Console.WriteLine("      ____| '-\\___          8888888888888888888888888888888");
            Console.WriteLine("     /.----.___.-'\\         8888888888888888888888888888888");
            Console.WriteLine("    //        _    \\        YJGS8P\"Y888P\"Y888P\"Y888P\"Y8888P");
            Console.WriteLine("   //   .-. (~v~) /|         Y888   '8'   Y8P   '8'   888Y");
            Console.WriteLine("  |'|  /\\:  .--  / \\         '8o           V          o8'");
            Console.WriteLine(" // |-/  \\_/____/\\/~|          `                      `");
            Console.WriteLine("|/  \\ |  []_|_|_] \\ |");
            Console.WriteLine("| \\  | \\ |___   _\\ ]_}");
            Console.WriteLine("| |  '-' /   '.'  |");
            Console.WriteLine("| |     /    /|:  | ");
            Console.WriteLine("| |     |   / |:  /\\");
            Console.WriteLine("| |     |   / |:  /\\");
            Console.WriteLine("| |    |  /  /  |    \\");
            Console.WriteLine("\\ |    |/\\/  |/|/\\    \\");
            Console.WriteLine(" \\|\\ |\\|  |  | / /\\/\\__\\");
            Console.WriteLine("  \\ \\| | /   | |__");
            Console.WriteLine("       / |   |____)");
            Console.WriteLine("       |_/");

        }
    }
}