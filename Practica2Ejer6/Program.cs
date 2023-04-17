using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2Ejer6
{
    internal class Program
    {
        static void Main(string[] args)



        // complegidad cognitiva es de 6
        {
            //    Console.WriteLine("Ingrese una letra minuscula desde A hasta F para saber cuales es la siguiente letra del abecedario");
            //    string letra = Console.ReadLine();

            //    if (letra == "a")
            //    {
            //        Console.WriteLine(" La siguiente letra del abecedaro es B");


            //    }
            //    if (letra == "b")
            //    {
            //        Console.WriteLine(" La siguiente letra del abecedaro es C");


            //    }
            //    if (letra == "c")
            //    {
            //        Console.WriteLine(" La siguiente letra del abecedaro es D");


            //    }
            //    if (letra == "d")
            //    {
            //        Console.WriteLine(" La siguiente letra del abecedaro es E");


            //    }
            //    if (letra == "e")
            //    {
            //        Console.WriteLine(" La siguiente letra del abecedaro es F");


            //    }
            //    if (letra == "f")
            //    {
            //        Console.WriteLine(" La siguiente letra del abecedaro es G");


            //    }



            List<string> abecedario = new List<string>() { "a", "b", "c", "d", "e", "f", "g" };
            Console.WriteLine("Ingrese una letra minuscula desde A hasta F para saber cuales es la siguiente letra del abecedario");
            string letra = Console.ReadLine();
            int posicion = abecedario.IndexOf(letra);
            posicion++;
            for (int i = 0; i < abecedario.Count; i++)
            {
                Console.WriteLine(" Su letra ingresada fue :" + letra);
                Console.WriteLine("La siguiente letra del abecedario es:" + abecedario[posicion][i]);
                break;



            }
        }




    }
}
