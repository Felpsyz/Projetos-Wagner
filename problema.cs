using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Consoleapp1
{
    class Program
    {
        static void Main(string[] args){
            //exercício 1
            int r = int.Parse(Console.ReadLine());
            int a = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            for (int cont = 0; cont <= n;cont++){
                Console.WriteLine(a);
                a = a + r;
            }
            Console.ReadLine();
        }
    }
}