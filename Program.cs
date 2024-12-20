namespace RPG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Personagem personagem = new Personagem();
            Inimigo inimigo = new Inimigo();
            Eventos eventos = new Eventos();

            personagem.criarPersonagem();
            personagem.status();

            #region ATO I

            Console.WriteLine("Você encontra um Goblin! A primeita luta se inicia. ");
            Console.WriteLine();
            inimigo.Pv = 2;
            inimigo.Dano = 1;
            Console.WriteLine($"O Goblin possui {inimigo.Pv} de PV e seus ataques causam {inimigo.Dano} de dano. ");
            Console.WriteLine();      

            //eventos.combate(inimigo.Pv,inimigo.Dano, personagem.Pv, personagem.Dano, personagem.HabilidadePaladino, personagem.HabilidadeMago, personagem.StatusHabilidade, personagem.Classe);

            personagem.Pv = eventos.combate(inimigo.Pv, inimigo.Dano, personagem.Pv, personagem.Dano, personagem.HabilidadePaladino, personagem.HabilidadeMago, personagem.StatusHabilidade, personagem.Classe);

            personagem.status();

            #endregion

            Console.WriteLine();






        }
    }
}
