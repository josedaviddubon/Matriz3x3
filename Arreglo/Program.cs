using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrizUno = { { 17, 9, 36 }, { 8, 7, 3 }, { 15, 28, 87 } };
            int[,] matrizDos = { { 9, 21, 36 }, { 16, 65, 4 }, { 12, 28, 31 } };


            int mayoresMatrizUno = 0;
            int mayoresMatrizDos = 0;
            int elementoIgual = 0;


            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (matrizUno[i,j]> matrizDos[i,j])
                    {
                        mayoresMatrizUno++;
                    }
                    else if (matrizUno[i, j] < matrizDos[i, j])
                    {
                        mayoresMatrizDos++;
                    }
                    else
                    {
                        elementoIgual++;
                    }

                }
            }

            Console.WriteLine($"El arreglo 1 contiene {mayoresMatrizUno} elementos mayores");
            Console.WriteLine($"El arreglo 2 contiene {mayoresMatrizDos} elementos mayores");
            Console.WriteLine($"Existen {elementoIgual} elementos iguales en ambos arreglos");

            Console.ReadLine();
        }

    }
}
