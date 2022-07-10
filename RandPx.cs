using System;
using System.Threading;

namespace Pynte
{
    public class RandPx
    {
        public void Random()
        {
            Random r = new Random();
            int a = 100;
            int b = 100;
            int aaaa = r.Next(10);
            for (int y = 0; y < a; y += aaaa)
            {
                int bbbb = r.Next(10);
                for (int x = 0; x < b; x += bbbb)
                {
                    Console.BackgroundColor = (ConsoleColor)r.Next(16);
                    Console.Write(Mult(" ", (int)Math.Round((decimal)(Math.Max(aaaa, bbbb) + 1) / (Math.Min(aaaa, bbbb) + 1) / 2)));
                    bbbb = r.Next(10);
                    Thread.Sleep(2);
                    if (x > b) break;
                }
                if (y > a) break;
                aaaa = r.Next(10);
                Thread.Sleep(4);
            }
            Console.ResetColor();
            Console.WriteLine();
        }
        internal string Mult(string a, int b)
        {
            string c="";for(int i=0;i<b;i++)c+=a;return c;
        }
    }
}
