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
        // EJERCICIO 2   
        //Teacher teacher = new Teacher();
        //GeneradorDeDatosAleatorios generador = new GeneradorDeDatosAleatorios();

        //for (int i = 0; i < 10; i++)
        //{
        //    Alumno alumno_base = new AlumnoProxy(generador.stringAleatorio(8), generador.numeroAleatorio(50000000), generador.numeroAleatorio(10000), generador.numeroAleatorio(10), false);
        //    Alumno alumno_decorado = new DecoradorLegajo(alumno_base);
        //    alumno_decorado = new DecoradorNotaLetras(alumno_decorado);
        //    alumno_decorado = new DecoradorAprobacion(alumno_decorado);
        //    alumno_decorado = new DecoradorRecuadro(alumno_decorado);
        //    Student student_final = new AlumnoAdapter(alumno_decorado);
        //    teacher.goToClass(student_final);
        //}

        //for (int i = 0; i < 10; i++)
        //{
        //    Alumno alumno_base = new AlumnoProxy("Estudioso " + i, 40000000 + i, 10000 + i, 9.5, true);
        //    Alumno alumno_decorado = new DecoradorLegajo(alumno_base);
        //    alumno_decorado = new DecoradorNotaLetras(alumno_decorado);
        //    alumno_decorado = new DecoradorAprobacion(alumno_decorado);
        //    alumno_decorado = new DecoradorRecuadro(alumno_decorado);
        //    Student student_final = new AlumnoAdapter(alumno_decorado);
        //    teacher.goToClass(student_final);
        //}

        //teacher.teachingAClass();

        // EJERCICIO 10
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
        Console.ReadKey(true);
    }
}