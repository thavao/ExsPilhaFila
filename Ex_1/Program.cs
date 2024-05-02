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

            void CompararPilhas(PilhaNumero p1, PilhaNumero p2)
            {
                if(p1.getTamanho() == p2.getTamanho())
                {
                    Console.WriteLine("As pilhas são iguais");
                }
                else if(p1.getTamanho() > p2.getTamanho())
                {
                    Console.WriteLine("Pilha 1 maior");
                }
                else
                {
                    Console.WriteLine("Pilha 2 maior");
                }
            }
            PilhaNumero pilha1 = new PilhaNumero();
            Numero n1 = new(1);
            Numero n2 = new(3);
            Numero n3 = new(7);
            Numero n4 = new(8);

            pilha1.Push(n4);
            pilha1.Push(n3);
            pilha1.Push(n2);
            pilha1.Push(n1);
            pilha1.Pop();
            Console.WriteLine(pilha1.getTamanho());


        }
    }
}
