using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o Projeto 13 - Encadeando For");

        for (int contadorLinhas = 0; contadorLinhas < 10; contadorLinhas++)
        {
            for (int contadorColunas = 0; contadorColunas <= contadorLinhas; contadorColunas++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        Console.ReadLine();
    }
}