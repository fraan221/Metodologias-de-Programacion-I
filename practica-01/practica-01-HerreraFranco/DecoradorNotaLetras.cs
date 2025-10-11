using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_01_HerreraFranco
{
    public class DecoradorNotaLetras : AdicionalDecorator
    {
        public DecoradorNotaLetras(Student s) : base(s) { }

        private string calificacionEnLetras(int calificacion)
        {
            switch (calificacion)
            {
                case 0: return "CERO";
                case 1: return "UNO";
                case 2: return "DOS";
                case 3: return "TRES";
                case 4: return "CUATRO";
                case 5: return "CINCO";
                case 6: return "SEIS";
                case 7: return "SIETE";
                case 8: return "OCHO";
                case 9: return "NUEVE";
                case 10: return "DIEZ";
                default: return "";
            }
        }

        public override string showResult()
        {
            int calificacion = this.getAlumnoComponente().getCalificacion();
            return $"{base.showResult()} ({calificacionEnLetras(calificacion)})";
        }
    }
}
