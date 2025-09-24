using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_01_HerreraFranco
{
    public class ColeccionMultiple : IColeccionable
    {
        private Pila pila;
        private Cola cola;

        public ColeccionMultiple(Pila p, Cola c)
        {
            this.pila = p;
            this.cola = c;
        }

        public void agregar(IComparable c)
        {
        }

        public bool contiene(IComparable c)
        {
            return this.pila.contiene(c) || this.cola.contiene(c);
        }

        public int cuantos()
        {
            return this.pila.cuantos() + this.cola.cuantos();
        }

        public IComparable maximo()
        {
            if (this.pila.maximo().sosMayor(this.cola.maximo()))
            {
                return this.pila.maximo();
            }
            else
            {
                return this.cola.maximo();
            }
        }

        public IComparable minimo()
        {
            if (this.pila.minimo().sosMenor(this.cola.minimo()))
            {
                return this.pila.minimo();
            }
            else
            {
                return this.cola.minimo();
            }
        }
    }
}
