using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_01_HerreraFranco
{
    public class FabricaDeAlumnosCompuestos : FabricaDeComparables
    {
        private GeneradorDeDatosAleatorios generador = new GeneradorDeDatosAleatorios();

        public override IComparable crearAleatorio()
        {
            AlumnoCompuesto compuesto = new AlumnoCompuesto("Grupo Compuesto", 99999999, 50000, 8.0);
            
            for (int i = 0; i < 5; i++)
            {
                AlumnoProxy proxyHijo = new AlumnoProxy(generador.stringAleatorio(6), generador.numeroAleatorio(50000000), generador.numeroAleatorio(10000), generador.numeroAleatorio(10), false);
                compuesto.agregarHijo(proxyHijo);
            }

            return compuesto;
        }

        public override IComparable crearPorTeclado()
        {
            return this.crearAleatorio();
        }
    }
}
