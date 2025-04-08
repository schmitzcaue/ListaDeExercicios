namespace listaDeExercicios.Exercicio09
{
    internal class Program
    {
        //9. Escreva um algoritmo que leia três valores inteiros e diferentes e mostre-os em ordem decrescente.
        static void Main(string[] args)
        {
            while (true)
            {

                Console.Clear();
                Console.WriteLine("três valores inteiros e diferentes:");
                Console.ReadLine();

                Console.Write("Digite um valor para A: ");
                int valorDeA = Convert.ToInt32(Console.ReadLine());

                Console.Write("Digite um valor para B: ");
                int valorDeB = Convert.ToInt32(Console.ReadLine());

                Console.Write("Digite um valor para C: ");
                int valorDeC = Convert.ToInt32(Console.ReadLine());

                int[] valorABC = new int[] { valorDeA, valorDeB, valorDeC };

                if (valorDeA == valorDeB || valorDeA == valorDeC || valorDeB == valorDeC)
                {
                    Console.WriteLine($"Os valores de A,B e C devem ser diferentes!");
                    Console.ReadLine();
                }

                else
                {
                    Array.Sort(valorABC);
                    Array.Reverse(valorABC);

                    for (int i = 0; i < valorABC.Length; i++)
                    {
                        Console.WriteLine(valorABC[i]);
                        Console.ReadLine();

                    }
                }
            }

        }
    }
}