namespace practica_01_HerreraFranco
{
    public abstract class FabricaDeComparables
    {
        protected Manejador manejador;

        public FabricaDeComparables(Manejador m)
        {
            this.manejador = m;
        }

        public const int NUMEROS = 1;
        public const int ALUMNOS = 2;
        public const int PROFESOR = 3;
        public const int ALUMNOS_ESTUDIOSOS = 4;
        public const int ALUMNOS_COMPUESTOS = 5;

        public static FabricaDeComparables crearFabrica(int tipo)
        {
            Manejador lArchivos = LectorDeArchivos.getInstance(null);
            Manejador lDatos = new LectorDeDatos(lArchivos);
            Manejador cadena = GeneradorDeDatosAleatorios.getInstance(lDatos);

            switch (tipo)
            {
                case NUMEROS:
                    return new FabricaDeNumeros(cadena);
                case ALUMNOS:
                    return new FabricaDeAlumnos(cadena);
                case PROFESOR:
                    return new FabricaDeProfesor(cadena);
                case ALUMNOS_ESTUDIOSOS:
                    return new FabricaDeAlumnosEstudiosos(cadena);
                case ALUMNOS_COMPUESTOS:
                    return new FabricaDeAlumnosCompuestos(cadena);
                default:
                    return null;
            }
        }

        public abstract IComparable crearAleatorio();

        public abstract IComparable crearPorTeclado();

        public abstract IComparable crearDesdeArchivo();
    }
}
