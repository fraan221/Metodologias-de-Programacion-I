using System;
using practica_01_HerreraFranco;

class Program
{
    public static void llenar(IColeccionable c)
    {
        Random rnd = new Random();
        for (int i = 0; i < 20; i++)
        {
            Numero n = new Numero(rnd.Next(1, 101));
            c.agregar(n);
        }
    }

    //INFORMAR CON NUMEROS
    public static void informar(IColeccionable c)
    {
        Console.WriteLine("-----------------------------------");
        Console.WriteLine("Cantidad de elementos: " + c.cuantos());

        if (c.cuantos() > 0)
        {
            Console.WriteLine("Elemento minimo: " + ((Numero)c.minimo()).getValor());
            Console.WriteLine("Elemento maximo: " + ((Numero)c.maximo()).getValor());

            Console.Write("Ingrese un numero para buscar: ");
            int valorBuscado = int.Parse(Console.ReadLine());
            Numero numeroABuscar = new Numero(valorBuscado);

            if (c.contiene(numeroABuscar))
            {
                Console.WriteLine("El elemento " + valorBuscado + " Si esta en la coleccion.");
            }
            else
            {
                Console.WriteLine("El elemento " + valorBuscado + " NO esta en la coleccion.");
            }
        }
        else
        {
            Console.WriteLine("La coleccion esta vacia.");
        }
        Console.WriteLine("-----------------------------------");
    }

    //INFORMAR CON ALUMNOS
    public static void informarAlumnos(IColeccionable c)
    {
        Console.WriteLine("-----------------------------------");
        Console.WriteLine("Cantidad de elementos: " + c.cuantos());

        if (c.cuantos() > 0)
        {
            Console.WriteLine("Elemento mínimo: " + c.minimo().ToString());
            Console.WriteLine("Elemento máximo: " + c.maximo().ToString());
        }
        else
        {
            Console.WriteLine("La colección está vacía.");
        }
        Console.WriteLine("-----------------------------------");
    }

    public static void llenarAlumnos(IColeccionable c)
    {
        Random rnd = new Random();
        string[] nombres = { "Ana", "Luis", "Carlos", "Marta", "Sofia", "Jorge", "Lucia", "Pedro", "Elena", "Diego" };
        string[] apellidos = { "Gomez", "Perez", "Rodriguez", "Lopez", "Garcia", "Martinez", "Sanchez", "Ramirez", "Torres", "Flores" };

        for (int i = 0; i < 20; i++)
        {
            string nombreRnd = nombres[rnd.Next(nombres.Length)] + " " + apellidos[rnd.Next(apellidos.Length)];
            int dniRnd = rnd.Next(20000000, 40000000);
            int legajoRnd = rnd.Next(1000, 9999);
            double promedioRnd = Math.Round(rnd.NextDouble() * 10, 2);

            Alumno a = new Alumno(nombreRnd, dniRnd, legajoRnd, promedioRnd);
            c.agregar(a);
        }
    }

    public static void imprimirElementos(IIterable coleccion)
    {
        IIterador iterador = coleccion.crearIterador();
        while (!iterador.fin())
        {
            Console.WriteLine(iterador.actual().ToString());
            iterador.siguiente();
        }
    }

    public static void cambiarEstrategia(IIterable coleccion, IEstrategiaDeComparacion estrategia)
    {
        IIterador iterador = coleccion.crearIterador();

        while (!iterador.fin())
        {
            Alumno alumnoActual = (Alumno)iterador.actual();
            alumnoActual.setEstrategia(estrategia);
            iterador.siguiente();
        }
    }

    static void Main(string[] args)
    {
        //EJERCICIO 7
        //IColeccionable pila = new Pila();
        //IColeccionable cola = new Cola();

        //llenar(pila);
        //llenar(cola);

        //Console.WriteLine("Informacion de la Pila");
        //informar(pila);

        //Console.WriteLine("Informacion de la Cola");
        //informar(cola);

        //EJERCICIO 9
        //Pila pila = new Pila();
        //Cola cola = new Cola();

        //llenar(pila);
        //llenar(cola);

        //ColeccionMultiple multiple = new ColeccionMultiple(pila, cola);

        //Console.WriteLine("Informacinon de la Pila");
        //informar(pila);
        //Console.WriteLine("Informacion de la Cola");
        //informar(cola);

        //Console.WriteLine("Informacion de la Coleccion Multiple");
        //informar(multiple);

        //EJERCICIO 14
        //Pila pila = new Pila();
        //Cola cola = new Cola();

        //llenarAlumnos(pila);
        //llenarAlumnos(cola);

        //ColeccionMultiple multiple = new ColeccionMultiple(pila, cola);

        //Console.WriteLine("Informacion de la Colección Múltiple de Alumnos");
        //informarAlumnos(multiple);

        //PRACTICA 02 - EJERCICIO 7
        //IIterable pila = new Pila();
        //IIterable cola = new Cola();
        //IIterable conjunto = new Conjunto();

        //llenarAlumnos(pila as IColeccionable);
        //llenarAlumnos(cola as IColeccionable);
        //llenarAlumnos(conjunto as IColeccionable);

        //Console.WriteLine("Elementos en la Pila:");
        //imprimirElementos(pila);

        //Console.WriteLine("Elementos en la Cola:");
        //imprimirElementos(cola);

        //Console.WriteLine("Elementos en el Conjunto:");
        //imprimirElementos(conjunto);

        //PRACTICA 02 - EJERCICIO 9
        Pila pila = new Pila();
        llenarAlumnos(pila);

        Console.WriteLine("Elementos en la Pila (INFORME INICIAL) (Estrategia por DNI):");
        informarAlumnos(pila);

        IEstrategiaDeComparacion estrategiaNombre = new EstrategiaPorNombre();

        cambiarEstrategia(pila, estrategiaNombre);

        Console.WriteLine("Elementos en la Pila (INFORME 2) (Estrategia por Nombre):");
        informarAlumnos(pila);

        IEstrategiaDeComparacion estrategiaPromedio = new EstrategiaPorPromedio();
        cambiarEstrategia(pila, estrategiaPromedio);

        Console.WriteLine("Elementos en la Pila (INFORME 3) (Estrategia por Promedio):");
        informarAlumnos(pila);

        //RESPUESTA PREGUNTA PUNTO 10
        // No tuve que hacer nada. Ya que 'imprimirElementos' trabaja con la interfaz IIterable,
        // y todos los elementos (Pila, Cola, Conjunto) implementan esa interfaz, por lo que 
        // la funcion la aceptó sin necesidad de cambios.

        // RESPUESTA PREGUNTA PUNTO 11
        // Podría crearse un nuevo iterador que devuelva unicamente los alumnos que cumplan con
        // esa conficion.
    }
}