using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_01_HerreraFranco
{
    public class JuegoDeGuerra : JuegoDeCartas
    {
        protected override void mezclarMazo()
        {
            Console.WriteLine("Mezclando el mazo de 40 cartas españolas...(Guerra)");
        }

        protected override void repartirCartasIniciales()
        {
            Console.WriteLine("Repartiendo 20 cartas a cada jugador...(Guerra)");
        }

        protected override void jugarMano()
        {
            Console.WriteLine("Se juega una mano de Guerra: los jugadores tiran una carta, el que tiene la mas alta gana.");
            Console.WriteLine($"Puntajes: {j1.getNombre()}: {puntajeJ1} - {j2.getNombre()}: {puntajeJ2}");
            this.puntajeJ1++;
        }

        protected override Persona chequearSiHayGanador()
        {
            Console.WriteLine("Chequeando ganador de la Guerra...");
            return (this.puntajeJ1 > this.puntajeJ2) ? this.j1 : this.j2;
        }
    }
}
