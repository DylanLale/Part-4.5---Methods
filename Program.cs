using System.Security.Cryptography.X509Certificates;

namespace Part_4._5___Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DrawMickey();
            Draw007();
            DrawPacMan();
            Joke();
        }



        public static void DrawMickey()
        {
            Console.WriteLine("         .-\"\"\"-. ");
            Console.WriteLine("        /       \\ ");
            Console.WriteLine("        \\       /");
            Console.WriteLine(" .-\"\"\"-.-`.-.-.<  _ ");
            Console.WriteLine("/      _,-\\ ()()_/:) ");
            Console.WriteLine("\\     / ,  `     `|");
            Console.WriteLine(" '-..-| \\-.,___, /");
            Console.WriteLine("       \\ `-.__/  /");
            Console.WriteLine("        `-.__.- '` ");
        }

        public static void Draw007()
        {
            Console.WriteLine("     0000             0000        7777777777777777/========___________");
            Console.WriteLine("   00000000         00000000      7777^^^^^^^7777/ || ||   ___________");
            Console.WriteLine("  000    000       000    000     777       7777/=========//");
            Console.WriteLine(" 000      000     000      000             7777// ((     //");
            Console.WriteLine("0000      0000   0000      0000           7777//   \\   //");
            Console.WriteLine("0000      0000   0000      0000          7777//========//");
            Console.WriteLine("0000      0000   0000      0000         7777");
            Console.WriteLine("0000      0000   0000      0000        7777");
            Console.WriteLine(" 000      000     000      000        7777");
            Console.WriteLine("  000    000       000    000       77777");
            Console.WriteLine("   00000000         00000000       7777777");
            Console.WriteLine("     0000             0000        777777777");
        }
        public static void DrawPacMan()
        {
            Console.WriteLine("================================================.");
            Console.WriteLine("     .-.   .-.     .--.                         |");
            Console.WriteLine("    | OO| | OO|   / _.-' .-.   .-.  .-.   .''.  |");
            Console.WriteLine("    |   | |   |   \\  '-.'-'   '-'  '-'   '..'  |");
            Console.WriteLine("    '^^^' '^^^'    '--'                         |");
            Console.WriteLine("===============.  .-.  .================.  .-.  |");
            Console.WriteLine("               | |   | |                |  '-'  |");
            Console.WriteLine("               | |   | |                |       |");
            Console.WriteLine("               | ':-:' |                |  .-.  |");
            Console.WriteLine("               |  '-'  |                |  '-'  |");
            Console.WriteLine("==============='       '================'       |");
        }

        public static void Joke()
        {
            Console.WriteLine("Knock Knock");
            Thread.Sleep(2000);
            Console.WriteLine("Who's There?");
            Thread.Sleep(2000);
            Console.WriteLine("Tank");
            Thread.Sleep(2000);
            Console.WriteLine("Tank Who?");
            Thread.Sleep(2000);
            Console.WriteLine("You're Welcome");
        }

    }
}