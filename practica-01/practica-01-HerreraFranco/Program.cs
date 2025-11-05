using System;
using practica_01_HerreraFranco;
using IComparable = practica_01_HerreraFranco.IComparable;

class Program
{
    public static void llenar(IColeccionable coleccion, FabricaDeComparables fabrica)
    {
        for (int i = 0; i < 20; i++)
        {
            IComparable nuevoElemento = fabrica.crearAleatorio();
            coleccion.agregar(nuevoElemento);
        }
    }

    public static void informar(IColeccionable coleccion, FabricaDeComparables fabrica)
    {
        Console.WriteLine("-----------------------------------");
        Console.WriteLine("Cantidad de elementos: " + coleccion.cuantos());

        if (coleccion.cuantos() > 0)
        {
            Console.WriteLine("Elemento mínimo: " + coleccion.minimo().ToString());
            Console.WriteLine("Elemento máximo: " + coleccion.maximo().ToString());

            Console.WriteLine("\n--- Búsqueda de un elemento ---");
            IComparable elementoBuscado = fabrica.crearPorTeclado();

            if (coleccion.contiene(elementoBuscado))
            {
                Console.WriteLine("El elemento SÍ está en la colección.");
            }
            else
            {
                Console.WriteLine("El elemento NO está en la colección.");
            }
        }
        else
        {
            Console.WriteLine("La colección está vacía.");
        }
        Console.WriteLine("-----------------------------------");
    }

    public static void dictadoDeClases(Profesor profe)
    {
        for (int i = 0; i < 5; i++)
        {
            profe.hablarALaClase();
            profe.escribirEnElPizzarron();
        }
    }

    static void Main(string[] args)
    {
        FabricaDeComparables fabricaAlumnos = FabricaDeComparables.crearFabrica(FabricaDeComparables.ALUMNOS);
        FabricaDeComparables fabricaEstudiosos = FabricaDeComparables.crearFabrica(FabricaDeComparables.ALUMNOS_ESTUDIOSOS);

        Console.WriteLine("--- Creando 5 Alumnos (Aleatorios) ---");
        for (int i = 0; i < 5; i++)
        {
            IComparable alumno = fabricaAlumnos.crearAleatorio();
            Console.WriteLine($"Creado: {alumno.ToString()}");
        }

        Console.WriteLine("\n--- Creando 2 Alumnos Muy Estudiosos (Teclado) ---");
        for (int i = 0; i < 2; i++)
        {
            IComparable alumnoEstudioso = fabricaEstudiosos.crearPorTeclado();
            Console.WriteLine($"Creado: {alumnoEstudioso.ToString()}");
        }

        Console.WriteLine("\n--- Creando Alumno Compuesto con 5 hijos (Archivo) ---");

        FabricaDeComparables fabricaCompuestos = FabricaDeComparables.crearFabrica(FabricaDeComparables.ALUMNOS_COMPUESTOS);

        IComparable alumnoCompuesto = fabricaCompuestos.crearDesdeArchivo();
        Console.WriteLine($"\nCompuesto creado: {alumnoCompuesto.ToString()}");

        Console.ReadKey(true);
    }
}