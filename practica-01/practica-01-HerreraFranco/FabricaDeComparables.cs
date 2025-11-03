namespace practica_01_HerreraFranco
{
    public abstract class FabricaDeComparables
    {
        public const int NUMEROS = 1;
        public const int ALUMNOS = 2;
        public const int PROFESOR = 3;
        public const int ALUMNOS_ESTUDIOSOS = 4;
        public const int ALUMNOS_COMPUESTOS = 5;

        public static FabricaDeComparables crearFabrica(int tipo)
        {
            switch (tipo)
            {
                case NUMEROS:
                    return new FabricaDeNumeros();
                case ALUMNOS:
                    return new FabricaDeAlumnos();
                case PROFESOR:
                    return new FabricaDeProfesor();
                case ALUMNOS_ESTUDIOSOS:
                    return new FabricaDeAlumnosEstudiosos();
                case ALUMNOS_COMPUESTOS:
                    return new FabricaDeAlumnosCompuestos();
                default:
                    return null;
            }
        }

        public abstract IComparable crearAleatorio();

        public abstract IComparable crearPorTeclado();
    }
}
