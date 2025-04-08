namespace ListaDeExercicios.Ex08
{
    internal class Program
    {
       // 8. Faça um algoritmo que leia os valores A, B, C e imprima na tela se a soma de A + B é menor que C.
        static void Main(string[] args)
        {
            #region input
            Console.WriteLine("Digite o valor A: ");
            double valorA = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o valor B: ");
            double valorB = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o valor C: ");
            double valorC = Convert.ToDouble(Console.ReadLine());

            #endregion

            #region metodo
            if (valorA + valorB < valorC)
            {
                Console.WriteLine($"A soma de A ({valorA}) + B ({valorB}) é menor que C ({valorC})");
                Console.ReadLine();

            }


            #endregion

            #region output

            #endregion
        }
    }
}
