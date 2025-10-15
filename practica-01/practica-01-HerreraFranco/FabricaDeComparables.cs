namespace practica_01_HerreraFranco
{
    public abstract class FabricaDeComparables
    {
        public const int NUMEROS = 1;
        public const int ALUMNOS = 2;
        public const int PROFESOR = 3;
        public const int ALUMNOS_ESTUDIOSOS = 4;

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
                default:
                    return null;
            }
        }

        public abstract IComparable crearAleatorio();

        public abstract IComparable crearPorTeclado();
    }
}
