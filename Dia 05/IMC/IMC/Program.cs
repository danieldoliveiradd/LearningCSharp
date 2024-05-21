using System;

namespace CalculadoraIMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira a sua altura: ");
            double altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira o seu peso: ");
            double peso = double.Parse(Console.ReadLine());

            double imcResultado = peso / (altura * altura);

            if(imcResultado < 18.5 ) {
                Console.WriteLine("O seu IMC é: " + imcResultado.ToString("F2"));
                Console.WriteLine("A sua classificação é: Magreza");
            } 
            else if (imcResultado >= 18.5 && imcResultado <= 24.9)
            {
                Console.WriteLine("O seu IMC é: " + imcResultado.ToString("F2"));
                Console.WriteLine("A sua classificação é: Normal");
            } 
            else if (imcResultado >= 25.0 && imcResultado <= 29.9)
            {
                Console.WriteLine("O seu IMC é: " + imcResultado.ToString("F2"));
                Console.WriteLine("A sua classificação é: Sobrepeso");
            }
            else if (imcResultado >= 30.0 && imcResultado <= 39.9)
            {
                Console.WriteLine("O seu IMC é: " + imcResultado.ToString("F2"));
                Console.WriteLine("A sua classificação é: Obesidade");
            }
            else
            {
                Console.WriteLine("O seu IMC é: " + imcResultado.ToString("F2"));
                Console.WriteLine("Procure um nutricionista/médico sua saúde pode estar em perigo");
            }
        }
    }
}
