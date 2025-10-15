namespace practica_01_HerreraFranco
{
    public class AlumnoProxy : Alumno
    {
        private Alumno alumnoReal = null;
        private string nombre;
        private int dni;
        private int legajo;
        private double promedio;
        private bool esEstudioso;

        public AlumnoProxy(string n, int d, int l, double p, bool estudioso) : base(n, d, l, p)
        {
            this.nombre = n;
            this.dni = d;
            this.legajo = l;
            this.promedio = p;
            this.esEstudioso = estudioso;
        }

        public override int responderPregunta(int pregunta)
        {
            if (this.alumnoReal == null)
            {
                Console.WriteLine($"Creando Alumno real para: {this.nombre}");

                if (this.esEstudioso)
                {
                    this.alumnoReal = new AlumnoMuyEstudioso(this.nombre, this.dni, this.legajo, this.promedio);
                }
                else
                {
                    this.alumnoReal = new Alumno(this.nombre, this.dni, this.legajo, this.promedio);
                }
            }
            return this.alumnoReal.responderPregunta(pregunta);
        }

        public override string mostrarCalificacion()
        {
            if (this.alumnoReal != null)
            {
                return this.alumnoReal.mostrarCalificacion();
            }
            return $"{this.nombre} (Calificacion pendiente)";
        }

        public override void setCalificacion(int calif)
        {
            if (this.alumnoReal != null)
            {
                this.alumnoReal.setCalificacion(calif);
            }
        }

        public override string getNombre()
        {
            return this.nombre;
        }

        public override int getDni()
        {
            return this.dni;
        }

        public override int getLegajo()
        {
            return this.legajo;
        }

        public override double getPromedio()
        {
            return this.promedio;
        }

        public override bool sosIgual(IComparable c)
        {
            if (this.alumnoReal != null)
            {
                return this.alumnoReal.sosIgual(c);
            }
            return false;
        }
    }
}
