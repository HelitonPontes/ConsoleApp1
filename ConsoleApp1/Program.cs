using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioUdemyVariaveis

{
    class Program
    {
        static void Main(string[] args)
        {
            string menu;
            Console.WriteLine("------------------------------");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("XXXXXXXXXXX Menu XXXXXXXXXXXXX");
            Console.WriteLine("EX01");
            Console.WriteLine("EX02");
            Console.WriteLine("EX03");
            Console.WriteLine("EX04");
            Console.WriteLine("EX05");
            Console.WriteLine("EX06");
            Console.WriteLine("Sair");


            menu = Console.ReadLine();

            while (menu != "Sair")
            {

               
                Console.WriteLine("------------------------------");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("XXXXXXXXXXX Menu XXXXXXXXXXXXX");
                Console.WriteLine("EX01");
                Console.WriteLine("EX02");
                Console.WriteLine("EX03");
                Console.WriteLine("EX04");
                Console.WriteLine("EX05");
                Console.WriteLine("EX06");
                Console.WriteLine("Sair");

                menu = Console.ReadLine();


                switch (menu)
                {



                    case "EX01":
                        Console.WriteLine("------------------------------");
                        Console.WriteLine("XXXXXXXXXXXProdutosXXXXXXXXXXXXX");
                        string produto1 = "Computador";
                        string produto2 = "Mesa de Escritório";

                        byte idade = 30;
                        int codigo = 5290;
                        char genero = 'M';

                        double preco1 = 2100;
                        double preco2 = 650.50;
                        double medida = 53.234567;
                        string frase;





                        Console.WriteLine("------------------------------");
                        Console.WriteLine("");
                        Console.WriteLine("XXXXXXXXXXXProdutos01XXXXXXXXXXXXX");
                        Console.WriteLine("");
                        Console.WriteLine($"{produto1} preço: {preco1}");
                        Console.WriteLine($"{ produto2} preço: { preco2}");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine($"Registro: {idade} anos de idade, Codigo: {codigo} e genero: {genero}");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine($"A medida com 8 casas decimais: {medida:f8}");
                        Console.WriteLine($"A medida com 2 casas decimais: {medida:f2}");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("------------------------------");

                        Console.WriteLine("Digite seu nome");
                        Console.WriteLine("Seu nome: " + (Console.ReadLine()));

                        Console.WriteLine("-------------------------------");

                        Console.WriteLine("Digite sua idade");
                        int idade1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Sua idade: " + idade1);



                        Console.WriteLine("-------------------------------");
                        Console.WriteLine("XXXXXXXXXXXExercicio01XXXXXXXXXXXXX");

                        Console.WriteLine("Digite seu nome: ");
                        string nome1 = Console.ReadLine();
                        Console.WriteLine("Seu nome: " + nome1);

                        Console.WriteLine("Digite sua idade: ");
                        int idade2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Sua idade: " + idade2);

                        Console.WriteLine("Quantos quartos possui a sua casa: ");
                        int quartos = int.Parse(Console.ReadLine());
                        Console.WriteLine("Sua casa possui " + quartos + " quartos");

                        Console.WriteLine("Valor Produto: ");
                        double produto = double.Parse(Console.ReadLine());
                        Console.WriteLine("Valor Produto: " + produto);

                        Console.WriteLine("-------------------------------");
                        Console.WriteLine("Seu nome: " + nome1);
                        Console.WriteLine("Sua idade: " + idade2);
                        Console.WriteLine("Sua casa possui " + quartos + " quartos");
                        Console.WriteLine("Valor Produto: " + produto);
                        Console.WriteLine("Seu nome: " + nome1 + " idade: " + idade2 + ". Sua casa possui " + quartos + " quartos. Produto: " + produto);
                        Console.WriteLine("-------------------------------");

                        Console.ReadKey();

                        break;

                    case "EX02":



                        Console.WriteLine("XXXXXXXXXXXExercicio02XXXXXXXXXXXXX");

                        Console.WriteLine("Digite um numero: ");
                        int n1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite um numero: ");
                        int n2 = int.Parse(Console.ReadLine());
                        int resultado = n1 + n2;
                        Console.WriteLine("O Resultado da Soma: " + resultado);

                        Console.WriteLine("-------------------------------");

                        break;

                    case "EX03":

                        Console.WriteLine("XXXXXXXXXXXExercicio03XXXXXXXXXXXXX");

                        Console.WriteLine("Digite um numero: ");
                        int n3 = int.Parse(Console.ReadLine());

                        if (n3 % 2 == 0)
                        {
                            Console.WriteLine("Voce digitou: " + n3);
                            Console.WriteLine("Numero Par");

                        }
                        else
                        {
                            Console.WriteLine("Voce digitou: " + n3);
                            Console.WriteLine("Nuumero Impar");

                        }


                        Console.WriteLine("-------------------------------");

                        Console.ReadKey();

                        break;


                    case "EX04":


                        Console.WriteLine("XXXXXXXXXXXExercicio04XXXXXXXXXXXXX");
                        Console.WriteLine("-------------------------------");
                        Console.WriteLine("Digite um numero: ");
                        int n4 = int.Parse(Console.ReadLine());

                        if (n4 > 0)
                        {
                            Console.WriteLine("Numero Positivo");

                        }
                        else
                        {
                            Console.WriteLine("Voce digitou: " + n4);
                            Console.WriteLine("Numero Negativo");

                        }


                        Console.WriteLine("-------------------------------");

                        break;

                    case "EX05":

                        Console.WriteLine("XXXXXXXXXXXExercicio05XXXXXXXXXXXXX");

                        Console.WriteLine("-------------------------------");

                        Console.WriteLine("Digite um numero: ");
                        double n5 = double.Parse(Console.ReadLine());

                        while (n5 > 0.00)
                        {
                            double raiz = Math.Sqrt(n5);
                            Console.WriteLine(raiz.ToString("F2"));
                            Console.WriteLine("Digite outro valor: ");
                            n5 = double.Parse(Console.ReadLine());

                        }
                        Console.WriteLine("Numero Negativo");
                        Console.ReadKey();
                        Console.WriteLine("-------------------------------");

                        break;

                    case "EX06":

                        Console.WriteLine("-------------------------------");

                        Console.WriteLine("XXXXXXXXXXXExercicio06XXXXXXXXXXXXX");

                        Console.WriteLine("Digite o numero para fazer a contagem crescente e descrecente: ");
                        Console.WriteLine("");
                        int nun = int.Parse(Console.ReadLine());

                        for (int i = 1; i <= nun; i++)

                            Console.WriteLine(i);

                        Console.WriteLine("-------------------------------");

                        for (int i = nun; nun >= 0; nun--)

                            Console.WriteLine(nun);

                        Console.WriteLine("-------------------------------");

                        Console.ReadKey();

                        break;
                }
            }

            

        }
    }

   
}
