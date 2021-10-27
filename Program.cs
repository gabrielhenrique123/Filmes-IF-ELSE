using System;

namespace filmes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Recomendações de filmes por gênero");

            Console.WriteLine("Digite a opção do gênero desejado:");
            Console.WriteLine("1- Terror, 2- Ação, 3- Drama, 4- Comédia, 5- Romance");
            int f = Convert.ToInt32(Console.ReadLine());


            if (f == 1)
            {
                Console.WriteLine("TERROR:");
                Console.WriteLine("-------------------------------");
                Console.WriteLine("Invocação do mal 3 (1h52m)");
                Console.WriteLine("Doutor Sono (2h31m)");
                Console.WriteLine("Midsommar (2h20m)");
                Console.WriteLine("O exorcismo de Emily Rose (1h59m)");
                Console.WriteLine("O Iluminado (2h26)");
                Console.WriteLine("-------------------------------");
            }

            else if (f == 2)
            {

                Console.WriteLine("AÇÃO:");
                Console.WriteLine("-------------------------------");
                Console.WriteLine("Jumanji (2h03m)");
                Console.WriteLine("Riddick 3 (1h59m)");
                Console.WriteLine("Jungle Cruise (2h07m)");
                Console.WriteLine("Free Guy (1h55m)");
                Console.WriteLine("Eternos (2h37m)");
                Console.WriteLine("-------------------------------");
            }


            else if (f == 3)
            {
                Console.WriteLine("DRAMA:");
                Console.WriteLine("-------------------------------");
                Console.WriteLine("Sempre ao seu lado (1h33m)");
                Console.WriteLine("Dezessete (1h39m)");
                Console.WriteLine("Girl (1hr45m)");
                Console.WriteLine("A outra (1h55m)");
                Console.WriteLine("O quarto de Jack (1h58m)");
                Console.WriteLine("-------------------------------");
            }

            else if (f == 4)
            {
                Console.WriteLine("COMÉDIA:");
                Console.WriteLine("-------------------------------");
                Console.WriteLine("Minha mãe é uma peça (1h42m)");
                Console.WriteLine("Esposa de mentirinha (1h)");
                Console.WriteLine("Juntos e misturados (1h)");
                Console.WriteLine("As trapaceiras (1h34m)");
                Console.WriteLine("Duff (1h50m)");
                Console.WriteLine("-------------------------------");
            }

            else if (f == 5)
            {
                Console.WriteLine("ROMANCE:");
                Console.WriteLine("-------------------------------");
                Console.WriteLine("Por lugares incríveis (1h48m)");
                Console.WriteLine("A cinco passos de você (1h57m)");
                Console.WriteLine("Sol da meia-noite (1h32m)");
                Console.WriteLine("Juntos para sempre (1h)");
                Console.WriteLine("Como eu era antes de você (1h50m)");
                Console.WriteLine("-------------------------------");
            }

            else
            {

                Console.WriteLine("DIGITE UMA DAS OPÇÕES CITADAS!!");
            }



        }


    }
}