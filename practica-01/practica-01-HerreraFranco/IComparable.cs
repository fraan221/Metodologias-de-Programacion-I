using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_01_HerreraFranco
{
    public interface IComparable
    {
        bool sosIgual(IComparable c);
        bool sosMenor(IComparable c);
        bool sosMayor(IComparable c);
    }
}
