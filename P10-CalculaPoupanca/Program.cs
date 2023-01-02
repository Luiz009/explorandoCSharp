using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 10 - Calcula Poupança");

        double investimento = 1000;

        // rendimento de 0.5% ao mês

        int mes = 1;
        while (mes <= 12)
        {
            investimento = investimento + investimento * 0.005;
            Console.WriteLine("no mês " + mes + " você tem " + investimento);

            mes += 1;
        }
        
        Console.ReadLine();
    }
}