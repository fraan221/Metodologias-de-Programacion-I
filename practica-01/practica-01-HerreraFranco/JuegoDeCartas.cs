using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_01_HerreraFranco
{
    public abstract class JuegoDeCartas
    {
        protected Persona j1;
        protected Persona j2;
        protected int puntajeJ1;
        protected int puntajeJ2;
        protected const int PUNTAJE_VICTORIA = 5;

        public Persona jugar(Persona jugador1, Persona jugador2)
        {
            this.j1 = jugador1;
            this.j2 = jugador2;

            this.mezclarMazo();
            this.repartirCartasIniciales();
            while (this.puntajeJ1 < PUNTAJE_VICTORIA && this.puntajeJ2 < PUNTAJE_VICTORIA)
            {
                this.jugarMano();
            }
            Persona ganador = this.chequearSiHayGanador();
            return ganador;
        }

        protected abstract void mezclarMazo();
        protected abstract void repartirCartasIniciales();
        protected abstract void jugarMano();
        protected abstract Persona chequearSiHayGanador();
    }
}
