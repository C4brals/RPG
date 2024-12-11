using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    internal class Personagem
    {
        #region Declaração de Variáveis
        //declaração de variáveis
        public string nomePersonagem;
        public int curaCelere = 3, laminaDaRedencao = 2, pocaoCura = 2, dano = 1, pvPersonagem = 5;
        bool hab1 = true, hab2 = true, boolPocaoCura = false;
        #endregion

        public void status()
        {
            Console.WriteLine($"------ Situação atual do seu Personagem ------");
            Console.WriteLine();
            Console.WriteLine($"Vida (PV): {pvPersonagem}");
            Console.WriteLine();

            //verificação de inventário
            Console.WriteLine("------ Inventário ------");
            if (hab1 == true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Cura Célere");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Cura Célere");
                Console.ForegroundColor = ConsoleColor.White;
            }
            if (hab2 == true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Lâmina da Redenção");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Lâmina da Redenção");
                Console.ForegroundColor = ConsoleColor.White;
            }
            if (boolPocaoCura == true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Poção de Cura");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Poção de Cura");
                Console.ForegroundColor = ConsoleColor.White;
            }
            Console.WriteLine();
            Console.WriteLine("Habilidade 1 - Cura célere: Recupere 3 de PV.");
            Console.WriteLine("Habilidade 2 - Lâmina da Redenção: Causa 2 de dano ao PV inimigo");
            Console.WriteLine("Poção de Cura: Recupera 2 de PV");
            Console.WriteLine();
            Console.WriteLine("Pressione uma tecla para continuar...");
            Console.WriteLine();
            Console.ReadKey();

        }
        
        public void criarPersonagem()
        {
            Console.Write("Nome do Personagem:");
            nomePersonagem = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine($"Olá {nomePersonagem} Você iniciará a campanha com duas habilidades:");
            Console.WriteLine();
            Console.WriteLine("Habilidade 1 - Cura célere: Recupere 3 de PV.");
            Console.WriteLine("Habilidade 2 - Lâmina da Redenção: Causa 2 de dano ao PV inimigo");
            Console.WriteLine();
            Console.WriteLine("Pressione uma tecla para continuar...");
            Console.ReadKey();
            Console.WriteLine();

        }      
    }
}
