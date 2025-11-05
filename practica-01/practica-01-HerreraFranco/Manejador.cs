using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_01_HerreraFranco
{
    public abstract class Manejador
    {
        protected Manejador sucesor;

        public Manejador(Manejador s)
        {
            this.sucesor = s;
        }

        public virtual int numeroAleatorio(int max)
        {
            if (this.sucesor != null)
            {
                return this.sucesor.numeroAleatorio(max);
            }
            return 0;
        }

        public virtual string stringAleatorio(int cant)
        {
            if (this.sucesor != null)
            {
                return this.sucesor.stringAleatorio(cant);
            }
            return "";
        }

        public virtual int numeroPorTeclado()
        {
            if (this.sucesor != null)
            {
                return this.sucesor.numeroPorTeclado();
            }
            return 0;
        }

        public virtual string stringPorTeclado()
        {
            if (this.sucesor != null)
            {
                return this.sucesor.stringPorTeclado();
            }
            return "";
        }

        // Ejercicio 3

        public virtual double numeroDesdeArchivo(double max)
        {
            if (this.sucesor != null)
            {
                return this.sucesor.numeroDesdeArchivo(max);
            }
            return 0;
        }

        public virtual string stringDesdeArchivo(int cant)
        {
            if (this.sucesor != null)
            {
                return this.sucesor.stringDesdeArchivo(cant);
            }
            return "";
        }
    }
}
