using System;

namespace Exercicio03AreaDeUmRetangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            double baseR;
            double altura;

            for (;;)
            {
                Console.Write("Informe a base do retângulo: ");
                baseR = Convert.ToDouble(Console.ReadLine());

                Console.Write("Informe a altura do retângulo: ");
                altura = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine();

                Retangulo retangulo = new Retangulo(baseR, altura);

                retangulo.EscreverValores();

                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
