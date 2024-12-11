namespace RPG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //referência a classe Personagem através da letra "m"
            Personagem personagem = new Personagem();
            Cenarios cenarios = new Cenarios();

            personagem.criarPersonagem();

            personagem.status();

            cenarios.combateComum();





        }
    }
}
