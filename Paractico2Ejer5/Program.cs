using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paractico2Ejer5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //List<int> valores = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

            //int SumaTotalValoresParesMayoresA8 = 0;
            //int SumaTotalValoresParesMenoresA8 = 0;

            //foreach(var valor in valores)
            //{

            //        if (valor % 2 == 0 && valor > 8)
            //        {
            //            SumaTotalValoresParesMayoresA8 += valor;
            //        }
            //        if (valor % 2 == 0 && valor < 8)
            //        {
            //            SumaTotalValoresParesMenoresA8 += valor;
            //        }



            //}
            //Console.WriteLine($"La suma total para los valores mayores a 8 es de : {SumaTotalValoresParesMayoresA8}");
            //Console.WriteLine($"La suma total para los valores mayores a 8 es de : {SumaTotalValoresParesMenoresA8}");


            //Ejercicio con linQ
            List<int> valores = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            
            var valoresParesMayores8 = valores.Where(x => x %2 == 0 && x >8).ToList();
            var valoresParesMenores8 = valores.Where(x => x % 2 == 0 && x < 8).ToList();
            var SumaMayores = valoresParesMayores8.Sum();
            var SumaMenores = valoresParesMenores8.Sum();

            Console.WriteLine("La suma de los mayores a 8 es de :" +SumaMayores);
            Console.WriteLine("La suma de los menores a 8 es de :" + SumaMenores);
        }





    }
}
