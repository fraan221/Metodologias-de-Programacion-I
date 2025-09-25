using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_01_HerreraFranco
{
    public class EstrategiaPorNombre : IEstrategiaDeComparacion
    {
        public bool sosIgual(Alumno a1, Alumno a2)
        {
            return a1.getNombre().CompareTo(a2.getNombre()) == 0;
        }

        public bool sosMenor(Alumno a1, Alumno a2)
        {
            return a1.getNombre().CompareTo(a2.getNombre()) < 0;
        }

        public bool sosMayor(Alumno a1, Alumno a2)
        {
            return a1.getNombre().CompareTo(a2.getNombre()) > 0;
        }
    }
}
