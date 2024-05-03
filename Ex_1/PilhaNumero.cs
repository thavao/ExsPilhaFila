using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_1
{
    internal class PilhaNumero
    {
        Numero topo;
        int tamanho;
        int maior;
        int menor;
        float media;

        public PilhaNumero()
        {
            topo = null;
            tamanho = 0;
        }

        bool Vazio()
        {
            if (topo == null)
                return true;

            return false;
        }

        public void Push(Numero aux)
        {
            if (!Vazio())
            {
                aux.setAnterior(topo);
                topo = aux;
                tamanho++;
            }
            else
            {
                topo = aux;
                tamanho++;
            }
        }
        public void Pop()
        {
            if (!Vazio())
            {
                topo = topo.getAnterior();
                tamanho--;
            }

        }

        public void ImprimirPilha()
        {
            if (!Vazio())
            {
                Numero aux = topo;
                do
                {
                    Console.WriteLine(aux.getNumero());
                    aux = aux.getAnterior();
                } while (aux != null);
            }
        }
        public void Percorrer()
        {
            int maior = topo.getNumero(), menor = topo.getNumero(), soma = 0;

            if (!Vazio())
            {
                Numero aux = topo;
                do
                {
                    int numero = aux.getNumero();
                    if (numero < menor)
                    {
                        menor = numero;
                    }
                    else if (numero > maior)
                    {
                        maior = numero;
                    }
                    soma += numero;
                    aux = aux.getAnterior();
                } while (aux != null);

                this.media = (float)soma / (float)tamanho;
                this.menor = menor;
                this.maior = maior;


            }
        }

        public int getTamanho()
        {
            return tamanho;
        }
        public int getMenor()
        {
            Percorrer();
            return menor;
        }
        public int getMaior()
        {
            Percorrer();
            return maior;
        }

        public float getMedia()
        {
            Percorrer();
            return media;
        }
        public PilhaNumero InverterPilha()
        {
            PilhaNumero novaPilha = new PilhaNumero();

            if (!Vazio())
            {
                Numero aux = topo;
                do
                {
                    novaPilha.Push(new(aux.getNumero()));
                    aux = aux.getAnterior();
                } while (aux != null);


            }
            return novaPilha;
        }

        public void ImprimirPares()
        {
            Numero aux = this.topo;
            int qtdPar = 0;
            do
            {
                if (aux.getNumero() % 2 == 0)
                {
                    Console.Write(aux.getNumero() + " ");
                    qtdPar++;
                }

                aux = aux.getAnterior();
            } while (aux != null);
            Console.WriteLine("\nQuantidade de pares: " + qtdPar);
        }
    }
}
