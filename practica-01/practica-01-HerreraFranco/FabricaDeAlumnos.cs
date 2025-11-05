namespace practica_01_HerreraFranco
{
    public class FabricaDeAlumnos : FabricaDeComparables
    {
        public FabricaDeAlumnos(Manejador m) : base(m)
        {
        }

        public override IComparable crearAleatorio()
        {
            string nombre = manejador.stringAleatorio(10);
            int dni = manejador.numeroAleatorio(50000000);
            int legajo = manejador.numeroAleatorio(10000);
            double promedio = manejador.numeroAleatorio(10);
            return new Alumno(nombre, dni, legajo, promedio);
        }

        public override IComparable crearPorTeclado()
        {
            Console.Write("Ingrese el nombre del alumno: ");
            string nombre = manejador.stringPorTeclado();
            Console.Write("Ingrese el DNI del alumno: ");
            int dni = manejador.numeroPorTeclado();
            Console.Write("Ingrese el legajo del alumno: ");
            int legajo = manejador.numeroPorTeclado();
            Console.Write("Ingrese el promedio del alumno: ");
            double promedio = manejador.numeroPorTeclado();
            return new Alumno(nombre, dni, legajo, promedio);
        }

        public override IComparable crearDesdeArchivo()
        {
            string nombre = manejador.stringDesdeArchivo(20);
            int dni = (int)manejador.numeroDesdeArchivo(50000000);
            int legajo = (int)manejador.numeroDesdeArchivo(10000);
            double promedio = manejador.numeroDesdeArchivo(10);
            return new Alumno(nombre, dni, legajo, promedio);
        }
    }
}
