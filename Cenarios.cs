using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    internal class Cenarios
    {
        public int rollPersonagem, rollInimigo;
        Random roll = new Random();
        Personagem personagem = new Personagem();

        public void combateComum()
        {
            //declaração de variáveis
            int pvInimigoComum = 1, inimigoDano = 1, inimigoDanoCritico = 2;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Combate com um inimugo comum!");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();

            do
            {
                inicioCombateComum:
                Console.WriteLine("Você e o inimigo rolam os dados...");
                Console.WriteLine();
                rollPersonagem = roll.Next(1,12);
                rollInimigo = roll.Next(1,12);

                Console.WriteLine($"Seu roll: {rollPersonagem}, roll do inimigo: {rollInimigo}");

                if (rollPersonagem > rollInimigo)
                {
                    Console.WriteLine("Você ataca o inimigo!");
                    pvInimigoComum = pvInimigoComum - personagem.dano;
                }
                else if( rollPersonagem == rollInimigo)
                {
                    Console.WriteLine("Ocorreu um empate, os dados serão lançados novamente");
                    goto inicioCombateComum;
                }
                else
                {
                    if (rollInimigo >= 12)
                    {
                        Console.WriteLine("O inimigo tem um acerto crítico!");
                        personagem.pvPersonagem = personagem.pvPersonagem - inimigoDanoCritico;
                    }
                    else
                    {
                        Console.WriteLine("O inimigo lhe ataca!");
                        personagem.pvPersonagem = personagem.pvPersonagem - inimigoDano;
                    }
                    
                }
                Console.WriteLine();

                //resumo do turno
                Console.WriteLine($"------ Situação atual do inimigo - PV: {pvInimigoComum} ------");
                Console.ReadKey();
                Console.WriteLine();
                personagem.status();

            }
            while (pvInimigoComum > 0 && personagem.pvPersonagem > 0);



            Console.WriteLine("A luta terminou...");
            Console.WriteLine();
            Console.ReadKey();
            
        }

        public void combateElite()
        {

        }

        public void combateLorde()
        {

        }
    }
}
