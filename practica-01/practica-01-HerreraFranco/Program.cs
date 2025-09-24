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

            Console.Write("Ingrese un DNI para buscar: ");
            int dniBuscado = int.Parse(Console.ReadLine());
            Persona personaParaBuscar = new Alumno("aux", dniBuscado, 0, 0);

            if (c.contiene(personaParaBuscar))
            {
                Console.WriteLine("El DNI " + dniBuscado + " SÍ está en la colección.");
            }
            else
            {
                Console.WriteLine("El DNI " + dniBuscado + " NO está en la colección.");
            }
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
        Pila pila = new Pila();
        Cola cola = new Cola();

        llenarAlumnos(pila);
        llenarAlumnos(cola);

        ColeccionMultiple multiple = new ColeccionMultiple(pila, cola);

        Console.WriteLine("Informacion de la Colección Múltiple de Alumnos");
        informarAlumnos(multiple);
    }
}