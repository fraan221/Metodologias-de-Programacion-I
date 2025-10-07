namespace practica_01_HerreraFranco
{
    public class LectorDeDatos
    {
        public int numeroPorTeclado()
        {
            return int.Parse(Console.ReadLine());
        }

        public string stringPorTeclado()
        {
            return Console.ReadLine();
        }
    }
}
