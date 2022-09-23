using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_Intermediário
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string estacionamento, modelo, nome, placa, modeloVelho = "", modeloNovo = "", placaVelho = "", placaNovo = "", nomeVelho = "", nomeNovo = "";
            float valorhora, totalhora, mediaIdade, mediaVei, totVei = 0;
            int nveiculos = 0, i, idade = 0, ano, horas, totIdade = 0, maior = -11111, menor = 99999;
            Console.WriteLine("Digite o nome do estacionamento");
            estacionamento = Console.ReadLine();
            Console.WriteLine("Digite o valor da hora no estacionamento " + estacionamento);
            valorhora = float.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine("Qual é a quantidade de veículos que passaram pelo " + estacionamento);
                nveiculos = int.Parse(Console.ReadLine());
                if (nveiculos < 10)
                {
                    Console.WriteLine("A quantidade de carros deve ser, no mínimo, igual a 10(Dez)");
                }
            } while (nveiculos < 10);
            for (i = 1; i <= nveiculos; i++)
            {
                Console.WriteLine("Estacionamento " + estacionamento);

                Console.WriteLine("Digite os dados do veículo " + (i));
                Console.WriteLine("Digite quantas horas o veículo " + (i) + " ficou no estacionamento " + estacionamento);
                horas = int.Parse(Console.ReadLine());
                totalhora = valorhora * horas;
                totVei = (totVei + totalhora);
                Console.WriteLine("Digite em qual ano o veículo " + (i) + " nasceu");
                ano = int.Parse(Console.ReadLine());
                idade = (2022 - ano);
                totIdade = (totIdade + idade);
                Console.WriteLine("Digite o nome do modelo do veículo");
                modelo = Console.ReadLine();
                Console.WriteLine("Digite o nome do proprietário do veículo");
                nome = Console.ReadLine();
                Console.WriteLine("Digite a placa do veículo");
                placa = Console.ReadLine();
                if (idade > 0)
                {
                    if (maior < idade)
                    {
                        maior = idade;
                        modeloVelho = modelo;
                        placaVelho = placa;
                        nomeVelho = nome;
                    }
                    if (menor > idade)
                    {
                        menor = idade;
                        modeloNovo = modelo;
                        placaNovo = placa;
                        nomeNovo = nome;
                    }
                }
            }
            mediaIdade = totIdade / nveiculos;
            mediaVei = totVei / nveiculos;

            Console.WriteLine("Estacionamento " + estacionamento);

            Console.WriteLine("O valor médio pago por veículo é de: " + mediaVei + " R$");
            Console.WriteLine("A média de idade dos veículos é de: " + mediaIdade + " anos");
            Console.WriteLine("O valor total recebido pelo estacionamento " + estacionamento + " é de: " + totVei + "R$");

            Console.WriteLine("O carro mais velho é o de: " + maior + " anos. Modelo: " + modeloVelho + ". Placa: " + placaVelho + ". Proprietário: " + nomeVelho + ".");
            Console.WriteLine("O carro mais novo é o de: " + menor + " anos. Modelo: " + modeloNovo + ". Placa: " + placaNovo + ". Proprietário: " + nomeNovo + ".");

            Console.ReadKey();

        }
    }
}
