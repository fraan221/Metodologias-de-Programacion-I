using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_01_HerreraFranco
{
    public class DecoradorAprobacion : AdicionalDecorator
    {
        public DecoradorAprobacion(Student s) : base(s) { }

        public override string showResult()
        {
            int calificacion = this.getAlumnoComponente().getCalificacion();
            string estado = "";

            if (calificacion >= 7)
            {
                estado = "PROMOCION";
            }
            else if (calificacion >= 4)
            {
                estado = "APROBADO";
            }
            else
            {
                estado = "DESAPROBADO";
            }

            return $"{base.showResult()} - {estado}";
        }
    }
}
