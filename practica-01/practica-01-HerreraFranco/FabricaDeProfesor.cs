namespace practica_01_HerreraFranco
{
    public class FabricaDeProfesor : FabricaDeComparables
    {
        public FabricaDeProfesor(Manejador m) : base(m)
        {
        }

        public override IComparable crearAleatorio()
        {
            string nombre = manejador.stringAleatorio(10);
            int dni = manejador.numeroAleatorio(50000000);
            int antiguedad = manejador.numeroAleatorio(25);
            return new Profesor(nombre, dni, antiguedad);
        }
        public override IComparable crearPorTeclado()
        {
            Console.Write("Ingrese el nombre del profesor: ");
            string nombre = manejador.stringPorTeclado();
            Console.Write("Ingrese el DNI del profesor: ");
            int dni = manejador.numeroPorTeclado();
            Console.Write("Ingrese la antiguedad del profesor: ");
            int antiguedad = manejador.numeroPorTeclado();
            return new Profesor(nombre, dni, antiguedad);
        }

        public override IComparable crearDesdeArchivo()
        {
            string nombre = manejador.stringDesdeArchivo(20);
            int dni = (int)manejador.numeroDesdeArchivo(50000000);
            int antiguedad = (int)manejador.numeroDesdeArchivo(25);
            return new Profesor(nombre, dni, antiguedad);
        }
    }
}
