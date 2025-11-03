using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_01_HerreraFranco
{
    public class JuegoDeEscoba : JuegoDeCartas
    {
        protected override void mezclarMazo()
        {
            Console.WriteLine("Mezclando el mazo de 40 cartas españolas...(Escoba)");
        }

        protected override void repartirCartasIniciales()
        {
            Console.WriteLine("Repartiendo 3 cartas a cada jugador y poniendo 4 cartas en la mesa...(Escoba)");
        }

        protected override void jugarMano()
        {
            Console.WriteLine("Se juega una mano de Escoba...");
            Console.WriteLine($"Puntajes: {j1.getNombre()}: {puntajeJ1} - {j2.getNombre()}: {puntajeJ2}");
            this.puntajeJ2 += 2;
        }

        protected override Persona chequearSiHayGanador()
        {
            Console.WriteLine("Chequeando ganador de la Escoba...");
            return (this.puntajeJ1 > this.puntajeJ2) ? this.j1 : this.j2;
        }
    }
}
