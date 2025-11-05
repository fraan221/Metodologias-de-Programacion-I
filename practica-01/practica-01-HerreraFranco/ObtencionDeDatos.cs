/*
 * Created by Metodologías de Programación I
 * Activity 7. 
 * Chain of responsability and Singleton patterns 
 *
 * Antes de usar este código el alumno deberá agregar a la variable "ruta_archivo" de la clase 
 * "LectorDeArchivos" la ruta correspondiente a su equipo donde haya guardado el archvo con los datos
 * provistos por la cátedra (archivo datos.txt)
 *
 * IMPORTANTE *  
 * El código que está en este archivo SI puede modificarse para resolver la actividad solicitada
 * 
 */

using System;
using System.IO;

namespace practica_01_HerreraFranco
{
	public class LectorDeArchivos : Manejador {
		private static LectorDeArchivos instancia = null;
		private const string ruta_archivo = @"C:\Users\fraan\Documents\UNIVERSIDAD\Materias\Metodologias_De_Programacion_I\entregas\datos.txt";
		
		private StreamReader lector_de_archivos;
		
		private LectorDeArchivos(Manejador s) : base(s){
			try
			{
				lector_de_archivos = new StreamReader(ruta_archivo);
			}
			catch (Exception e) { 
				Console.WriteLine("Error al abrir el archivo: " + e.Message);
				lector_de_archivos = null;
            }
		}

		public static LectorDeArchivos getInstance(Manejador s)
        {
            if (instancia == null)
            {
                instancia = new LectorDeArchivos(s);
            }
            return instancia;
        }

        public double numeroDesdeArchivo(double max)
		{
			if (lector_de_archivos == null || lector_de_archivos.EndOfStream)
            {
				Console.WriteLine("ADVERTENCIA: Se intento leer un numero del archivo, pero no fue posible.");
				return base.numeroDesdeArchivo(max);
            }
            string linea = lector_de_archivos.ReadLine();
			return Double.Parse(linea.Substring(0, linea.IndexOf('\t'))) * max;
		}
		
		public string stringDesdeArchivo(int cant)
		{
			if (lector_de_archivos == null || lector_de_archivos.EndOfStream)
			{
				Console.WriteLine("ADVERTENCIA: Se intento leer un string del archivo, pero no fue posible.");
                return base.stringDesdeArchivo(cant);
            }
			string linea = lector_de_archivos.ReadLine();
			linea = linea.Substring(linea.IndexOf('\t')+1);
			cant = Math.Min(cant, linea.Length);
			return linea.Substring(0, cant);
		}

		~LectorDeArchivos()
		{
			if (lector_de_archivos != null)
            {
                lector_de_archivos.Close();
            }
        }
	}
}
