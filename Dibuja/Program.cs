using System;
using System.Threading;

namespace Dibuja
{
    class Program
    {
        public static void dibuja(int Cantidad)
        {
            int FilaFinal = 22; //FF
            int ColumnaFinal = 77; //CF
            int FilaInicial = 2; //FI
            int ColumnaInicial = 2; //CI
            int Fila, Columna, A;

            for (A = 1; A <= Cantidad; A++)
            {
                for (Fila = ColumnaInicial; Fila <= ColumnaFinal; Fila++)
                {
                    Console.SetCursorPosition(Fila, FilaFinal); Console.Write("?");
                    Console.SetCursorPosition(Fila, FilaInicial); Console.Write("?");
                }
                for (Columna = FilaInicial; Columna <= FilaFinal; Columna++)
                {
                    Console.SetCursorPosition(ColumnaInicial, Columna); Console.Write("X");
                    Console.SetCursorPosition(ColumnaFinal, Columna); Console.Write("X");
                }
                FilaInicial++;
                FilaFinal--;
                ColumnaInicial++;
                ColumnaFinal--;
            }//for principal
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            for (int tam = 1; tam < 9; tam++)
            {
                dibuja(tam);
                Thread.Sleep(1000);
            }
            Console.SetCursorPosition(25, 24);
            Console.Write("Pulse una tecla: ");
        }
    }
}

