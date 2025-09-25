using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_01_HerreraFranco
{
    public interface IEstrategiaDeComparacion
    {
        bool sosIgual(Alumno a1, Alumno a2);
        bool sosMenor(Alumno a1, Alumno a2);
        bool sosMayor(Alumno a1, Alumno a2);
    }
}
