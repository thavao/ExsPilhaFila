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

        public void Percorrer()
        {
            if (!Vazio())
            {
                Numero aux = topo;
                do
                {
                    aux = aux.getAnterior();
                } while (aux != null);
            }
        }

        public int getTamanho()
        {
            return tamanho;
        }
    }
}
