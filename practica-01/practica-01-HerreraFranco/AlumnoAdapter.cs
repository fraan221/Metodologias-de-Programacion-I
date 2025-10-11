using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_01_HerreraFranco
{
    public class AlumnoAdapter : Student
    {
        private Alumno alumno;

        public AlumnoAdapter(Alumno a)
        {
            this.alumno = a;
        }

        public Alumno getAlumno()
        {
            return this.alumno;
        }

        public string getName()
        {
            return this.alumno.getNombre();
        }

        public int yourAnswerIs(int question)
        {
            return this.alumno.responderPregunta(question);
        }

        public void setScore(int score)
        {
            this.alumno.setCalificacion(score);
        }

        public string showResult()
        {
            return this.alumno.mostrarCalificacion();
        }

        private Alumno getAlumnoDesdeStudent(Student student)
        {
            Student studentComponent = student;

            while(studentComponent is AdicionalDecorator)
            {
                studentComponent = ((AdicionalDecorator)studentComponent).getAdicional();
            }
            return ((AlumnoAdapter)studentComponent).getAlumno();
        }

        public bool equals(Student student)
        {
            return this.alumno.sosIgual(this.getAlumnoDesdeStudent(student));
        }

        public bool lessThan(Student student)
        {
            return this.alumno.sosMenor(this.getAlumnoDesdeStudent(student));
        }

        public bool greaterThan(Student student)
        {
            return this.alumno.sosMayor(this.getAlumnoDesdeStudent(student));
        }
    }
}
