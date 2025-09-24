using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_01_HerreraFranco
{
    public class Alumno : Persona
    {
        private int legajo;
        private double promedio;

        public Alumno(string n, int d, int l, double p) : base(n, d)
        {
            this.legajo = l;
            this.promedio = p;
        }

        public int getLegajo()
        {
            return this.legajo;
        }

        public double getPromedio()
        {
            return this.promedio;
        }

        public override bool sosIgual(IComparable c)
        {
            return this.promedio == ((Alumno)c).getPromedio();
        }

        public override bool sosMenor(IComparable c)
        {
            return this.promedio < ((Alumno)c).getPromedio();
        }

        public override bool sosMayor(IComparable c)
        {
            return this.promedio > ((Alumno)c).getPromedio();
        }

        public override string ToString()
        {
            return $"{this.nombre} (Promedio: {this.promedio})";
        }
    }
}
