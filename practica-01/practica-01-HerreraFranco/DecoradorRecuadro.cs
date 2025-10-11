using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_01_HerreraFranco
{
    public class DecoradorRecuadro : AdicionalDecorator
    {
        public DecoradorRecuadro(Student s) : base(s) { }

        public override string showResult()
        {
            string resultadoInterno = base.showResult();
            string linea = new string('*', resultadoInterno.Length + 4);
            return $"{linea}\n* {resultadoInterno} *\n{linea}";
        }
    }
}
