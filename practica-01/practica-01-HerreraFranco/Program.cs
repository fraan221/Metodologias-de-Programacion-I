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
            Alumno alumno = (Alumno)fabricaAlumnos.crearAleatorio();
            Student student_adaptado = new AlumnoAdapter(alumno);
            Student student_decorado = new DecoradorLegajo(student_adaptado);
            student_decorado = new DecoradorNotaLetras(student_decorado);
            student_decorado = new DecoradorAprobacion(student_decorado);
            student_decorado = new DecoradorRecuadro(student_decorado);
            teacher.goToClass(student_decorado);
        }

        for (int i = 0; i < 10; i++)
        {
            AlumnoMuyEstudioso alumnoEstudioso = new AlumnoMuyEstudioso("Estudioso " + i, 40000000 + i, 10000 + i, 9.5);
            Student student_adaptado = new AlumnoAdapter(alumnoEstudioso);
            Student student_decorado = new DecoradorLegajo(student_adaptado);
            student_decorado = new DecoradorNotaLetras(student_decorado);
            student_decorado = new DecoradorAprobacion(student_decorado);
            student_decorado = new DecoradorRecuadro(student_decorado);
            teacher.goToClass(student_decorado);
        }

        teacher.teachingAClass();

        Console.ReadKey(true);
    }
}