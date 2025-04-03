namespace listaDeExercicios.Ex02
{
    internal class Program
    {
        //2. Crie um programa para calcular o volume de um Cilindro
        // V = PI .r2 . a
        static void Main(string[] args)
        {
            #region input
            Console.WriteLine("Digite o raio do cilindro");
            double raio = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a altura do cilindro: ");
            double altura = Convert.ToDouble(Console.ReadLine());
            #endregion

            #region metodo
            double volume = Math.PI * Math.Pow(raio, 2) * altura;
            #endregion

            #region output
            Console.WriteLine($" O raio do cilindro é: {raio}");
            Console.ReadLine();
            #endregion
        }
    }
}
