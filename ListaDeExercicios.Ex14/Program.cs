namespace listaDeExercicios.Exercicio14
{
    internal class Program
    {
        //14. Escreva um programa que leia um número e imprima a sequência de Fibonacci até esse número.
        //0, 1, 1, 2, 3, 5, 8, 13, 21, 34, ...
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Digite um valor para saber a sequência de Fibonacci: ");
                decimal limite = Convert.ToDecimal(Console.ReadLine());
                decimal numeroUsuarioInput = limite;

                decimal fibonacci = 1;
                decimal anterior = 0;
                decimal atual = 1;
                string iJoin = "0, 1";

                while (atual < limite)
                {
                    decimal proximo = anterior + atual;
                    if (proximo > limite) break;

                    else iJoin += ", " + proximo;

                    anterior = atual;
                    atual = proximo;
                }

                Console.WriteLine($"Sequência de Fibonacci até {limite}: {iJoin}");
                Console.ReadLine();
            }
        }
    }
}