using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o Projeto 5 - caracteres e textos");

        char letra = 'a';
        Console.WriteLine(letra);

        letra = (char)65;
        Console.WriteLine(letra);

        letra = (char)(65 + 1);
        Console.WriteLine(letra);

        string primeiraFrase = "Alura cursos de tecnologia ";
        Console.WriteLine(primeiraFrase + 2022);

        string vazia = "";
        Console.WriteLine(vazia);

        string cursos = @"Cursos disponíveis: 
- Go
- C#
- Python
- Java";
        Console.WriteLine(cursos);

        Console.ReadLine();
    }

}