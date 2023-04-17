using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico2Ejer4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //List<int> valores = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //int sumaTotal = 0;

            //foreach (var valor in valores)
            //{
            //    sumaTotal = sumaTotal + valor;
            //}

            //Console.WriteLine(" La suma total es " + sumaTotal);
            //Console.ReadKey();



            //FUncion LinQ
            int[] SumaDeNumeros = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            int suma = SumaDeNumeros.Aggregate((total, nex) => total + nex);
            Console.WriteLine("lA SUMA TOTAL ES DE : " + suma);
            Console.ReadKey();

        }



    }
}
