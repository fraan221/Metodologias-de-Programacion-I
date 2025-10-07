namespace practica_01_HerreraFranco
{
    public class FabricaDeProfesor : FabricaDeComparables
    {
        private GeneradorDeDatosAleatorios generador = new GeneradorDeDatosAleatorios();
        private LectorDeDatos lector = new LectorDeDatos();
        public override IComparable crearAleatorio()
        {
            string nombre = generador.stringAleatorio(10);
            int dni = generador.numeroAleatorio(50000000);
            int antiguedad = generador.numeroAleatorio(25);
            return new Profesor(nombre, dni, antiguedad);
        }
        public override IComparable crearPorTeclado()
        {
            Console.Write("Ingrese el nombre del profesor: ");
            string nombre = lector.stringPorTeclado();
            Console.Write("Ingrese el DNI del profesor: ");
            int dni = lector.numeroPorTeclado();
            Console.Write("Ingrese la antiguedad del profesor: ");
            int antiguedad = lector.numeroPorTeclado();
            return new Profesor(nombre, dni, antiguedad);
        }
    }
}
