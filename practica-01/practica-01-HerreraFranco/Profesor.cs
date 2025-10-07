namespace practica_01_HerreraFranco
{
    public class Profesor : Persona, IObservado
    {
        private int antiguedad;
        private List<IObservador> observadores = new List<IObservador>();
        private string mensajeDePizzarron;

        public Profesor(string n, int d, int a) : base(n, d)
        {
            this.antiguedad = a;
        }

        public int getAntiguedad()
        {
            return this.antiguedad;
        }

        public override bool sosIgual(IComparable c)
        {
            return this.antiguedad == ((Profesor)c).getAntiguedad();
        }

        public override bool sosMenor(IComparable c)
        {
            return this.antiguedad < ((Profesor)c).getAntiguedad();
        }

        public override bool sosMayor(IComparable c)
        {
            return this.antiguedad > ((Profesor)c).getAntiguedad();
        }

        public override string ToString()
        {
            return $"Profesor: {this.nombre} (Antiguedad: {this.antiguedad})";
        }

        public void hablarALaClase()
        {
            Console.WriteLine($"{this.nombre} está hablando a la clase.");
            this.mensajeDePizzarron = "hablando...";
            this.notificar();
        }

        public void escribirEnElPizzarron()
        {
            Console.WriteLine($"{this.nombre} escribe en el pizarrón");
            this.mensajeDePizzarron = "escribiendo...";
            this.notificar();
        }

        public string getMensaje()
        {
            return this.mensajeDePizzarron;
        }

        public void agregarObservador(IObservador o)
        {
            this.observadores.Add(o);
        }

        public void eliminarObservador(IObservador o)
        {
            this.observadores.Remove(o);
        }

        public void notificar()
        {
            foreach (IObservador o in this.observadores)
            {
                o.actualizar(this);
            }
        }
    }
}
