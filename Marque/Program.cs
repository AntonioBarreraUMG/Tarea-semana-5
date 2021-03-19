using System;
using System.Threading;

namespace Marque
{
    class Program
    {
        public static string Mid(string parametro, int startindex, int length)
        {
            string result = parametro.Substring(startindex, length);
            return result;
        }

        public static void marque(string Nombre)
        {
            string Caracter; //CAR
            int K = 0;
            int P = 0;
            int ColumnaInicial = 0; //CI
            int ColumnaFinal = 0; //CF
            Console.SetCursorPosition(1, 12);
            Console.Write(Nombre);
            ColumnaInicial = Nombre.Length;
            ColumnaFinal = 70;
            Nombre = Nombre.ToUpper();

            for (P = Nombre.Length; P >= 1; P--)
            {
                Caracter = Mid(Nombre, P - 1, 1);
                for (K = ColumnaInicial; K <= ColumnaFinal; K++)
                {
                    Console.SetCursorPosition(K, 12);
                    Console.Write(" " + Caracter);
                    Thread.Sleep(50);
                }
                ColumnaFinal--;
                ColumnaInicial--;
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            string Nombre; //NOM
            Console.Write("Ingrese su nombre: ");
            Nombre = Console.ReadLine();
            marque(Nombre);
        }

    }
}
