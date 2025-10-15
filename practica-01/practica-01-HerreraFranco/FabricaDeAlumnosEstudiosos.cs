using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_01_HerreraFranco
{
    public class FabricaDeAlumnosEstudiosos : FabricaDeComparables
    {
        private GeneradorDeDatosAleatorios generador = new GeneradorDeDatosAleatorios();

        public override IComparable crearAleatorio()
        {
            return new AlumnoMuyEstudioso("Estudioso " + generador.stringAleatorio(4), generador.numeroAleatorio(50000000), generador.numeroAleatorio(20000), 10);
        }

        public override IComparable crearPorTeclado()
        {
            return this.crearAleatorio();
        }
    }
}
