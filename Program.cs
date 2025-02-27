using System;

class Program
{
    static void Main()
    {
        // Criar o array com 5 elementos
        int[] arraySoma = { 10, 20, 30, 40, 50 };

        // Inicializar a variável soma
        int soma = 0;

        // Somar os elementos do array
        for (int i = 0; i < arraySoma.Length; i++)
        {
            soma = soma + arraySoma[i];
        }

        // Exibir o resultado
        Console.WriteLine("A soma de todos os elementos é: " + soma);
    }
}