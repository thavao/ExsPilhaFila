using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_2
{
    internal class Numero
    {
        int valor;
        Numero proximo;

        public Numero(int num)
        {
            valor = num;
            proximo = null;
        }
        public void setProximo(Numero recebido)
        {
            proximo = recebido;
        }
        public Numero getProximo()
        {
            return proximo;
        }
        public int getValor()
        {
            return valor;
        }
    }
}
