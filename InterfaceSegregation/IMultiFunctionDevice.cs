using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{
    internal interface IMultiFunctionDevice
    {
        void Print();
        void Scan();
        void Fax();
    }
}
