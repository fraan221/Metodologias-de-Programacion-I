using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_01_HerreraFranco
{
    public class AlumnoCompuesto : Alumno
    {
        private List<Alumno> hijos;
        private static Random random = new Random();

        public AlumnoCompuesto(string n, int d, int l, double p) : base(n, d, l, p)
        {
            this.hijos = new List<Alumno>();
        }

        public void agregarHijo(Alumno a)
        {
            this.hijos.Add(a);
        }

        public override string getNombre()
        {
            return string.Join(", ", this.hijos.Select(h => h.getNombre()));
        }

        public override int responderPregunta(int pregunta)
        {
            if (hijos.Count == 0) return 0;

            List<int> respuestas = this.hijos.Select(h => h.responderPregunta(pregunta)).ToList();
            var groups = respuestas.GroupBy(r => r);
            var maxCount = groups.Max(g => g.Count());
            var mostVoted = groups.Where(g => g.Count() == maxCount).Select(g => g.Key).ToList();

            return mostVoted[random.Next(mostVoted.Count)];
        }

        public override void setCalificacion(int calif)
        {
            foreach (Alumno hijo in this.hijos)
            {
                hijo.setCalificacion(calif);
            }
        }

        public override string mostrarCalificacion()
        {
            return string.Join("\n", this.hijos.Select(h => h.mostrarCalificacion()));
        }

        public override bool sosIgual(IComparable c)
        {
            return this.hijos.Any(h => h.sosIgual(c));
        }

        public override bool sosMenor(IComparable c)
        {
            return this.hijos.All(h => h.sosMenor(c));
        }

        public override bool sosMayor(IComparable c)
        {
            return this.hijos.All(h => h.sosMayor(c));
        }

        public override int getCalificacion()
        {
            if (hijos.Count == 0) return 0;
            return (int)this.hijos.Average(h => h.getCalificacion());
        }

        public override int getLegajo()
        {
            if (hijos.Count == 0) return 0;
            return this.hijos[0].getLegajo();
        }

        public override double getPromedio()
        {
            if (hijos.Count == 0) return 0;
            return this.hijos.Average(h => h.getPromedio());
        }
    }
}
