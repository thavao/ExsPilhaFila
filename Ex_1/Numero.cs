using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_1
{
    internal class Numero
    {
        int valor;
        Numero anterior;

        public Numero(int num)
        {
            valor = num;
            anterior = null;
        }
        public void setAnterior(Numero recebido)
        {
            anterior = recebido;
        }
        public Numero getAnterior()
        {
            return anterior;
        }
        public int getNumero()
        {
            return valor;
        }

    }
}
