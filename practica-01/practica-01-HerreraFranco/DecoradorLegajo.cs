using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_01_HerreraFranco
{
    public class DecoradorLegajo : AdicionalDecorator
    {
        public DecoradorLegajo(Student s) : base(s) { }

        public override string showResult()
        {
            Alumno alumno = this.getAlumnoComponente();
            return $"{alumno.getNombre()} ({alumno.getLegajo()}) {alumno.getCalificacion()}";
        }
    }
}
