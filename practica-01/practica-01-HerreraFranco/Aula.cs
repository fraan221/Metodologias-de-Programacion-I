namespace practica_01_HerreraFranco
{
    public class Aula
    {
        private Teacher teacher;

        public void comenzar()
        {
            Console.WriteLine("El aula inicia la clase.");
            this.teacher = new Teacher();
        }

        public void nuevoAlumno(Alumno alumno)
        {
            if (this.teacher != null)
            {
                Student studentAdaptado = new AlumnoAdapter(alumno);
                this.teacher.goToClass(studentAdaptado);
            }
        }

        public void claseLista()
        {
            if (this.teacher != null)
            {
                this.teacher.teachingAClass();
            }
        }
    }
}
