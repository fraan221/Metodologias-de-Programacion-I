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
        Teacher teacher = new Teacher();
        FabricaDeAlumnos fabricaAlumnos = new FabricaDeAlumnos();

        for (int i = 0; i < 10; i++)
        {
            Alumno alumno_base = (Alumno)fabricaAlumnos.crearAleatorio();
            Alumno alumno_decorado = new DecoradorLegajo(alumno_base);
            alumno_decorado = new DecoradorNotaLetras(alumno_decorado);
            alumno_decorado = new DecoradorAprobacion(alumno_decorado);
            alumno_decorado = new DecoradorRecuadro(alumno_decorado);
            Student student_final = new AlumnoAdapter(alumno_decorado);
            teacher.goToClass(student_final);
        }

        for (int i = 0; i < 10; i++)
        {
            AlumnoMuyEstudioso alumnoEstudioso_base = new AlumnoMuyEstudioso("Estudioso " + i, 40000000 + i, 10000 + i, 9.5);
            Alumno alumno_decorado = new DecoradorLegajo(alumnoEstudioso_base);
            alumno_decorado = new DecoradorNotaLetras(alumno_decorado);
            alumno_decorado = new DecoradorAprobacion(alumno_decorado);
            alumno_decorado = new DecoradorRecuadro(alumno_decorado);
            Student student_final = new AlumnoAdapter(alumno_decorado);
            teacher.goToClass(student_final);
        }

        teacher.teachingAClass();

        Console.ReadKey(true);
    }
}