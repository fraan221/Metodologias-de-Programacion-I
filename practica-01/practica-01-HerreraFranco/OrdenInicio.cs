namespace practica_01_HerreraFranco
{
    public class OrdenInicio : OrdenEnAula1
    {
        private Aula aula;

        public OrdenInicio(Aula a)
        {
            this.aula = a;
        }

        public void ejecutar()
        {
            this.aula.comenzar();
        }
    }
}
