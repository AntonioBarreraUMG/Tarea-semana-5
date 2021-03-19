using System;

namespace Número_aleatorio
{
    class Program
    {
        public static string GeneraLetra(int rango1, int rango2)
        {
            Random ran = new Random();

            int NUM = 0;

            do
            {
                NUM = Convert.ToInt32(ran.Next(107));
            } while (NUM < rango1 || NUM > rango2);

            string respuesta = "";

            respuesta = Convert.ToString((char)NUM);

            return respuesta;
        }

        static void Main(string[] args)
        {
            byte CAN, K;
            string linea;
            Console.Write("Cuantos numeros: ");
            linea = Console.ReadLine();
            CAN = byte.Parse(linea);
            string letras = "";
            for (K = 1; K <= CAN; K++)
            {
                letras = GeneraLetra(97, 106);
                Console.WriteLine($"EL codigo es {letras}");
            }
        }
    }
}
