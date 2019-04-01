using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
    class Program
    {
        static void Main(string[] args)
        {
            string miCadena = "adsfadsf";

            Console.WriteLine("Hola Mundo cruel y explotador" + miCadena);
            String entrada = Console.ReadLine();
            Console.WriteLine(entrada);


            String color;

            Console.Write("Digite un color ");
            color = Console.ReadLine();
            Console.WriteLine("El color digitado es {color}");

            int[] arreglo = { 1, 2, 3, 4, 5, 6, 7 };

            String[] arreglo_cadenas = new string[5];

            int[,] matriz = { { 1, 2 }, { 3, 4 } };

            Console.WriteLine("Digitar un numero ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            try
            {

            }
            catch(DivideByZeroException e)
            {

            }
            catch(FormatException e)
            {

            }
            finally
            {

            }
        }
        static void saludo()
        {
            Console.WriteLine("Saludo");
        }
        static void saludo(String saludo)
        {
            Console.WriteLine(saludo);
        }
        static int cubo(int num)
        {
            return num * num * num;
        }

    }
}
