using System;
using System.Collections.Generic;

namespace practica_01_HerreraFranco
{
    public class Pila : IColeccionable, IIterable, Ordenable
    {
        private List<IComparable> elementos;
        private OrdenEnAula1 ordenInicio;
        private OrdenEnAula2 ordenLlegaAlumno;
        private OrdenEnAula1 ordenAulaLlena;

        public Pila()
        { 
            this.elementos = new List<IComparable>();
            this.ordenInicio = null;
            this.ordenLlegaAlumno = null;
            this.ordenAulaLlena = null;
        }

        public void setOrdenInicio(OrdenEnAula1 orden)
        {
            this.ordenInicio = orden;
        }

        public void setOrdenLlegaAlumno(OrdenEnAula2 orden)
        {
            this.ordenLlegaAlumno = orden;
        }

        public void setOrdenAulaLlena(OrdenEnAula1 orden)
        {
            this.ordenAulaLlena = orden;
        }

        public void agregar(IComparable c)
        {
            if (this.cuantos() == 0 && this.ordenInicio != null)
            {
                this.ordenInicio.ejecutar();
            }

            this.elementos.Add(c);

            if (this.ordenLlegaAlumno != null)
            {
                this.ordenLlegaAlumno.ejecutar(c);
            }

            if (this.cuantos() == 40 && this.ordenAulaLlena != null)
            {
                this.ordenAulaLlena.ejecutar();
            }
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

        public IIterador crearIterador()
        {
            return new IteradorDePila(this.elementos);
        }

        private class IteradorDePila : IIterador
        {
            private List<IComparable> elementos;
            private int indice;

            public IteradorDePila(List<IComparable> elementos)
            {
                this.elementos = elementos;
                this.primero();
            }

            public void primero()
            {
                this.indice = 0; // Reiniciar al tope de la pila
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
