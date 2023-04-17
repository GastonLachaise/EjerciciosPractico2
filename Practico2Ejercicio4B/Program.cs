using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico2Ejercicio4B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List <int> numeros = new List<int>() {1,2,3,4,5,6,7,8,9,10};

            //  int sumaPares = 0;

            //foreach (var valor in numeros)
            //{
              

            //    if (valor % 2 == 0)
            //    {
            //        sumaPares += valor ;
            //    }
            //}

            //Console.WriteLine("la Suma de todos los pares es de :" + sumaPares);

            //Console.ReadKey();



            // Con LinQ
           var valores = new  List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
           var valoresPares = valores.Where(x => x % 2 == 0).ToList();
            var sumaConLq = valoresPares.Sum();
            Console.WriteLine("la suma de los valores pares es de :" + sumaConLq);

        }
    }
}
