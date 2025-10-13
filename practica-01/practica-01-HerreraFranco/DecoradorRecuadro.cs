namespace practica_01_HerreraFranco
{
    public class DecoradorRecuadro : AlumnoDecorator
    {
        public DecoradorRecuadro(Alumno a) : base(a) { }

        public override string mostrarCalificacion()
        {
            string resultadoInterno = base.mostrarCalificacion();
            string linea = new string('*', resultadoInterno.Length + 4);
            return $"{linea}\n* {resultadoInterno} *\n{linea}";
        }
    }
}
