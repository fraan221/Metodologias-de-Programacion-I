using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_01_HerreraFranco
{
    public class Conjunto : IColeccionable, IIterable
    {
        private List<IComparable> elementos;

        public Conjunto()
        {
            this.elementos = new List<IComparable>();
        }

        public void agregar(IComparable c)
        {
            if (!this.contiene(c))
            {
                this.elementos.Add(c);
            }
        }

        public bool contiene(IComparable c)
        {
            foreach (IComparable elemento in this.elementos)
            {
                if (elemento.sosIgual(c))
                {
                    return true;
                }
            }
            return false;
        }

        public int cuantos()
        {
            return this.elementos.Count;
        }

        public IComparable minimo()
        {
            if (this.elementos.Count == 0)
            {
                return null;
            }

            IComparable min = this.elementos[0];
            foreach (IComparable elem in this.elementos)
            {
                if (elem.sosMenor(min))
                {
                    min = elem;
                }
            }
            return min;
        }

        public IComparable maximo()
        {
            if (this.elementos.Count == 0)
            {
                return null;
            }
            IComparable max = this.elementos[0];
            foreach (IComparable elem in this.elementos)
            {
                if (elem.sosMayor(max))
                {
                    max = elem;
                }
            }
            return max;
        }

        public IIterador crearIterador()
        {
            return new IteradorDeConjunto(this.elementos);
        }

        private class IteradorDeConjunto : IIterador
        {
            private List<IComparable> elementos;
            private int indice;

            public IteradorDeConjunto(List<IComparable> elementos)
            {
                this.elementos = elementos;
                this.primero();
            }

            public void primero()
            {
                this.indice = 0;
            }

            public void siguiente()
            {
                this.indice++;
            }

            public bool fin()
            {
                return this.indice >= this.elementos.Count;
            }

            public IComparable actual()
            {
                if (this.fin())
                {
                    throw new InvalidOperationException("El iterador ha llegado al final de la colección.");
                }
                return this.elementos[this.indice];
            }
        }
    }
}
