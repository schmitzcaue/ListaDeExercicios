namespace listaDeExercicios.Exercicio13
{
    internal class Program
    {
        //13. Escreva um algoritmo que leia um valor inicial A e imprima a sequência de valores do cálculo de A! e o seu resultado.
        //        a.Ex: 5! = 5 X 4 X 3 X 2 X 1 = 120
        //        b.Pesquise sobre “fatorial”
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Digite um valor para saber seu fatorial: ");
                decimal a = Convert.ToDecimal(Console.ReadLine());
                decimal numeroUsuarioInput = a;

                decimal fatorial = 1;
                string iJoin = "";

                #region fazendo com loop for
                // não há necessidade da variável numeroUsuarioInput com o for
                //for (decimal i = a; i >= 1; i--)
                //{
                //    if (i == 1) iJoin += i + "";

                //    else iJoin += i + " X ";

                //    fatorial *= i;
                //}
                #endregion

                while (a >= 1)
                {
                    if (a == 1) iJoin += a + "";

                    else iJoin += a + " X ";

                    fatorial *= a;
                    a--;
                }

                Console.WriteLine($"{numeroUsuarioInput}! = {iJoin} = {fatorial}");
                Console.ReadLine();
            }
        }
    }
}