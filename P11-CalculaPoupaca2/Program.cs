using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 11 - Calcula Poupança");

        // rendimento de 0.5% ao mês

        /*
        while (mes <= 12)
        {
            investimento = investimento + investimento * 0.005;
            Console.WriteLine("no mês " + mes + " você tem " + investimento);

            mes += 1;
        }
        */
        double investimento = 1000;

        for (int mes = 1; mes <= 12; mes = mes++)
        {
            investimento *= 1.005;
            Console.WriteLine("no mês " + mes + " você tem R$ " + investimento);
        }

        Console.ReadLine();
    }
}