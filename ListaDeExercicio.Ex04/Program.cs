namespace ListaDeExercicio.Ex04
{
    internal class Program
    {
        //4. Crie um programa para converter a temperatura da escala Celsius para a escala Fahrenheit
        static void Main(string[] args)
        {
            #region input
            Console.WriteLine("A temperatura da escala Celsius: ");
            double Celsius = Convert.ToDouble(Console.ReadLine());
            #endregion

            #region metodo
            //double temperatura =  (9/5 * Celsius + 32);
            double temperatura = ((Celsius * 9) / 5) + 32;
            #endregion

            #region output
            Console.WriteLine($"A temperatura da escala Fahrenheit é: {temperatura}");
            Console.ReadLine();
            #endregion


           
        }
    }
}
