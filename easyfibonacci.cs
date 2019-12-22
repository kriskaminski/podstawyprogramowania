using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
           {
                int a = 0;
                int b = 1;
                for (int i = 1; i <= 20; i++)
                {
                    int backupA = a;
                    a = b;
                    b = backupA + b;
                    Console.WriteLine($"F({i}) = {a}");
                }
            }
        }
    }
}
