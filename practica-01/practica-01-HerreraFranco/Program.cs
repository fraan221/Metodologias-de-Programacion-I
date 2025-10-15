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
        // PRUEBAS ANTERIORES 
        //FabricaDeComparables fabricaAlumnos = new FabricaDeAlumnos();
        //FabricaDeComparables fabricaNumeros = new FabricaDeNumeros();
        //FabricaDeComparables fabricaProfesores = new FabricaDeProfesor();

        //IColeccionable pila = new Pila();

        //// --- Prueba con Alumnos ---
        //IColeccionable coleccionAlumnos = new Pila();
        //Console.WriteLine("***** Llenando la Pila con Alumnos... *****");
        //llenar(coleccionAlumnos, fabricaAlumnos);

        //Console.WriteLine("\n***** Informando la Pila de Alumnos *****");
        //informar(coleccionAlumnos, fabricaAlumnos);

        //// --- Prueba con Números ---
        //IColeccionable coleccionNumeros = new Pila();
        //Console.WriteLine("\n***** Llenando la Pila con Números... *****");
        //llenar(coleccionNumeros, fabricaNumeros);

        //Console.WriteLine("\n***** Informando la Pila de Números *****");
        //informar(coleccionNumeros, fabricaNumeros);

        //// --- Prueba con Profesores ---
        //IColeccionable coleccionProfesores = new Pila();
        //Console.WriteLine("\n***** Llenando la Pila con Profesores... *****");
        //llenar(coleccionProfesores, fabricaProfesores);

        //Console.WriteLine("\n***** Informando la Pila de Profesores *****");
        //informar(coleccionProfesores, fabricaProfesores);

        // PRUEBA PATRÓN OBSERVER
        Profesor profesor = new Profesor("Dr. Pepito", 123456, 20);
        List<IObservador> alumnos = new List<IObservador>();

        FabricaDeComparables fabricaAlumnos = FabricaDeComparables.crearFabrica(FabricaDeComparables.ALUMNOS);

        Console.WriteLine("Creando y suscribiendo alumnos a la clase...");
        for (int i = 0; i < 5; i++)
        {
            Alumno nuevoAlumno = (Alumno)fabricaAlumnos.crearAleatorio();
            alumnos.Add(nuevoAlumno);
        }

        foreach (IObservador alumno in alumnos)
        {
            profesor.agregarObservador(alumno);
        }

        dictadoDeClases(profesor);
    }
}