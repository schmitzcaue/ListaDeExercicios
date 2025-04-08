namespace listaDeExercicios.Exercicio11
{
    internal class Program
    {
        //11. Faça um algoritmo para receber um número qualquer e informar na tela se é par ou ímpar.
        //postite/////////////////////////////////////
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Write("Digite um número: ");

            int numeroDigitado = Convert.ToInt32(Console.ReadLine());

            if (numeroDigitado % 2 == 0)
            {
                Console.Write($"{numeroDigitado} é um número par!");
                Console.ReadLine();
            }
            else
            {
                Console.Write($"{numeroDigitado} é um número ímpar!");
                Console.ReadLine();
            }
        }
    }
}