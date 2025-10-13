using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace practica_01_HerreraFranco
{
    public abstract class AlumnoDecorator : Alumno
    {
        protected Alumno alumno_adicional;

        public AlumnoDecorator(Alumno a) : base(a.getNombre(), a.getDni(), a.getLegajo(), a.getPromedio())
        {
            this.alumno_adicional = a;
        }

        public override int responderPregunta(int pregunta)
        {
            return this.alumno_adicional.responderPregunta(pregunta);
        }

        public override string mostrarCalificacion()
        {
            return this.alumno_adicional.mostrarCalificacion();
        }

        public override bool sosIgual(IComparable c)
        {
            return this.alumno_adicional.sosIgual(c);
        }

        public override bool sosMenor(IComparable c)
        {
            return this.alumno_adicional.sosMenor(c);
        }

        public override bool sosMayor(IComparable c)
        {
            return this.alumno_adicional.sosMayor(c);
        }

        public override int getLegajo()
        {
            return this.alumno_adicional.getLegajo();
        }

        public override double getPromedio()
        {
            return this.alumno_adicional.getPromedio();
        }

        public override int getCalificacion()
        {
            return this.alumno_adicional.getCalificacion();
        }

        public override void setCalificacion(int calif)
        {
            this.alumno_adicional.setCalificacion(calif);
        }
    }
}
