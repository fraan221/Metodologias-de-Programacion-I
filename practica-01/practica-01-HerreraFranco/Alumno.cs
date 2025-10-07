namespace practica_01_HerreraFranco
{
    public class Alumno : Persona, IObservador
    {
        private int legajo;
        private double promedio;
        private IEstrategiaDeComparacion estrategia;

        public Alumno(string n, int d, int l, double p) : base(n, d)
        {
            this.legajo = l;
            this.promedio = p;
            this.estrategia = new EstrategiaPorDNI();
        }

        public int getLegajo()
        {
            return this.legajo;
        }

        public double getPromedio()
        {
            return this.promedio;
        }

        public void setEstrategia(IEstrategiaDeComparacion e)
        {
            this.estrategia = e;
        }

        public override bool sosIgual(IComparable c)
        {
            return this.estrategia.sosIgual(this, (Alumno)c);
        }

        public override bool sosMenor(IComparable c)
        {
            return this.estrategia.sosMenor(this, (Alumno)c);
        }

        public override bool sosMayor(IComparable c)
        {
            return this.estrategia.sosMayor(this, (Alumno)c);
        }

        public override string ToString()
        {
            return $"{this.nombre} (DNI: {this.dni}, Promedio: {this.promedio}, Legajo: {this.legajo})";
        }

        public void prestarAtencion()
        {
            Console.WriteLine($"{this.nombre} está prestando atención.");
        }

        public void distraerse()
        {
            Console.WriteLine($"{this.nombre} se está distrayendo.");
        }

        public void actualizar(IObservado observado)
        {
            string accionDelProfesor = ((Profesor)observado).getMensaje();
            if (accionDelProfesor == "hablando...")
            {
                this.prestarAtencion();
            }
            else if (accionDelProfesor == "escribiendo...")
            {
                this.distraerse();
            }
        }

        public void prestarAtencion(Profesor profesor)
        {
            Console.WriteLine($"{this.nombre} está prestando atención a {profesor.ToString()}.");
        }

        public void distraerse(Profesor profesor)
        {
            Console.WriteLine($"{this.nombre} se está distrayendo mientras {profesor.ToString()} escribe en el pizarrón.");
        }
    }
}
