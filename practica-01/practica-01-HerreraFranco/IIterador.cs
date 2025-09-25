using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_01_HerreraFranco
{
    public interface IIterador
    {
        void primero();
        void siguiente();
        bool fin();
        IComparable actual();
    }
}
