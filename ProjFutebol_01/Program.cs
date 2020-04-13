using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjFutebol_01
{
    class Program
    {
        static void Main(string[] args)
        {

            int Referencia;
            do
            {
                Console.Write("\n\n   Atividade 04 - Programação Orientada a Objetos\n   Aluno: Luís Gustavo C. Lenzi - Ciência da Computação");
                Console.Write("\n\n   > [Selecione uma das opções abaixo] <\n\n");
                Console.WriteLine("   [1] - Atribuir partida");
                Console.WriteLine("   [2] - Sair");
                Console.Write("\n   Digite aqui qual será a referência desejada >: ");
                Referencia = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                do
                {
                    switch (Referencia)
                    {
                        case 1:
                            Console.Write("\n\n   Atividade 04 - Programação Orientada a Objetos\n   Aluno: Luís Gustavo C. Lenzi - Ciência da Computação");
                            Console.Write("\n\n   > [Atribuindo Partida] <");
                            Console.Write("\n\n   Digite qual será o primeiro time >: ");
                            string ttime1 = System.Console.ReadLine();
                            Console.Write("   Digite qual será o segundo time >: ");
                            string ttime2 = System.Console.ReadLine();
                            Time Time1 = new Time(ttime1, ttime2);
                            Time Time2 = new Time(ttime2, ttime1);
                            Partida Partida = new Partida(DateTime.Now, Time1, Time2);
                            Console.Clear();
                            Console.Write("\n\n   Atividade 04 - Programação Orientada a Objetos\n   Aluno: Luís Gustavo C. Lenzi - Ciência da Computação");
                            Console.Write("\n\n   > [Resultado] <");
                            Partida.jogar();
                            Console.Write(Partida.getPlacar());
                            Console.WriteLine(Time1.getStatus());
                            Console.WriteLine(Time2.getStatus());
                            Console.Write("\n   Deseja conferir quais eram os jogadores da partida? [S/N] >: ");
                            string Escalacao = System.Console.ReadLine();
                            Console.Clear();
                            switch (Escalacao)
                            {
                                case "s":
                                    Console.Write("\n\n   Atividade 04 - Programação Orientada a Objetos\n   Aluno: Luís Gustavo C. Lenzi - Ciência da Computação");
                                    Time1.contratarJogadores(new Jogador("Astolfo", 20, 99, 1));
                                    Time1.contratarJogadores(new Jogador("Reinaldo", 25, 99, 2));
                                    Time1.contratarJogadores(new Jogador("Luquinhas", 30, 99, 3));
                                    Time1.contratarJogadores(new Jogador("Klóvis", 35, 99, 4));
                                    Time1.contratarJogadores(new Jogador("Cleiton", 40, 99, 5));
                                    Time1.contratarJogadores(new Jogador("Vanderlei", 45, 99, 6));
                                    Time1.contratarJogadores(new Jogador("Grenildo", 50, 99, 7));
                                    Time1.contratarJogadores(new Jogador("Astrogildo", 55, 99, 8));
                                    Time1.contratarJogadores(new Jogador("Biruleibe", 60, 99, 9));
                                    Time1.contratarJogadores(new Jogador("Tonico", 65, 99, 10));
                                    Time1.contratarJogadores(new Jogador("Tinoco", 70, 99, 11));
                                    Console.Write("\n\n   [Jogadores Escalados - " + ttime1 + "]\n");
                                    Time1.getDescricaoJogadores();
                                    Time2.contratarJogadores(new Jogador("Sancankler", 21, 99, 1));
                                    Time2.contratarJogadores(new Jogador("Jeremias", 22, 99, 2));
                                    Time2.contratarJogadores(new Jogador("Flávio", 35, 67, 3));
                                    Time2.contratarJogadores(new Jogador("Virgílio", 89, 67, 4));
                                    Time2.contratarJogadores(new Jogador("Lucão", 25, 48, 5));
                                    Time2.contratarJogadores(new Jogador("Henricão", 25, 50, 6));
                                    Time2.contratarJogadores(new Jogador("Jandir", 25, 13, 7));
                                    Time2.contratarJogadores(new Jogador("Lebron", 25, 17, 8));
                                    Time2.contratarJogadores(new Jogador("Kuzuado", 25, 24, 9));
                                    Time2.contratarJogadores(new Jogador("Evandrão", 25, 13, 10));
                                    Time2.contratarJogadores(new Jogador("Zandir", 25, 99, 11));
                                    Console.Write("\n\n   [Jogadores Escalados - " + ttime2 + "]\n");
                                    Time2.getDescricaoJogadores();
                                    Console.Write("\n\n   [Pressione qualquer tecla para continuar]");
                                    Console.ReadKey();
                                    break;
                                case "S":
                                    Console.Write("\n\n   Atividade 04 - Programação Orientada a Objetos\n   Aluno: Luís Gustavo C. Lenzi - Ciência da Computação");
                                    Time1.contratarJogadores(new Jogador("Astolfo", 20, 99, 1));
                                    Time1.contratarJogadores(new Jogador("Reinaldo", 25, 99, 2));
                                    Time1.contratarJogadores(new Jogador("Luquinhas", 30, 99, 3));
                                    Time1.contratarJogadores(new Jogador("Klóvis", 35, 99, 4));
                                    Time1.contratarJogadores(new Jogador("Cleiton", 40, 99, 5));
                                    Time1.contratarJogadores(new Jogador("Vanderlei", 45, 99, 6));
                                    Time1.contratarJogadores(new Jogador("Grenildo", 50, 99, 7));
                                    Time1.contratarJogadores(new Jogador("Astrogildo", 55, 99, 8));
                                    Time1.contratarJogadores(new Jogador("Biruleibe", 60, 99, 9));
                                    Time1.contratarJogadores(new Jogador("Tonico", 65, 99, 10));
                                    Time1.contratarJogadores(new Jogador("Tinoco", 70, 99, 11));
                                    Console.Write("\n\n   [Jogadores Escalados - " + ttime1 + "]\n");
                                    Time1.getDescricaoJogadores();
                                    Time2.contratarJogadores(new Jogador("Flávio", 35, 67, 3));
                                    Time2.contratarJogadores(new Jogador("Virgílio", 89, 67, 4));
                                    Time2.contratarJogadores(new Jogador("Lucão", 25, 48, 5));
                                    Time2.contratarJogadores(new Jogador("Henricão", 42, 50, 6));
                                    Time2.contratarJogadores(new Jogador("Jandir", 18, 13, 7));
                                    Time2.contratarJogadores(new Jogador("Lebron", 28, 17, 8));
                                    Time2.contratarJogadores(new Jogador("Kuzuado", 23, 24, 9));
                                    Time2.contratarJogadores(new Jogador("Evandrão", 19, 13, 10));
                                    Time2.contratarJogadores(new Jogador("Zandir", 33, 99, 11));
                                    Console.Write("\n\n   [Jogadores Escalados - " + ttime2 + "]\n");
                                    Time2.getDescricaoJogadores();
                                    Console.Write("\n\n   [Pressione qualquer tecla para continuar]");
                                    Console.ReadKey();
                                    break;
                                case "n":
                                    Console.Write("\n   [ < Voltar]");
                                    Console.ReadKey();
                                    break;
                                case "N":
                                    Console.Write("\n   [ < Voltar]");
                                    Console.ReadKey();
                                    break;
                            }
                            break;
                        case 2:
                            break;
                    }
                    break;
                } while (Referencia != 2);
                Console.Clear();
            } while (Referencia != 2);
        }
    }
}
