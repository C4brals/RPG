using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    internal class Eventos
    {
        
        Random roll = new Random();
        int rollPersonagem, rollInimigo;

        //Personagem Vs Inimigo
        public int combate(int inimigoPv,int inimigoDano, int personagemPv, int personagemDano, int HabilidadePaladino, int HabilidadeMago, bool StatusHabilidade, string Classe)
        {
            Personagem personagem = new Personagem();
            Inimigo inimigo = new Inimigo();

            Console.WriteLine("Iniciando o turno do combate...");
            Console.WriteLine();
            Console.ReadKey();

            do
            {
            combate:
                Console.WriteLine("Você e o inimigo rollam os dados...");
                Console.WriteLine();
                Console.ReadKey();
                rollInimigo = roll.Next(1, 7);
                rollPersonagem = roll.Next(1, 7);

                Console.WriteLine($"Você rollou {rollPersonagem} e seu inimigo {rollInimigo}.");
                Console.WriteLine();

                if (rollPersonagem > rollInimigo)
                {
                    Console.WriteLine("Você obteve sucesso, o que deseja fazer?");
                    Console.WriteLine($"1 - Atacar (Casusa {personagemDano}) de dano.");
                    Console.WriteLine($"2 - Usar Habilidade.");
                    Console.WriteLine();
                    string escolha = Console.ReadLine();

                    switch (escolha)
                    {
                        case "1":
                            {
                                Console.WriteLine($"Você ataca o inimigo e lhe causa {personagemDano} de dano.");
                                Console.WriteLine();
                                inimigoPv = inimigoPv - personagemDano;
                                Console.WriteLine($"Resultado desse turno: Seu PV é: {personagemPv}, e seu inimigo {inimigoPv} ");
                                Console.WriteLine("Pressione alguma tecla para continuar...");
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            }
                        case "2":
                            {
                                if (StatusHabilidade == true)
                                {
                                    if (Classe == "Paladino")
                                    {
                                        Console.WriteLine($"Você usou a habilidade LUZ CELESTE e recuperou 3 de PV.");
                                        Console.WriteLine();
                                        personagemPv = personagemPv + HabilidadePaladino;
                                        StatusHabilidade = false;
                                        Console.ReadKey();
                                        Console.Clear();
                                    }
                                    else
                                    {
                                        Console.WriteLine($"Você usou a habilidade BOLA DE FOGO, e causou 3 de dano ao PV inimigo!");
                                        Console.WriteLine();
                                        inimigoPv = inimigoPv - HabilidadeMago;
                                        StatusHabilidade = false;
                                        Console.ReadKey();
                                        Console.Clear();
                                    }
                                }

                                else
                                {
                                    Console.WriteLine("Sua habilidade não está disponível. Só lhe resta atacar!");
                                    Console.WriteLine();
                                    Console.WriteLine($"Você ataca o inimigo e lhe causa {personagemDano} de dano.");
                                    Console.WriteLine();
                                    inimigoPv = inimigoPv - personagemDano;
                                    Console.ReadKey();
                                    Console.Clear();
                                }
                                Console.WriteLine($"Resultado desse turno: Seu PV é: {personagemPv}, e seu inimigo {inimigoPv} ");
                                Console.WriteLine();
                                Console.WriteLine("Pressione alguma tecla para continuar...");
                                Console.WriteLine();
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("Favor selecionar uma opção válida!");
                                Console.WriteLine();
                                break;
                            }
                    }
                }

                else if (rollInimigo > rollPersonagem)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Seu inimigo obteve sucesso. Ele lhe ataca e causa 1 de dano!");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine();
                    personagemPv = personagemPv - inimigoDano;
                    Console.WriteLine($"Resultado desse turno: Seu PV é: {personagemPv}, e seu inimigo {inimigoPv} ");
                    Console.WriteLine("Pressione alguma tecla para continuar...");
                    Console.WriteLine();
                    Console.ReadKey();
                    Console.Clear();
                }
                
                else
                {
                    Console.WriteLine("Houve um empate! Os dados serão lançados novamente...");
                    Console.ReadKey();
                    Console.Clear();
                    goto combate;

                }               
            
            }
            while (inimigoPv > 0 && personagemPv > 0);

            

            if (inimigoPv <= 0)
            {
                Console.WriteLine("Você derrotou o inimigo!");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Você foi derrotado!");
                Console.WriteLine();
            }

            return personagemPv;
        }
    }
}
