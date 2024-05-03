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


            PilhaNumero p1 = MontarPilha();
            PilhaNumero p2 = MontarPilha();


            Console.WriteLine("Pilha 1");


            p1.ImprimirPilha();
            MaiorMenorMedia(p1);

            Console.WriteLine(p1.getTamanho());
            p1.ImprimirPares();
            p1.ImprimirImpares();

            p1.Pop();
            PilhaNumero p1Invertida = p1.InverterPilha();

            Console.WriteLine("Pilha 1 invertida");
            p1Invertida.ImprimirPilha();
            MaiorMenorMedia(p1Invertida);
            Console.WriteLine(p1Invertida.getTamanho());



        }
    }
}
