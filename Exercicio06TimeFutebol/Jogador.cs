using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio06TimeFutebol
{
    public class Jogador
    {
        public int Id { get; }
        public string Nome { get; }
        public string Apelido { get; set; }
        public DateTime DataNascimento { get; }
        public int Numero { get; set; }
        public string Posicao { get; set; }
        public double Qualidade { get; set; }
        public int Cartoes { get; set; }
        public bool Suspenso { get; private set; }
        public int Treinamento { get; set; }

        public Jogador(int id, string nome, string apelido, DateTime dataNascimento, int numero, string posicao, int qualidade) 
        {
            Id = id;
            Nome = nome;
            Apelido = apelido;
            DataNascimento = dataNascimento;
            Numero = numero;
            Posicao = posicao;
            Qualidade = qualidade;

            Treinamento = 0;
        }

        public bool VerificarCondicaoDeJogo() 
        {
            if (Cartoes >= 3)
                Suspenso = false;
            else
                Suspenso = true;

            return Suspenso;
        }

        public void AplicarCartao(int quantidade) 
        {

            Cartoes = quantidade;
        }

        public void CumprirSuspencao()
        {
            Cartoes = 0;
            Suspenso = true;
        }

        public void SofrerLesao()
        {
            Random random = new();
            int prob = random.Next(100);

            if (prob >= 0 && prob <= 40)
                Qualidade -= 1;
            
            if (prob > 40 && prob <= 70)
                Qualidade -= 2;
            
            if (prob > 70 && prob <= 85)
                Qualidade -= (Qualidade * 0.05);
            
            if (prob > 85 && prob <= 95)
                Qualidade -= (Qualidade * 0.10);

            else
                Qualidade -= (Qualidade * 0.15);
            
            
            if (Qualidade < 0)
                Qualidade = 0;
        }

        public void ExecutarTreinamento()
        {
            Random random = new();
            int prob = random.Next(100);

            Treinamento++;

            if (Treinamento == 1)
            {
                if (prob >= 0 && prob <= 40)
                    Qualidade += 1;

                if (prob > 40 && prob <= 70)
                    Qualidade += 2;

                if (prob > 70 && prob <= 85)
                    Qualidade += 3;

                if (prob > 85 && prob <= 95)
                    Qualidade += 4;

                else
                    Qualidade += 5;


                if (Qualidade > 100)
                    Qualidade = 100;
            }
            else
                Treinamento = 0;
        }
    }
}
