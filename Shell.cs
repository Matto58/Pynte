using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pynte
{
    public class Shell
    {
        public static void Main(string[] args)
        {
            Info info = new Info();
            Console.Title = "Pynte v" + info.Version + (info.IsDevVer ? " - Developer edition" : "");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Pynte ");
            Console.ResetColor();
            Console.Write("v" + info.Version);
            if (info.IsDevVer)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write(" \"");
                Console.Write(info.Codename);
                Console.WriteLine("\"");
                Console.ResetColor();
            }
            else Console.WriteLine();

            while (true)
            {
                Console.Write("> ");
                string[] input = Console.ReadLine().Split(" ".ToCharArray()[0]);
                Console.Title = "Pynte v" + info.Version + (info.IsDevVer ? " - Developer edition" : "") + " - " + input[0].ToLower();
                switch (input[0].ToLower())
                {
                    case "":
                        break;
                    case "help":
                        Console.WriteLine("Help:");
                        Console.WriteLine("exit - Exits the shell.");
                        Console.WriteLine("rand [max] - Generates a pseudo-random number.");
                        Console.WriteLine("randpx - Generates pseudo-random albeit chaotic colors.");
                        Console.WriteLine("help - Opens help.");
                        Console.WriteLine("clear - Clears the console.");
                        Console.WriteLine("\n[required arg] <optional arg>");
                        Console.WriteLine();
                        break;
                    case "clear":
                        Console.Clear();
                        break;
                    case "exit":
                        Environment.Exit(0);
                        break;
                    case "rand":
                        Random r = new Random();
                        if (input.Length < 2)
                            Console.WriteLine("No arguments passed, expected at least 1 argument");
                        else
                        {
                            try
                            {
                                Console.WriteLine(r.Next(Convert.ToInt32(input[1])));
                            }
                            catch
                            {
                                Console.WriteLine("Unexpected argument: " + input[1] + ", expected integer. If you entered a decimal point/comma, then it's not an integer.");
                            }
                        }
                        Console.WriteLine();
                        break;
                    case "randpx":
                        RandPx randPx = new RandPx();
                        randPx.Random();
                        Console.WriteLine();
                        break;
                    default:
                        Console.WriteLine("Unknown command: " + input[0]);
                        Console.WriteLine();
                        break;
                }
                Console.Title = "Pynte v" + info.Version + (info.IsDevVer ? " - Developer edition" : "");
            }
        }
    }
}
