using System.Runtime.Intrinsics.X86;

namespace listaDeExercicios.Exercicio10
{
    internal class Program
    {
        //        10. O IMC – Índice de Massa Corporal é um critério da Organização Mundial de Saúde para dar uma indicação sobre
        //a condição de peso de uma pessoa adulta.A fórmula é IMC = peso / (altura)2.Elabore um algoritmo que leia o
        //peso e a altura de um adulto e mostre sua condição de acordo com a listagem abaixo:
        //● IMC em adultos Condição
        //● Abaixo de 18,5
        //● Abaixo do peso
        //● Entre 18,5 e 25 Peso normal
        //● Entre 25 e 30
        //● Acima do peso
        //● Acima de 30 obeso
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Digite um peso: ");
                double peso = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite uma altura: ");
                double altura = Convert.ToDouble(Console.ReadLine());

                double formulaImc = Convert.ToDouble(peso / (altura * altura));

                if (formulaImc < 18.5)
                {
                    Console.WriteLine($"O IMC é {formulaImc}, e está classificado como abaixo do peso.");
                    Console.ReadLine();
                }
                else if (formulaImc >= 18.5 && formulaImc <= 25)
                {
                    Console.WriteLine($"O IMC é {formulaImc}, e está classificado como peso normal.");
                    Console.ReadLine();
                }
                else if (formulaImc > 25 && formulaImc <= 30)
                {
                    Console.WriteLine($"O IMC é {formulaImc}, e está classificado como acima do peso.");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine($"O IMC é {formulaImc}, e está classificado como obeso.");
                    Console.ReadLine();
                }
            }
        }
    }
}