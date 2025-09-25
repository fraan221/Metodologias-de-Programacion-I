using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_01_HerreraFranco
{
    public class EstrategiaPorPromedio : IEstrategiaDeComparacion
    {
        public bool sosIgual(Alumno a1, Alumno a2)
        {
            return a1.getPromedio() == a2.getPromedio();
        }

        public bool sosMenor(Alumno a1, Alumno a2)
        {
            return a1.getPromedio() < a2.getPromedio();
        }

        public bool sosMayor(Alumno a1, Alumno a2)
        {
            return a1.getPromedio() > a2.getPromedio();
        }
    }
}
