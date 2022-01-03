using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio06TimeFutebol
{
    public class Time
    {
        public string Nome { get; set; }
        public string Apelido { get; set; }
        public DateTime Fundacao { get; }
        public List<Jogador> Plantel { get; set; }
        public List<Jogador> Relacionados { get; private set; }

        public Time(string nome, string apelido, DateTime fundacao, List<Jogador> plantel)
        {
            Nome = nome;
            Apelido = apelido;
            Fundacao = fundacao;
            Plantel = plantel;

            Relacionados = new();
        }

        private static int Comparador(Jogador x, Jogador y)
        {
            if (x.Qualidade == 0)
            {
                if (y.Qualidade == 0)
                    return 0;
                else
                    return -1;
            }
            else
            {
                if (y.Qualidade == 0)
                    return 1;
                else
                    return x.Qualidade.CompareTo(y.Qualidade);
            }
        }

        public void RelacionarJogadores()
        {
            Plantel.Sort(Comparador);
            Plantel.Reverse();

            Relacionados.AddRange(Plantel);

            for (int i = 17; i < Relacionados.Count; i++)
            {
                Relacionados.RemoveAt(i);
            }
        }
    }
}
