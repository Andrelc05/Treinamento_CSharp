using System;



namespace EX_Diagnóstico

{

    class Program
    {
        static void Main(string[] args)
        {

            int[] numeros = new int[10];


            Console.WriteLine("Digite Dez valores inteiros");


            //Loop For para preencher os dez(10) números

            for (int i = 0; i < 10; i++)
            {
                numeros[i] = int.Parse(Console.ReadLine());
            }

            //Console.WriteLine vazio para espaçamento

            Console.WriteLine();

            Console.Write("Digite o número para ser buscado: ");

            int pesquisa = int.Parse(Console.ReadLine());

            int j = 0;

            int verifica = 0;

            //Loop Foreach para percorrer o arrey

            foreach (var Valor in numeros)
            {
                if (numeros[j] == pesquisa)
                {
                    verifica = 1;
                }
                j++;
            }

            Console.WriteLine();

            //Lógica para saída do resultado de pesquisa

            if (verifica == 1)
            {
                Console.WriteLine($"O Número {pesquisa} foi encontrado com sucesso!");

                if (pesquisa % 2 == 0)
                {
                    Console.WriteLine($"O Número {pesquisa} é Par");
                }

                else
                {
                    Console.WriteLine($"O Número {pesquisa} é Impar");
                }
            }

            else
            {
                Console.WriteLine($"O Número {pesquisa} não foi encontrado");
            }
            Console.ReadKey();
        }
    }

}