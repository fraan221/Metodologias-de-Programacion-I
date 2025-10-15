namespace practica_01_HerreraFranco
{
    public abstract class FabricaDeComparables
    {
        public const int NUMEROS = 1;
        public const int ALUMNOS = 2;
        public const int PROFESORES = 3;

        public static FabricaDeComparables crearFabrica(int opcion)
        {
            switch(opcion)
            {
                case NUMEROS:
                    return new FabricaDeNumeros();
                case ALUMNOS:
                    return new FabricaDeAlumnos();
                case PROFESORES:
                    return new FabricaDeProfesor();
                default:
                    return null;
            }
        }
        public abstract IComparable crearAleatorio();

        public abstract IComparable crearPorTeclado();
    }
}
