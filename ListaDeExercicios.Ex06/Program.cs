namespace ListaDeExercicios.Ex06
{
    internal class Program
    {
        //Crie um programa para calcular a média ponderada de duas provas realizadas por um aluno
        static void Main(string[] args)
        {
            #region input
            Console.WriteLine("Digite a primeira nota: ");
            double primeiraNota = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota: ");
            double segundaNota = Convert.ToDouble(Console.ReadLine());
            double pesoUm = 3;
            double pesoDois = 2;
            #endregion

            #region metodo
            //double temperatura =  (9/5 * Celsius + 32);
            double media = ((primeiraNota * pesoUm) + (segundaNota * pesoDois)) / (pesoUm + pesoDois);
            #endregion

            #region output
            Console.WriteLine($"A media do aluno é: {media}");
            Console.ReadLine();
            #endregion

        }
    }
}
