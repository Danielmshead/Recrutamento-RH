using System;
using System.Collections.Generic;
using System.Linq;

namespace ImpareslW
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.Clear();

            var numeros = new[] {1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144};
            var Impar = new List<int>();

            Console.WriteLine("Numeros impares em sequencia: \n");
            Impar =  numeros.Where(x => x % 2 != 0).ToList();
            Impar.ForEach(Console.WriteLine);

            Console.ReadKey();
        }
    }
}