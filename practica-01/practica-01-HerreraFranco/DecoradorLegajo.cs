namespace practica_01_HerreraFranco
{
    public class DecoradorLegajo : AlumnoDecorator
    {
        public DecoradorLegajo(Alumno a) : base(a) { }

        public override string mostrarCalificacion()
        {
            return $"{base.mostrarCalificacion()} ({this.alumno_adicional.getLegajo()})";
        }
    }
}
