using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_01_HerreraFranco
{
    public abstract class AdicionalDecorator : Student
    {
        protected Student adicional;

        public AdicionalDecorator(Student s)
        {
            this.adicional = s;
        }

        public Student getAdicional()
        {
            return this.adicional;
        }

        protected Alumno getAlumnoComponente()
        {
            Student studentComponent = this.adicional;
            while (studentComponent is AdicionalDecorator)
            {
                studentComponent = ((AdicionalDecorator)studentComponent).getAdicional();
            }
            return ((AlumnoAdapter)studentComponent).getAlumno();
        }

        public virtual string getName()
        {
            return adicional.getName();
        }

        public virtual int yourAnswerIs(int question)
        {
            return adicional.yourAnswerIs(question);
        }

        public virtual void setScore(int score)
        {
            adicional.setScore(score);
        }

        public virtual string showResult()
        {
            return adicional.showResult();
        }

        public virtual bool equals(Student student)
        {
            return adicional.equals(student);
        }

        public virtual bool lessThan(Student student)
        {
            return adicional.lessThan(student);
        }

        public virtual bool greaterThan(Student student)
        {
            return adicional.greaterThan(student);
        }
    }
}
