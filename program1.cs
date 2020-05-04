using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace felpinhoxdnumsei
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Numero: ");
            int numero = int.Parse(Console.ReadLine());
            if (numero % 2 == 0)
                Console.WriteLine(numero + " = Par");
            else
                Console.WriteLine(numero + " = Impar");
            Console.ReadLine();
        }
    }
}