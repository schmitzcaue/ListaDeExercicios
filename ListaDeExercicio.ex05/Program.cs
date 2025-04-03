namespace ListaDeExercicio.ex05
{
    internal class Program
    {
        //Crie um programa para calcular o salário total de um vendedor. Deverá ser informado o salário base e o total de
        //vendas.A comissão é calculada com um percentual(informado pelo usuário) sobre o total de vendas.
        static void Main(string[] args)
        {
            #region input
            Console.Write("Digite o salário base do vendedor: ");
            double salarioInicial = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a quantidade de vendas: ");
            double qtdvendas = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a comissão do vendedor: ");
            double comissao = Convert.ToDouble(Console.ReadLine());

           
            #endregion

            #region processamento
            double resultado = ((comissao * qtdvendas) / 100) + salarioInicial;
            #endregion

            #region output
            Console.WriteLine($"O salario total dele foi de é: {resultado}");
            Console.ReadLine();
            #endregion
        }
    }
}
