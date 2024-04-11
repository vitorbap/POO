using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO1
{
    class Program
    {
        static void Main(string[] args)
        {
            //AULA DE ENCAPSULAMENTO E CONSTRUTOR
            /*Filme filme = new Filme("Ta dando onda!", "Qualquer coisa", 2008, "Dreamworks");
            Filme eraDoGelo = new Filme("Era do gelo", "", 2, "");

            eraDoGelo.AddAtor("Brad Pitt");
            eraDoGelo.AddAtor(null);//Não será exibido 
            eraDoGelo.AddAtor("Gyu");//Não será exibido
            eraDoGelo.AddAtor("Tom Cruise");
            eraDoGelo.ExibirAtores();
            */

            //-------------------------------------------

            //AULA DE HERANÇA
            /*
            Aluno a = new Aluno(); //Classe filho

            a.nome = "Vitor";
            a.email = "Vitao@gmail.com";
            a.senha = "123";
            a.turno = "Vespertino";
            a.Logar();
            a.Exibir();

            Usuario u = new Usuario(); //Classe Pai

            u.nome = "dasd";
            u.email = "daskjd@gmail.com";
            u.senha = "asdasd";

            Zelador z = new Zelador(); //Classe filho
            z.nome = "Ze";
            z.email = "ze@gmail.com";
            z.senha = "123";
            z.Exibir();
            */

            //--------------------------------------------

            //AULA CONSTRUTORES EM HERANÇA
            /*
            Aluno a = new Aluno("Matutino", "asdas", "dadas", "dasdad");
            a.Logar();
            a.Exibir();

            Zelador z = new Zelador("dasdas", "asdasd", "asdasd");
            z.Exibir();
            */

            //---------------------------------------------


            //AULA POLIMORFISMO NA HERANÇA
            /*
            Usuario u = new Aluno("Matutino", "dasdasdas", "asdasdas", "asdasdasda");
            Usuario u2 = new Zelador("ddasdasda", "asdasdasd", "asdasdas");

            Console.WriteLine(((Aluno)u).turno);

            u.Exibir();
            Console.WriteLine("=============================");
            u2.Exibir();
            
            */
            /*
            Aluno a = new Aluno("Matutino", "dasdasdas", "asdasdas", "asdasdasda");
            Zelador z = new Zelador("ddasdasda", "asdasdasd", "asdasdas");

            List<Usuario> usuarios = new List<Usuario>();
            usuarios.Add(a);
            usuarios.Add(z);

            //POLIMORFISMO DE SOBRECARGA E SOBREPOSIÇÃO---------------------
            //Logar(string, string)
            a.Logar("email", "asdasdasd");
            //Logar(int, string)
            a.Logar(123, "email");

            a.Exibir();
            */

            //INTERFACE e CLASSES ABSTRATAS

            //Line, Quad, Rect
            /*
         //IDrawable shape = new Quad();

         //shape.Draw();
         Console.ReadLine(); 

        }
        interface IDrawable
        {
            void Draw();
            float Area();
        }


        abstract class Drawable
        {
            public int size;
            public int color;

            public abstract void Draw();

            public abstract float Area();

        }

        class Line : IDrawable
        {
            public float Area()
            {
                return 20;
            }

            public void Draw()
            {
                Console.WriteLine("Linha");
            }
        }
        class Quad : IDrawable
        {
            public float Area()
            {
                return 2;
            }

            public void Draw()
            {
                Console.WriteLine("Quadrado");
            }
        }
        class Rect : IDrawable
        {
            public float Area()
            {
                return 10;
            }

            public void Draw()
            {
                Console.WriteLine("Retangulo");
            }
            */






        }

    }
}
