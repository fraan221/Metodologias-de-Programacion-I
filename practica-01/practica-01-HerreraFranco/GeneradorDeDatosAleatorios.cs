namespace practica_01_HerreraFranco
{
    public class GeneradorDeDatosAleatorios : Manejador
    {
        private static GeneradorDeDatosAleatorios instancia = null;
        private Random random = new Random();

        private GeneradorDeDatosAleatorios(Manejador s) : base(s)
        {
        }

        public static GeneradorDeDatosAleatorios getInstance(Manejador s)
        {
            if (instancia == null)
            {
                instancia = new GeneradorDeDatosAleatorios(s);
            }
            return instancia;
        }

        public override int numeroAleatorio(int max)
        {
            return random.Next(0, max);
        }

        public override string stringAleatorio(int cant)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            char[] randomString = new char[cant];
            for (int i = 0; i < cant; i++)
            {
                randomString[i] = chars[random.Next(chars.Length)];
            }
            return new string(randomString);
        }
    }
}
