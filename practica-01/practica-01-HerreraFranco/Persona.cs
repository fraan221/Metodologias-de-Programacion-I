using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_01_HerreraFranco
{
    public abstract class Persona : IComparable
    {
        protected string nombre;
        protected int dni;

        public Persona(string n, int d)
        {
            this.nombre = n;
            this.dni = d;
        }

        public string getNombre()
        {
            return this.nombre;
        }

        public int getDni()
        {
            return this.dni;
        }

        public virtual bool sosIgual(IComparable c)
        {
            return this.dni == ((Persona)c).getDni();
        }

        public virtual bool sosMenor(IComparable c)
        {
            return this.dni < ((Persona)c).getDni();
        }

        public virtual bool sosMayor(IComparable c)
        {
            return this.dni > ((Persona)c).getDni();
        }

        public override string ToString()
        {
            return $"{this.nombre}, DNI: {this.dni}";
        }
    }
}
