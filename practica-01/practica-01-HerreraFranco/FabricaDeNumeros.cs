namespace practica_01_HerreraFranco
{
    public class FabricaDeNumeros : FabricaDeComparables
    {
        private GeneradorDeDatosAleatorios generador = new GeneradorDeDatosAleatorios();
        private LectorDeDatos lector = new LectorDeDatos();

        public override IComparable crearAleatorio()
        {
            return new Numero(generador.numeroAleatorio(100));
        }

        public override IComparable crearPorTeclado()
        {
            Console.WriteLine("Ingrese un número:");
            return new Numero(lector.numeroPorTeclado());
        }
    }
}
