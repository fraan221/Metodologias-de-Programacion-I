using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_01_HerreraFranco
{
    public class Pila : IColeccionable
    {
        private List<IComparable> elementos;

        public Pila()
        { 
            this.elementos = new List<IComparable>();
        }

        public void agregar(IComparable c)
        {
            this.elementos.Add(c);
        }

        public bool contiene(IComparable c)
        {
            foreach(IComparable elem in this.elementos)
            {
                if (elem.sosIgual(c))
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

        public IComparable maximo()
        {
            if (this.elementos.Count == 0)
            {
                throw new InvalidOperationException("La colección está vacía.");
            }

            IComparable max = this.elementos[0];
            foreach (IComparable elem in this.elementos)
            {
                if(elem.sosMayor(max))
                {
                    max = elem;
                }
            }
            return max;
        }

        public IComparable minimo()
        {
            if (this.elementos.Count == 0)
            {
                throw new InvalidOperationException("La colección está vacía.");
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
    }
}
