using System;
using System.Linq;

namespace Removerduplicadosdoarray
{
    class Program
    {  
        static void Main(string[] args)
        {
            int[] primeiroarray = { 1, 3, 7, 29, 42, 98, 234, 93};
            int[] segundoarray = { 4, 6, 93, 7, 55, 32, 3 }; 

           
            int[] combinedarray = primeiroarray.Union(segundoarray).ToArray();

            Console.WriteLine("Aqui estao somente os números do primeiro array que não estao contidos no segundo array: " + String.Join(",", combinedarray));
        }
    }
}
