namespace practica_01_HerreraFranco
{
    public class FabricaDeNumeros : FabricaDeComparables
    {
        public FabricaDeNumeros(Manejador m) : base(m)
        {
        }

        public override IComparable crearAleatorio()
        {
            return new Numero(manejador.numeroAleatorio(100));
        }

        public override IComparable crearPorTeclado()
        {
            Console.WriteLine("Ingrese un número:");
            return new Numero(manejador.numeroPorTeclado());
        }

        public override IComparable crearDesdeArchivo()
        {
            Console.WriteLine("Creando Numero desde archivo (usando aleatorio)");
            return this.crearAleatorio();
        }
    }
}
