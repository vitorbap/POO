using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO1
{
    class Usuario
    {
        public string nome;
        public string email;
        public string senha;
        protected string teste;

        public Usuario(string nome, string email, string senha)
        {
            this.nome = nome;
            this.email = email;
            this.senha = senha;
        }
        
        public void Logar()
        {
            Console.WriteLine(teste);
            Console.WriteLine("Logando...");
        }
        //Logar(string)
        public void Logar(string codigo)
        {
            Console.WriteLine("Logando com cod...");
        }
        //Logar(string, string)
        public void Logar(string email, string senha)
        {
            Console.WriteLine("Logando com email e senha...");
        }
        //Logar(string, int)
        public void Logar(string email, int pin)
        {
            Console.WriteLine("Logando com email e pin...");
        }
        //Logar(int, string)
        public void Logar(int pin, string email)
        {
            Console.WriteLine("Logando com pin e email...");
        }

        public virtual void Exibir() //Colocar a palavra chave "virtual" voce consegue chamar ela nas classes filho
        {
            Console.WriteLine($"E-mail:{email}");
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Senha: {senha}");
        }

    }

    


    class Aluno : Usuario
    {
        public List<string> turmas = new List<string>();
        public string turno = "Matutino";

        public void TestandoMod()//Testando o modificador de acesso (Protected)
        {
            Console.WriteLine(teste);
        }

        public Aluno(string turno, string nome, string email, string senha): base(nome, email, senha)
        {
            this.turno = turno;
        }
        public override void Exibir()//Override = sobrescrever
        {
            Console.WriteLine("Dados do aluno: ");
            base.Exibir();
            Console.WriteLine("Turno: " + turno);
        }

    }




    class Zelador : Usuario
    {
        public List<string> tarefas = new List<string>();

        public Zelador(string nome, string email, string senha): base(nome, email, senha)
        {

        }
    }
}
