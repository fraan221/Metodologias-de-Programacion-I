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
        private IEstrategiaDeComparacion estrategia;

        public Alumno(string n, int d, int l, double p) : base(n, d)
        {
            this.legajo = l;
            this.promedio = p;
            this.estrategia = new EstrategiaPorDNI();
        }

        public int getLegajo()
        {
            return this.legajo;
        }

        public double getPromedio()
        {
            return this.promedio;
        }

        public void setEstrategia(IEstrategiaDeComparacion e)
        {
            this.estrategia = e;
        }

        public override bool sosIgual(IComparable c)
        {
            return this.estrategia.sosIgual(this, (Alumno)c);
        }

        public override bool sosMenor(IComparable c)
        {
            return this.estrategia.sosMenor(this, (Alumno)c);
        }

        public override bool sosMayor(IComparable c)
        {
            return this.estrategia.sosMayor(this, (Alumno)c);
        }

        public override string ToString()
        {
            return $"{this.nombre} (DNI: {this.dni}, Promedio: {this.promedio}, Legajo: {this.legajo})";
        }
    }
}
