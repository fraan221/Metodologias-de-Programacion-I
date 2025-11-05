namespace practica_01_HerreraFranco
{
    public class LectorDeDatos : Manejador
    {
        public LectorDeDatos(Manejador s) : base(s)
        {
        }

        public override int numeroPorTeclado()
        {
            return int.Parse(Console.ReadLine());
        }

        public override string stringPorTeclado()
        {
            return Console.ReadLine();
        }
    }
}
