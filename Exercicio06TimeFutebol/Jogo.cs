using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio06TimeFutebol
{
    public class Jogo
    {
        private readonly List<Jogador> jogadoresTotais = new();

        public Time Mandante { get; }
        public Time Visitante { get; }
        public DateTime DataDoJogo { get; set; }
        public string Estadio { get; set; }
        public string Cidade { get; set; }
        public int PlacarMandante { get; set; }
        public int PlacarVisitante { get; set; }

        public Jogo(Time mandante, Time visitante, DateTime dataDoJogo, string estadio, string cidade)
        {
            Mandante = mandante;
            Visitante = visitante;
            DataDoJogo = dataDoJogo;
            Estadio = estadio;
            Cidade = cidade;

            jogadoresTotais.AddRange(Mandante.Relacionados);
            jogadoresTotais.AddRange(Visitante.Relacionados);
        }

        public void GerarResultados()
        {
            double totalQualidadeMandante = 0;
            double totalQualidadeVisitante = 0;

            for (int i = 0; i < 11; i++)
            {
                totalQualidadeMandante += Mandante.Relacionados[i].Qualidade;
                totalQualidadeVisitante += Visitante.Relacionados[i].Qualidade;
            }
        }

        public void GerarLesoes()
        {
            Random random = new();

            for (int i = 0; i <= random.Next(3); i++)
            {
                jogadoresTotais[random.Next(jogadoresTotais.Count)].SofrerLesao();
            }
        }

        public void GerarCartoes()
        {
            Random random = new();

            for (int i = 0; i <= random.Next(10); i++)
            {
                jogadoresTotais[random.Next(jogadoresTotais.Count)].AplicarCartao(1);
            }
        }

        public void PermitirTreinamento()
        {
            for (int i = 0; i < jogadoresTotais.Count; i++)
            {
                jogadoresTotais[i].Treinamento = 0;
            }
        }
    }
}
