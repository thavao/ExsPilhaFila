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
        int maior;
        int menor;
        float media;

        public FilaNumero()
        {
            cabeca = null;
            cauda = null;
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
            }
            else
            {
                cauda.setProximo(aux);
                cauda = aux;
            }
        }
        public void Pop()
        {
            if (!Vazio())
            {
                cabeca = cabeca.getProximo();
            }
        }
    }
}
