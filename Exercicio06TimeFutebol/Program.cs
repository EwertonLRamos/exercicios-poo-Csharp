using System;
using System.Collections.Generic;

namespace Exercicio06TimeFutebol
{
    class Program
    {
        static void Main(string[] args)
        {
            Jogador jogador01 = new(1, "Gabriel", "Biel",     new DateTime(2000, 7, 12),  3,  "Zagueiro", 75);
            Jogador jogador02 = new(2, "João",    "Jão",      new DateTime(1999, 10, 5),  7,  "Meia",     85);
            Jogador jogador03 = new(3, "Marcos",  "Marcão",   new DateTime(2001, 11, 28), 11, "Atacante", 90);
            Jogador jogador04 = new(4, "Mateus",  "Teteu",    new DateTime(2002, 1, 21),  6,  "Zagueiro", 85);
            Jogador jogador05 = new(5, "Jonas",   "Jo",       new DateTime(2000, 12, 7),  10, "Atacante", 80);
            Jogador jogador06 = new(6, "José",    "Zé",       new DateTime(1994, 5, 30),  5,  "Zagueiro", 65);
            Jogador jogador07 = new(7, "Helton",  "Heltinho", new DateTime(1999, 9, 5),   7,  "Meia",     70);
            Jogador jogador08 = new(8, "Josué",   "Josa",     new DateTime(2002, 3, 28),  9,  "Atacante", 95);
            Jogador jogador09 = new(9, "Lucas",   "Luk",      new DateTime(1997, 7, 21),  2,  "Zagueiro", 95);
            Jogador jogador10 = new(10,"Enzo",    "Enzo",     new DateTime(2001, 5, 13),  20, "Atacante", 60);

            List<Jogador> jogadoresTime1 = new()
            {
                jogador01,
                jogador02,
                jogador03,
                jogador04,
                jogador05
            };

            List<Jogador> jogadoresTime2 = new()
            {
                jogador06,
                jogador07,
                jogador08,
                jogador09,
                jogador10
            };

            Time time1 = new("Sport",   "Melhor do Nordeste", new DateTime(1905, 5, 13), jogadoresTime1);
            Time time2 = new("Nautico", "Hexacampeão",        new DateTime(1901, 4, 7),  jogadoresTime2);

            time1.RelacionarJogadores();
            time2.RelacionarJogadores();

            for (int i = 0; i < time1.Relacionados.Count; i++)
            {
                Console.WriteLine(time1.Relacionados[i].Qualidade);
            }

            Console.WriteLine("");

            for (int i = 0; i < time2.Relacionados.Count; i++)
            {
                Console.WriteLine(time2.Relacionados[i].Qualidade);
            }
            
            Console.ReadLine();
        }
    }
}
