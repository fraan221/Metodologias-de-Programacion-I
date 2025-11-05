using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_01_HerreraFranco
{
    public class FabricaDeAlumnosCompuestos : FabricaDeComparables
    {
        public FabricaDeAlumnosCompuestos(Manejador m) : base(m)
        {
        }

        public override IComparable crearAleatorio()
        {
            AlumnoCompuesto compuesto = new AlumnoCompuesto("Grupo Compuesto", 99999999, 50000, 8.0);
            
            for (int i = 0; i < 5; i++)
            {
                AlumnoProxy proxyHijo = new AlumnoProxy(manejador.stringAleatorio(6), manejador.numeroAleatorio(50000000), manejador.numeroAleatorio(10000), manejador.numeroAleatorio(10), false);
                compuesto.agregarHijo(proxyHijo);
            }

            return compuesto;
        }

        public override IComparable crearPorTeclado()
        {
            return this.crearAleatorio();
        }

        public override IComparable crearDesdeArchivo()
        {
            AlumnoCompuesto compuesto = new AlumnoCompuesto("Grupo Compuesto Archivo", 99, 99, 9);
            FabricaDeComparables fabricaHijos = new FabricaDeAlumnos(this.manejador);

            Console.WriteLine("Creando 5 hijos para el Alumno Compuesto desde archivo...");
            for(int i = 0; i < 5; i++)
            {
                IComparable hijo = fabricaHijos.crearDesdeArchivo();
                compuesto.agregarHijo((Alumno)hijo);
                Console.WriteLine($"Hijo {i + 1} agregado: {hijo.ToString()}");
            }
            return compuesto;
        }
    }
}
