namespace listaDeExercicios.Exercicio15
{
    internal class Program
    {
        //15. Escreva um programa que imprima os números de 1 a 100 em ordem crescente, - - - OK
        //  substituindo os números múltiplos de 3 pela palavra "Fizz" e  - - - OK
        //Um número é múltiplo de 3 se, ao ser dividido por 3, o resto for 0.  - - - OK
        //  os múltiplos de 5 pela palavra "Buzz".
        //  Para números que são múltiplos de ambos, use "FizzBuzz".
        static void Main(string[] args)
        {
            while (true)
            {
                for (int i = 1; i <= 100; i++)
                {
                    if (i % 3 == 0 && i % 5 == 0)
                    {
                        Console.WriteLine("FizzBuzz");
                    }

                    else if (i % 5 == 0)
                    {
                        Console.WriteLine("Buzz");
                    }
                    else if (i % 3 == 0)
                    {
                        Console.WriteLine("Fizz");
                    }

                    else Console.WriteLine(i);
                }
                Console.WriteLine("Fim");
                Console.ReadLine();
            }
        }
    }
}