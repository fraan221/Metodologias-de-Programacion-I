namespace practica_01_HerreraFranco
{
    public class OrdenAulaLlena : OrdenEnAula1
    {
        private Aula aula;

        public OrdenAulaLlena(Aula a)
        {
            this.aula = a;
        }

        public void ejecutar()
        {
            this.aula.claseLista();
        }
    }
}
