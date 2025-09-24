using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_01_HerreraFranco
{
    public class Numero : IComparable
    {
        private int valor;

        public Numero(int v)
        {
            this.valor = v;
        }

        public int getValor()
        {
            return this.valor;
        }

        public bool sosIgual(IComparable c)
        {
            return this.valor == ((Numero)c).getValor();
        }

        public bool sosMenor(IComparable c)
        {
            return this.valor < ((Numero)c).getValor();
        }

        public bool sosMayor(IComparable c)
        {
            return this.valor > ((Numero)c).getValor();
        }
    }
}
