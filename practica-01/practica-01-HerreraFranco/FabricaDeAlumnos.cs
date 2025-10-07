namespace practica_01_HerreraFranco
{
    public class FabricaDeAlumnos : FabricaDeComparables
    {
        private GeneradorDeDatosAleatorios generador = new GeneradorDeDatosAleatorios();
        private LectorDeDatos lector = new LectorDeDatos();

        public override IComparable crearAleatorio()
        {
            string nombre = generador.stringAleatorio(10);
            int dni = generador.numeroAleatorio(50000000);
            int legajo = generador.numeroAleatorio(10000);
            double promedio = generador.numeroAleatorio(10);
            return new Alumno(nombre, dni, legajo, promedio);
        }

        public override IComparable crearPorTeclado()
        {
            Console.Write("Ingrese el nombre del alumno: ");
            string nombre = lector.stringPorTeclado();
            Console.Write("Ingrese el DNI del alumno: ");
            int dni = lector.numeroPorTeclado();
            Console.Write("Ingrese el legajo del alumno: ");
            int legajo = lector.numeroPorTeclado();
            Console.Write("Ingrese el promedio del alumno: ");
            double promedio = lector.numeroPorTeclado();
            return new Alumno(nombre, dni, legajo, promedio);
        }
    }
}
