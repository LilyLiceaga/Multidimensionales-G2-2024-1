using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multidimensionales_G2_2024_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[,,] miArreglo = { { { 'a', 'b','c' }, { 'd', 'e', 'f' } }, { { 'g', 'h', 'i' }, { 'j', 'k', 'l' } } };

            Console.WriteLine(miArreglo[1, 1, 1]);
            Console.WriteLine( miArreglo.Length);
            Console.ReadLine();
            
        }
    }
}
