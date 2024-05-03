#region Enunciado
/*
1. Dado duas pilhas (p1, p2) que armazenam números inteiros, faça um programa que contenha as seguintes funções:

a) uma função para testar se as duas pilhas são iguais (tamanho), caso não forem informe qual a maior.

b) uma função que forneça o maior, o menor e a média aritmética de cada pilha.

c) uma função para transferir os elementos de pilha informada para uma pilha nova pilha e imprima.

d) uma função para retornar a quantidade e os elementos ímpares de cada pilha.

e) uma função para retornar a quantidade e os elementos pares de cada pilha.
*/
#endregion

namespace Ex_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            PilhaNumero MontarPilha()
            {
                PilhaNumero novaPilha = new PilhaNumero();
                int tamanho = new Random().Next(1, 30);
                for (int i = 0; i < tamanho; i++)
                {
                    novaPilha.Push(new Numero(new Random().Next(1, 200)));
                }
                return novaPilha;
            }
            void MaiorMenorMedia(PilhaNumero p)
            {
                Console.WriteLine("Maior:" + p.getMaior());
                Console.WriteLine("Menor:" + p.getMenor());
                Console.WriteLine("Media:" + p.getMedia());
            }
            void CompararPilhas(PilhaNumero p1, PilhaNumero p2)
            {
                if (p1.getTamanho() == p2.getTamanho())
                {
                    Console.WriteLine("As pilhas são iguais");
                }
                else if (p1.getTamanho() > p2.getTamanho())
                {
                    Console.WriteLine("Pilha 1 maior");
                }
                else
                {
                    Console.WriteLine("Pilha 2 maior");
                }
            }
            void ImprimirPilhaInvertida(PilhaNumero p)
            {
                PilhaNumero pilhaInvertida = p.InverterPilha();

                pilhaInvertida.ImprimirPilha();
            }
            void ParesImpares(PilhaNumero p)
            {
                Console.Write("Pares: ");
                p.ImprimirPares();

                Console.Write("Impares: ");
                p.ImprimirImpares();
            }

            PilhaNumero p1 = MontarPilha();
            PilhaNumero p2 = MontarPilha();


            while (true)
            {

                Console.WriteLine("\n\nSelecione uma opção");

                Console.WriteLine("1 - Imprimir Pilha 1");
                Console.WriteLine("2 - Imprimir Pilha 2");
                Console.WriteLine("3 - Retirar item da Pilha 1");
                Console.WriteLine("4 - Retirar item da Pilha 2");
                Console.WriteLine("5 - Comparar pilhas");
                Console.WriteLine("6 - Ver Menor, Maior e Média das Pilhas");
                Console.WriteLine("7 - Ver Pare e Impares de cada Pilha");
                Console.WriteLine("8 - Inverter Pilha 1");
                Console.WriteLine("9 - Inverter Pilha 2");
                Console.Write("Opção: < >\b\b");
                opcao = int.Parse(Console.ReadLine());
                Console.WriteLine("\n");
                switch (opcao)
                {
                    case 1:
                        p1.ImprimirPilha();
                        break;
                    case 2:
                        p2.ImprimirPilha();
                        break;
                    case 3:
                        p1.Pop();
                        Console.WriteLine("1 item removido...");
                        break;
                    case 4:
                        p2.Pop();
                        Console.WriteLine("1 item removido...");
                        break;
                    case 5:
                        CompararPilhas(p1, p2);
                        break;
                    case 6:
                        Console.WriteLine("\nPilha 1");
                        MaiorMenorMedia(p1);

                        Console.WriteLine("\nPilha 2");
                        MaiorMenorMedia(p2);
                        break;
                    case 7:
                        Console.WriteLine("\n\nPilha 1");
                        ParesImpares(p1);
                        Console.WriteLine("\n\nPilha 2");
                        ParesImpares(p2);
                        break;
                    case 8:
                        Console.WriteLine("Pilha 1 invertida");
                        ImprimirPilhaInvertida(p1);
                        break;
                    case 9:
                        Console.WriteLine("Pilha 2 invertida");
                        ImprimirPilhaInvertida(p2);
                        break;
                    case 0:
                        Console.WriteLine("Saindo...");
                        Console.ReadLine();
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Opção inválida...");
                        break;
                }

                Console.WriteLine("\nPressione Enter para continuar...");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
