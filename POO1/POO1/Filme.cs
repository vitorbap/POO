using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO1
{
    class Filme
    {
        public string nome;
        public string desc;
        public int ano;
        public string studio;
        public List<string> atores = new List<string>();

        static public string plataforma = "Prime Video";
        //Metodo "static" - Campos estaticos só podem ser acessados pela classe e campos não estaticos só podem ser acessados por objetos da Classe.

        public Filme(string nome, string desc, int ano, string studio)
        {
            this.nome = nome;
            this.desc = desc;
            this.ano = ano;
            this.studio = studio;

            // É possivel fazer lógica dentro do construtor 

        }

        public void Executar()
        {
            Console.WriteLine($"Rodando filme: {nome}");

        }

        static public void Pausar()
        {
            Console.WriteLine("Pausado!");
        }

        public void AddAtor(string nome)
        {   
            if(nome != null)
            {
                atores.Add(nome);
            }
            
        }

        public void ExibirAtores()
        {
            foreach(string ator in atores)
            {
                Console.WriteLine(ator);
            }
        }

    }
}
