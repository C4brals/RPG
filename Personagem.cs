using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace RPG
{
    internal class Personagem
    {
        //Declaração de Variáveis
        private string _nome { get; set; }
        private string _classe { get; set; }
        private int _dano { get; set; }
        private int _pv { get; set; }
        private int _habilidadePaladino { get; set; }
        private int _habilidadeMago { get; set; }
        private bool _statusHabilidade {  get; set; }

        //Propriedades
        public string Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                _nome = value;
            }
        }
        public string Classe
        {
            get
            {
                return _classe;
            }
            set
            {
                _classe = value;
            }
        }
        public int Dano
        {
            get
            {
                return _dano;
            }
            set
            {
                _dano = value;
            }
        }
        public int Pv
        {
            get
            {
                return _pv;
            }
            set
            {
                _pv = value;
            }
        }
        public int HabilidadePaladino
        {
            get
            {
                return _habilidadePaladino;
            }
            set
            {
                _habilidadePaladino = value;
            }
        }
        public int HabilidadeMago
        {
            get
            {
                return _habilidadeMago;
            }
            set
            {
                _habilidadeMago = value;
            }
        }
        public bool StatusHabilidade
        {
            get
            {
                return _statusHabilidade;
            }
            set
            {
                _statusHabilidade = value;
            }
        }

        //Métodos
        public void ataque()
        {

        }

        public void status()
        {
            bool escolha;
            string opcao;
            escolha = false;

            do
            {
                Console.WriteLine($"Selecione o que deseja fazer:");
                Console.WriteLine();
                Console.WriteLine("1 - Proceder para próxima etapa. | 2 - Mostrar seus status.");
                Console.WriteLine();
                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        {
                            escolha = true;
                            break;
                        }
                    case "2":
                        {                            
                            Console.WriteLine($"Situação atual de {Nome} - Classe {Classe}: Pontos de Vida (PV): {Pv}, Dano: {Dano}");
                            if (StatusHabilidade == true)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Habilidade disponível.");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Habilidade indisponível.");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            Console.WriteLine();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Favor selecionar uma opção válida");
                            Console.WriteLine();
                            break;
                        }
                        
                }
            }
            while (escolha == false);
        }

        public void criarPersonagem()
        {
            Console.Write("Nome do personagem: ");
            Nome = Console.ReadLine();
            Pv = 5;
            Dano = 1;

            Console.WriteLine("Selecione a sua Classe:");
            Console.WriteLine("1 - Paladino");
            Console.WriteLine("2 - Mago");
            Console.WriteLine();
            string escolha = Console.ReadLine();

            switch (escolha)
            {
                case "1":
                    {
                        Console.WriteLine("Você selecionou a classe PALADINO.");
                        Console.WriteLine("Sua habilidade é LUZ CELESTE: Recupere 3 do seu PV");
                        Console.WriteLine();
                        HabilidadePaladino = 3;
                        Classe = "Paladino";
                        StatusHabilidade = true;
                        break;
                    }
                case "2":
                    {
                        Console.WriteLine("Você selecionou a classe MAGO.");
                        Console.WriteLine("Sua habilidade é BOLA DE FOGO: Cause 3 de dano ao PV inimigo.");
                        Console.WriteLine();
                        HabilidadeMago = 3;
                        Classe = "Mago";
                        StatusHabilidade = true;
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Favor selecionar uma classe!");
                        Console.WriteLine();
                        break;
                    }
            }
        }

        public void vantagem()
        {

        }

        public void desvantagem()
        {

        }
        

    }
}
