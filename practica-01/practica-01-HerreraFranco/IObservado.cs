namespace practica_01_HerreraFranco
{
    public interface IObservado
    {
        void agregarObservador(IObservador o);
        void eliminarObservador(IObservador o);
        void notificar();
    }
}
