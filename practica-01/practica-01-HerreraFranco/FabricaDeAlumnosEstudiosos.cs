using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_01_HerreraFranco
{
    public class FabricaDeAlumnosEstudiosos : FabricaDeComparables
    {
        public FabricaDeAlumnosEstudiosos(Manejador m) : base(m)
        {
        }

        public override IComparable crearAleatorio()
        {
            return new AlumnoMuyEstudioso("Estudioso " + manejador.stringAleatorio(4), manejador.numeroAleatorio(50000000), manejador.numeroAleatorio(20000), 10);
        }

        public override IComparable crearPorTeclado()
        {
            return this.crearAleatorio();
        }

        public override IComparable crearDesdeArchivo()
        {
            string nombre = manejador.stringDesdeArchivo(20);
            int dni = (int)manejador.numeroDesdeArchivo(50000000);
            int legajo = (int)manejador.numeroDesdeArchivo(20000);
            double promedio = manejador.numeroDesdeArchivo(10);
            return new AlumnoMuyEstudioso(nombre, dni, legajo, promedio);
        }
    }
}
