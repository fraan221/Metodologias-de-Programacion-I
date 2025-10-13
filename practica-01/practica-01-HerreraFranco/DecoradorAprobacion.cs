namespace practica_01_HerreraFranco
{
    public class DecoradorAprobacion : AlumnoDecorator
    {
        public DecoradorAprobacion(Alumno a) : base(a) { }

        public override string mostrarCalificacion()
        {
            int calificacion = this.alumno_adicional.getCalificacion();
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

            return $"{base.mostrarCalificacion()} - {estado}";
        }
    }
}
