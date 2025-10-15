namespace practica_01_HerreraFranco
{
    public class OrdenLlegaAlumno : OrdenEnAula2
    {
        private Aula aula;

        public OrdenLlegaAlumno(Aula a)
        {
            this.aula = a;
        }

        public void ejecutar(IComparable comparable)
        {
            this.aula.nuevoAlumno((Alumno)comparable);
        }
    }
}
