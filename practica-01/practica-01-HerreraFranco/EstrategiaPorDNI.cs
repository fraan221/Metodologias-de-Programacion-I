using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_01_HerreraFranco
{
    public class EstrategiaPorDNI : IEstrategiaDeComparacion
    {
        public bool sosIgual(Alumno a1, Alumno a2)
        {
            return a1.getDni() == a2.getDni();
        }

        public bool sosMenor(Alumno a1, Alumno a2)
        {
            return a1.getDni() < a2.getDni();
        }

        public bool sosMayor(Alumno a1, Alumno a2)
        {
            return a1.getDni() > a2.getDni();
        }
    }
}
