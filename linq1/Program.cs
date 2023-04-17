using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace linq1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Ejercio 1

            var valores = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var suma = 0;
           
            foreach (var valor in valores)
            {
                suma += valor;
            }
            Console.WriteLine(suma);
            Console.ReadKey();


            //Ejercicio 2

            var Valores2 = new List<int> { 1, 2, 3, 4, 5,6,7,8,9 };
            var suma2 = 0;

            foreach (var valor in valores)
            {
                if (valor % 2 == 0)

                    suma += valor;
            }

            Console.WriteLine(suma2);
            Console.ReadKey();


            //Ejercicio 3

            var valores3 = new List<int> () { 1, 2, 3, 4, 5,6,7,8,9 };
            for(var indice =0; indice <valores3.Count -1;indice++)

            {
                if(valores3[indice]< valores3[indice + 1])
                {
                    var valorTemporal = valores3[indice];
                    valores3[indice] = valores3[indice + 1];
                    valores3[indice + 1] = valorTemporal;
                    indice = -1;
                }
            }
            foreach (var valorOrdenado in valores3)
            {
                Console.WriteLine(valorOrdenado);
            }

            Console.WriteLine("");
            Console.ReadKey();

            //Ejercicio 4

            var valoresLq4 = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8,9,10 };
            var valoresOrdenados2 = valoresLq4.OrderByDescending(x => x); 

          /*  for (var indice =0; indice <valores4.Count -1;indice++)
            {
                if (valores4[indice] > valores4[indice + 1])
                {
                    var valorTemporal = valores4[indice];
                    valores4[indice] = valores4[indice + 1];
                    valores4[indice + 1] = valorTemporal;
                    indice = -1;
                }
            }*/

            foreach (var valorOrdenado in valoresOrdenados2)
            {
                Console.Write(valorOrdenado);

            }
            Console.WriteLine("");
            Console.ReadKey();

        }
    }
}
