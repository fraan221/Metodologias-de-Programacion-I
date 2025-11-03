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

    /*
     --- RESPUESTAS PREGUNTAS PRACTICA 6 ---
    Al agregar un `AlumnoCompuesto`, ¿qué objeto necesita ser adaptado?
    El objeto que necesita ser adaptado es el AlumnoCompuesto.
    Gracias al principio de transparencia del patrón Composite, nuestro `AlumnoAdapter`
    existente puede adaptarlo perfectamente sin necesidad de ninguna modificación.

    ¿Qué se modificó para cambiar la lógica del juego de "N manos" a "alcanzar un puntaje"?
    La modificación principal se realizó en el Método Plantilla (el método jugar())
    dentro de la clase abstracta JuegoDeCartas. Se cambió el "esqueleto" del algoritmo
    (el bucle for se reemplazó por un while basado en puntaje).
    Las clases concretas solo tuvieron que adaptar la lógica interna
    de los pasos, pero su estructura y firmas de métodos no cambiaron.

     */

    static void Main(string[] args)
    {
        // Base de la Practica 5
        Aula aula = new Aula();
        Pila pila = new Pila();

        OrdenEnAula1 ordenInicio = new OrdenInicio(aula);
        OrdenEnAula2 ordenLlegaAlumno = new OrdenLlegaAlumno(aula);
        OrdenEnAula1 ordenAulaLlena = new OrdenAulaLlena(aula);

        pila.setOrdenInicio(ordenInicio);
        pila.setOrdenLlegaAlumno(ordenLlegaAlumno);
        pila.setOrdenAulaLlena(ordenAulaLlena);

        FabricaDeComparables fabricaAlumnos = FabricaDeComparables.crearFabrica(FabricaDeComparables.ALUMNOS);
        FabricaDeComparables fabricaEstudiosos = FabricaDeComparables.crearFabrica(FabricaDeComparables.ALUMNOS_ESTUDIOSOS);

        llenar(pila, fabricaAlumnos);
        llenar(pila, fabricaEstudiosos);

        Console.WriteLine("Elementos en la pila: " + pila.cuantos());
        Console.WriteLine("Agregando Alumno Compuesto...");
        
        FabricaDeComparables fabricaCompuestos = FabricaDeComparables.crearFabrica(FabricaDeComparables.ALUMNOS_COMPUESTOS);
        IComparable alumnoCompuesto = fabricaCompuestos.crearAleatorio();

        pila.agregar(alumnoCompuesto);

        Console.WriteLine("Elementos en la pila después de agregar el compuesto: " + pila.cuantos());
        Console.WriteLine("El alumno compuesto llego tarde a la clase.");

        // Juego de Cartas

        Console.WriteLine("\n\n--- Iniciando prueba de Template Method (Juego de Cartas) ---");

        Persona p1 = new Alumno("Franco Herrera", 44966422, 1, 8.5);
        Persona p2 = new Alumno("Carolina Herrera", 12345678, 9, 10);

        JuegoDeCartas juego = new JuegoDeGuerra();
        Console.WriteLine($"\n--- Jugando {juego.GetType().Name} ---");
        Persona ganador = juego.jugar(p1, p2);
        Console.WriteLine($"El ganador es: {ganador.getNombre()}");

        juego = new JuegoDeEscoba();
        Console.WriteLine($"\n--- Jugando {juego.GetType().Name} ---");
        ganador = juego.jugar(p1, p2);
        Console.WriteLine($"El ganador es: {ganador.getNombre()}");

        Console.ReadKey(true);
    }
}