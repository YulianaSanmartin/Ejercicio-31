using System;

class Program
{
    static void Main()
    {
        int n;

        Console.Write("Ingrese orden de la matriz: ");
        n = int.Parse(Console.ReadLine());

        int[,] matriz = new int[n, n];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matriz[i, j] = i + j;
            }
        }

        Console.WriteLine();

        
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(matriz[i, j] + " \t");
            }
            Console.WriteLine();
        }

        Console.WriteLine();

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (j <= i)
                    Console.Write(matriz[i, j] + " \t ");
                else
                    Console.Write("   "); 
            }
            Console.WriteLine();
        }
    }
}

