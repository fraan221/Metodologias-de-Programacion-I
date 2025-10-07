namespace practica_01_HerreraFranco
{
    public class GeneradorDeDatosAleatorios
    {
        private Random random = new Random();

        public int numeroAleatorio(int max)
        {
            return random.Next(0, max);
        }

        public string stringAleatorio(int cant)
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
