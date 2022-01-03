using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03AreaDeUmRetangulo
{
    public class Retangulo
    {
        private double _base;
        private double _altura;

        public double Area { get; }
        public double Base 
        {
            get
            {
                return _base;
            }
            private set
            {
                if (value <= 0)
                    _base = 0;
                else
                    _base = value;
            }
        }
        public double Altura
        {
            get
            {
                return _altura;
            }
            private set
            {
                if (value <= 0)
                    _altura = 0;
                else
                    _altura = value;
            }
        }

        public Retangulo(double baseR, double altura) 
        {
            Base = baseR;
            Altura = altura;
            Area = Base * Altura;
        }

        public void EscreverValores()
        {
            if (Base == 0 || Altura == 0)
                Console.WriteLine("Valores incorretos!");
            else
            {
                Console.WriteLine("Base: " + Base + "cm");
                Console.WriteLine("Altura: " + Altura + "cm");
                Console.WriteLine();
                Console.WriteLine("Área: " + Area + "cm²");
            }
        }
    }
}
