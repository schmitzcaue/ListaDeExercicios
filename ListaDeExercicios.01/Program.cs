namespace ListaDeExercicios._01
{
    internal class Program
    {

        //1. Crie um programa para calcular o volume de uma caixa retangular
        // volume da caixa comp + largura + altura
        static void Main(string[] args)
        {
            #region input de dados
            Console.WriteLine("digite o comprimento da ciaxa");
            decimal comprimento = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("digite a largura da ciaxa");
            decimal largura = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("digite a altura da ciaxa");
            decimal altura = Convert.ToDecimal(Console.ReadLine());
            #endregion

            #region processamento
            decimal resultado = comprimento + largura + altura;
            #endregion

            #region output
            Console.WriteLine($"O volume da caixa é: {resultado}.");
            Console.ReadLine();
            #endregion
        }
    }
}
