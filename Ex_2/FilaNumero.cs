using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_2
{
    internal class FilaNumero
    {
        Numero cabeca;
        Numero cauda;
        int tamanho;
        int maior;
        int menor;
        float media;

        public FilaNumero()
        {
            cabeca = null;
            cauda = null;
            tamanho = 0;
        }
        bool Vazio()
        {
            return cabeca == null;
        }
        public void Push(Numero aux)
        {
            if (Vazio())
            {
                cabeca = aux;
                cauda = aux;
                tamanho++;
            }
            else
            {
                cauda.setProximo(aux);
                cauda = aux;
                tamanho++;
            }
        }
        public void Pop()
        {
            if (!Vazio())
            {
                cabeca = cabeca.getProximo();
                tamanho--;
            }
        }
        public int getTamanho()
        {
            return tamanho;
        }
        void DefinirMaiorMenorMedia()
        {
            if (!Vazio())
            {
                Numero aux = cabeca;
                int num = aux.getValor();
                int maior = num, menor = num, soma = 0;

                do
                {
                    num = aux.getValor();
                    if (num > maior)
                        maior = num;

                    else if (num < menor)
                        menor = num;

                    soma += num;
                    aux = aux.getProximo();
                } while (aux != null);

                this.media = (float)soma / (float)this.tamanho;
                this.menor = menor;
                this.maior = maior;
            }
        }
        public void ImprimirFila()
        {
            if (!Vazio())
            {
                Numero aux = cabeca;
                do
                {
                    Console.Write(aux.getValor() + " ");
                    aux = aux.getProximo();
                } while (aux != null);
            }
        }
        public int getMaior()
        {
            DefinirMaiorMenorMedia();
            return this.maior;
        }
        public int getMenor()
        {
            DefinirMaiorMenorMedia();
            return this.menor;
        }
        public float getMedia()
        {
            DefinirMaiorMenorMedia();
            return this.media;
        }

        public FilaNumero CopiarFila()
        {

            Numero aux = cabeca;
            FilaNumero novaFila = new FilaNumero();
            do
            {
                novaFila.Push(aux);
                aux = aux.getProximo();
            } while (aux != null);

            return novaFila;
        }

        public void ImprimirPares()
        {
            Numero aux = this.cabeca;
            int qtdPar = 0;
            do
            {
                if (aux.getValor() % 2 == 0)
                {
                    Console.Write(aux.getValor() + " ");
                    qtdPar++;
                }

                aux = aux.getProximo();
            } while (aux != null);
            Console.WriteLine("\nQuantidade de pares: " + qtdPar);
        }

        public void ImprimirImpares()
        {
            Numero aux = this.cabeca;
            int qtdImpar = 0;
            do
            {
                if (aux.getValor() % 2 != 0)
                {
                    Console.Write(aux.getValor() + " ");
                    qtdImpar++;
                }

                aux = aux.getProximo();
            } while (aux != null);
            Console.WriteLine("\nQuantidade de impares: " + qtdImpar);

        }
    }
}
